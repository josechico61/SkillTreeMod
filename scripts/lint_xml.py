#!/usr/bin/env python3
"""
7DTD SkillTreeMod XML Guardrail Linter
--------------------------------------
Validates UI XML files against docs/ai/schema/xui_schema.json.

- Enforces vanilla-safe tag/attribute sets.
- Rejects unknown tags or attributes not in the schema.
- Rejects invalid color formats (hex colors).
- Skips reference/example XMLs in docs/ai/reference.
"""

import json
import re
import sys
import pathlib
import xml.etree.ElementTree as ET

SCHEMA_PATH = pathlib.Path("docs/ai/schema/xui_schema.json")

# ---------------------------------------------------------------------------
# Helpers
# ---------------------------------------------------------------------------

def load_schema():
    if not SCHEMA_PATH.exists():
        sys.exit(f"❌ Schema not found: {SCHEMA_PATH}")
    with open(SCHEMA_PATH, "r", encoding="utf-8") as f:
        return json.load(f)

def is_reference_file(path: pathlib.Path) -> bool:
    """Skip validation for reference/example XMLs."""
    path_str = str(path).replace("\\", "/")
    return "docs/ai/reference" in path_str or "/reference/" in path_str

def err(file, elem, msg):
    line = getattr(elem, "sourceline", "?")
    return f"{file}:{line}: {msg}"

def iter_with_lines(root):
    """Yield elements (ElementTree doesn't keep line numbers consistently)."""
    for e in root.iter():
        yield e

# ---------------------------------------------------------------------------
# Lint logic
# ---------------------------------------------------------------------------

def lint_file(path: pathlib.Path, schema) -> list[str]:
    problems = []

    if is_reference_file(path):
        print(f"⚙️  Skipping reference file: {path}")
        return problems

    allowed_tags = set(schema["xui:allowed_tags"])
    global_attrs = set(schema["xui:global_attribute_whitelist"])
    elements = schema["elements"]
    regex_rules = schema.get("xui:regex_rules", {})

    try:
        tree = ET.parse(path)
    except Exception as ex:
        return [f"{path}:0: XML parse error: {ex}"]

    root = tree.getroot()

    for e in iter_with_lines(root):
        tag = e.tag

        # Tag allow-list
        if tag not in allowed_tags:
            problems.append(err(path, e, f"Unknown tag <{tag}> not in allowed tag list"))
            continue

        attrs = set(e.attrib.keys())

        # Element-specific rules
        allowed_elem_attrs = set(elements.get(tag, {}).get("allowed_attributes", []))

        # Check attributes
        for a in attrs:
            if a not in global_attrs and a not in allowed_elem_attrs:
                problems.append(err(path, e, f"Attribute '{a}' on <{tag}> not in whitelist"))

        # Regex-based rules (e.g., hex color ban)
        for rule_name, rule in regex_rules.items():
            for pat in rule.get("forbidden", []):
                pat_re = re.compile(pat)
                for k, v in e.attrib.items():
                    if pat_re.search(v or ""):
                        problems.append(
                            err(path, e, f"Value '{v}' violates rule '{rule_name}' ({rule.get('description','')})")
                        )

    return problems

# ---------------------------------------------------------------------------
# Entry point
# ---------------------------------------------------------------------------

def main():
    if len(sys.argv) < 2:
        print("Usage: scripts/lint_xml.py <path(s) to .xml>")
        sys.exit(2)

    schema = load_schema()
    all_paths = [pathlib.Path(p) for p in sys.argv[1:]]
    problems: list[str] = []

    for path in all_paths:
        if not path.exists():
            print(f"⚠️  File not found: {path}")
            continue
        problems.extend(lint_file(path, schema))

    if problems:
        print("\n❌ XML guardrails failed:\n")
        for p in problems:
            print(p)
        print(f"\nFound {len(problems)} issue(s). Please fix before committing.\n")
        sys.exit(1)
    else:
        print("✅ XML guardrails passed (schema + project rules clean).")

if __name__ == "__main__":
    main()
