
# Mod Assistant Integration Guide (7DTD XUi)

This guide shows how to "teach" your coding assistant to make **precise**, **vanilla-compatible** UI with the new cheat‑sheet.

---

## 0) Files to keep in your repo

```
tools/
  mine_xui_schema.py
  make_xui_cheatsheet.py
  validate_xui_against_schema.py
docs/
  xui_cheatsheet.md
  xui_schema.json
  ASSISTANT_GUIDE.md   (this file)
prompts/
  PROMPT_mod_assistant_seed.txt
```

- Regenerate `xui_schema.json` and `xui_cheatsheet.md` whenever you update UI XML.
- The validator uses `xui_schema.json` to flag off‑spec tags/attributes/values before you launch the game.

---

## 1) Non‑negotiable rules (vanilla style)

- **Never** put `width`/`height` on `<window>`. Size/position via inner `<rect>`/`<grid>`.
- Use **exact vanilla 7DTD UI XML syntax**. No custom attributes. No "flavor".
- For mod merges: use **XPath `<append>`/`<set>`** only where the vanilla xui.xml supports it. No `<include>` hacks inside xui.xml.
- Bindings use `{binding_name}`; literals must match observed enums from the cheat‑sheet (e.g., `anchor="Center"`, `pivot="TopLeft"`).
- Keep new windows in **windows.xml**; reference them via **xui.xml** `ruleset/window_group` that actually exists in vanilla.

---

## 2) Workflow you follow every time

1. **You** do layout/aesthetics (shapes, colors, art).  
2. **Assistant** does: window scaffolding, reliable anchors/pivots, controller hooks, open/close logic, bindings, and key mapping.
3. Run: `python tools/validate_xui_against_schema.py --schema docs/xui_schema.json --xml Mods/YourMod/Config/XUi/windows.xml`
4. Fix any warnings. Launch the game only after “0 errors”.

---

## 3) What the assistant must read before coding

- `docs/xui_cheatsheet.md` — observed enums for `anchor`, `pivot`, `visible`, common attributes per element.
- **Rules above.**

Tip: Paste the **seed prompt** (`prompts/PROMPT_mod_assistant_seed.txt`) into your coding agent as **System** or **Developer** message.

---

## 4) Ready‑to‑paste Task Templates

### A) Make a new window (layout only, no logic)
```
Task: Create a new XUi window named {WindowName}. Vanilla XML only.
Constraints:
- Do not set width/height on <window>.
- Use inner <rect> or <grid> to size and place content.
- Use enums only from docs/xui_cheatsheet.md for anchor/pivot/side/orientation.
Deliverables:
1) windows.xml snippet with <window name="{WindowName}" ...> block only.
2) xui.xml patch with <append> to register the window in an existing vanilla window_group that actually exists.
3) No includes inside xui.xml. Use valid XPath append.
```

### B) Add open/close logic bound to a key
```
Task: Wire {WindowName} to open on key {KeyOpen} and close on {KeyClose or 'X button'}.
Constraints:
- Use vanilla-compatible controller pattern (no custom scripts).
- Provide: windows.xml snippet (adds a close button sprite/label), a xui.xml input/action mapping if required, and a recipes to add visibility binding `{windowvisible}`.
- Use observed values for attributes (see cheat-sheet).
```

### C) Add a button that triggers a controller event
```
Task: Add a <button> to {WindowName} that calls controller event "{EventName}".
Constraints: Show the button block and the window header where controller is declared.
```

### D) Patch an existing vanilla window group
```
Task: Append {WindowName} to ruleset "default", window_group "{GroupName}".
Constraints: Use the exact path that exists in vanilla xui.xml; provide the <append xpath="..."> patch.
```

---

## 5) Self‑check list the assistant must pass

- [ ] No width/height on <window>.
- [ ] Every attribute is present in the cheat‑sheet's "Attribute Dictionary" for its element, or justified.
- [ ] `anchor`/`pivot` values are from the Common Enums table.
- [ ] xui.xml patches point to **existing** ruleset/window_group.
- [ ] No `<include>` inside xui.xml.
- [ ] windows.xml compiles standalone (well‑formed XML).

---

## 6) Example “minimal” red test window (vanilla‑style layout only)

```xml
<!-- windows.xml -->
<windows>
  <window name="SkillTreeMenu" anchor="Center" clipWindow="true">
    <rect name="layout" pos="0,0" width="600" height="350" pivot="Center">
      <sprite name="bg" color="255,0,0,255" type="sliced" />
      <label name="title" pos="10,-10" pivot="TopLeft" text="SkillTreeMenu" />
      <button name="close" pos="-10,10" pivot="TopRight" width="24" height="24" text="X" />
    </rect>
  </window>
</windows>
```

> Note: Size lives on the inner `<rect>`, not on `<window>`.

---

## 7) How to regenerate docs + validate

```bash
# Rebuild schema + cheat-sheet
python tools/mine_xui_schema.py "C:/.../7 Days To Die/Data/Config" --out docs/xui_schema.json --md docs/xui_cheatsheet.md

# Validate your mod windows against the schema
python tools/validate_xui_against_schema.py --schema docs/xui_schema.json --xml Mods/YourMod/Config/XUi/windows.xml
```

---

## 8) Tips for precision tasks

- Ask the assistant for **snippets only**, not entire files, when patching.
- Always run the validator after any assistant change.
- Keep one feature per commit so you can revert regressions fast.
