
#!/usr/bin/env python3
# validate_xui_against_schema.py
# Validates 7DTD XUi XML files against observed schema (from mine_xui_schema.py).
# Flags: unknown elements/attributes; suspicious enum values for anchor/pivot/visible; xui.xml append paths existence (optional hint).
#
# Usage:
#   python tools/validate_xui_against_schema.py --schema docs/xui_schema.json --xml Mods/YourMod/Config/XUi/windows.xml [--strict]
#
import argparse, json, sys, os, xml.etree.ElementTree as ET

def c(label, text):
    return f"{label} {text}"

WARN = "WARN"
ERR  = "ERR "
OK   = "OK  "

def load_schema(path):
    with open(path, "r", encoding="utf-8") as f:
        s = json.load(f)
    return s

def load_xml(path):
    try:
        tree = ET.parse(path)
        return tree.getroot(), None
    except Exception as ex:
        return None, str(ex)

def main():
    ap = argparse.ArgumentParser(description="Validate 7DTD XUi XML against observed schema.")
    ap.add_argument("--schema", required=True, help="Path to xui_schema.json produced by mine_xui_schema.py")
    ap.add_argument("--xml", required=True, nargs="+", help="XML files to validate")
    ap.add_argument("--strict", action="store_true", help="Treat all warnings as errors")
    args = ap.parse_args()

    schema = load_schema(args.schema)
    elements = schema.get("elements", {})
    interesting = schema.get("interesting_values", {})

    errs = 0
    warns = 0

    def is_known_tag(tag):
        return tag in elements

    def is_known_attr_for_tag(tag, attr):
        ed = elements.get(tag, {})
        return attr in ed.get("attributes", {})

    def is_known_enum(attr, val):
        vals = interesting.get(attr, {})
        return val in vals

    for xml_path in args.xml:
        root, error = load_xml(xml_path)
        if error:
            print(c(ERR, f"{xml_path}: not well-formed XML ({error})"))
            errs += 1
            continue
        print(c(OK, f"{xml_path}: parsed"))

        for el in root.iter():
            tag = el.tag
            if not is_known_tag(tag):
                print(c(WARN, f"Unknown element <{tag}> — not observed in schema"))
                warns += 1

            for a, v in el.attrib.items():
                if not is_known_attr_for_tag(tag, a):
                    print(c(WARN, f"<{tag}> has unknown attribute '{a}' — not seen on this element in schema"))
                    warns += 1

                # enum checks
                if a in ("anchor","pivot"):
                    if v.startswith("{") and v.endswith("}"):
                        print(c(WARN, f"<{tag}> attribute {a} uses binding {v}; expected literal from enum"))
                        warns += 1
                    elif not is_known_enum(a, v):
                        print(c(WARN, f"<{tag}> attribute {a} has unusual value '{v}' — not seen in schema"))
                        warns += 1
                if a == "visible":
                    if v.startswith("{") and v.endswith("}"):
                        # binding is fine
                        pass
                    else:
                        if not is_known_enum("visible", v):
                            print(c(WARN, f"<{tag}> visible='{v}' not seen as a literal in schema (bindings are common)"))
                            warns += 1

                if tag == "window" and a in ("width","height"):
                    print(c(ERR, f"<window> must not have '{a}'. Size using inner <rect>/<grid>."))
                    errs += 1

    if args.strict and warns > 0:
        errs += warns
        print(c(ERR, "Strict mode: warnings count as errors."))

    if errs == 0:
        print(c(OK, f"Validation complete: 0 errors, {warns} warnings."))
        sys.exit(0)
    else:
        print(c(ERR, f"Validation complete: {errs} errors, {warns} warnings."))
        sys.exit(1)

if __name__ == "__main__":
    main()
