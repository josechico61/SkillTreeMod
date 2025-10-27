\# 7DTD UI XML Guardrails (Vanilla-Only)



\*\*Purpose\*\*

Codex must generate UI XML that matches vanilla 7DTD patterns exactly. Never invent tags/attributes. Prefer copying patterns from official vanilla XML (and `docs/ai/codex-examples.xml`) and then adjusting names/positions only.



---



\## Golden Rules

1) <window> MAY include width/height when mirroring vanilla/mod patterns.
   Still keep layout in containers (<rect>/<grid>) and avoid non-vanilla attributes.

2\) \*\*Use vanilla tags and attributes only.\*\* If you haven’t seen an attribute in vanilla, do not add it.

3\) \*\*Prefer layout containers.\*\* Use `<rect>` or `<grid>` for sizing/placement. Avoid placing content directly under `<window>` unless mirroring a vanilla pattern.

4\) \*\*Attribute order and structure should mirror vanilla.\*\* Keep attributes short and conventional (e.g., `name`, `pos`, `rows`, `cols`, `width`, `height`, etc.).

5\) \*\*Depth increases forward.\*\* Child draw order follows increasing `depth`. Do not skip to negative or wild depths unless copying a vanilla example that does so.

6\) \*\*Color format:\*\* `R,G,B,A` (0–255), no hex, no named colors.

7\) \*\*No custom attributes.\*\* If a behavior needs a controller, use an existing vanilla controller name seen in vanilla files; otherwise omit.

8\) \*\*Minimalism.\*\* Only include what the vanilla example needs; don’t add helpful-but-nonvanilla sugar.



---



\## Structural Rules



\### `<windows>` root

\- One `<windows>` root element per file.



\### `<window>`

\- Allowed common attributes (as seen in vanilla): `name`, `anchor`, `controller`, `pivot`, `background`, `clipWindow`, `cursorLock`, `modal`, `visible`.

\- \*\*Forbidden on `<window>`:\*\* `width`, `height`.

\- Children should be \*\*layout containers\*\*: `<rect>` and/or `<grid>`. Place sprites, text, and buttons \*inside\* those.



\### Layout containers

\- `<rect>`: Use for fixed-size blocks. Typical attributes: `name?`, `pos?`, `rows?`, `cols?`, `width`, `height`, `side?`, `pivot?`.

\- `<grid>`: Use for grid layouts. Typical attributes: `name?`, `pos?`, `rows`, `cols`, `cell\_width?`, `cell\_height?`, `repeat\_content?`, `side?`, `pivot?`.



\### Visuals and widgets

\- `<sprite>`: Use for images/borders. Common: `depth`, `name?`, `color?`, `type?` (e.g., `sliced`).

\- `<filledsprite>`: Use for progress bars/background fills. Common: `depth`, `name?`, `color`, `type="filled"`, `fill="0..1"`.

\- `<label>`: Text. Common: `depth`, `name?`, `text`, `font\_size?`, `color?`, `align?`, `pivot?`.

\- `<button>`: Clickable control. Common: `depth`, `name`, `width`, `height`, `pos?`, plus standard child sprites/labels as per vanilla patterns.

\- Keep child ordering consistent: background/border (lower `depth`), then content (higher `depth`).



---



\## Attribute \& Formatting Rules

\- Positions: `pos="X,Y"` integers unless a vanilla example shows otherwise.

\- Sizes: integers in `width`/`height` on layout items (not on `<window>`).

\- Colors: `R,G,B,A` with 0–255 integers (e.g., `255,0,0,255`).

\- Booleans: lower-case vanilla values (`true`/`false`) only if seen in vanilla.

\- Names: `CamelCase` or `VanillaStyle` consistent with examples (e.g., `SkillTreeMenuWindow`, `closeButton`).



---



\## Controller \& Binding

\- Only use controllers already present in vanilla (e.g., `HUDStatBar`) when the file’s purpose matches. Otherwise, omit controllers for static layouts.

\- Do not invent new bindings/placeholders. Use literal text for labels in examples.



---



\## Lint (things to auto-reject during review)

\- `<window ... width=` or `<window ... height=` → \*\*reject\*\*.

\- Unknown tags (not found in vanilla): \*\*reject\*\*.

\- Unknown attributes: \*\*reject\*\*.

\- Non-integer color components or hex colors: \*\*reject\*\*.

\- Text nodes placed directly under `<windows>` (without `<window>`): \*\*reject\*\*.



---



\## How to extend safely

When adding new UI:

1\) Start from the \*\*Good\*\* pattern in `docs/ai/codex-examples.xml`.

2\) Change names/positions/text only.

3\) Keep `<window>` attribute set minimal (no `width`/`height`).

4\) Validate depth order and color formats.

5\) Compare to a similar vanilla window for final structure.



