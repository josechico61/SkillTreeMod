\# 7DTD XUi Design Rules (Layout, Math \& Workflow)

\_Companion to\_ `codex-rules.md` \_(syntax guardrails)\_ \_and\_ `xui-logic.md` \_(file/flow).\_  

This file captures \*\*how to place \& size things\*\* so outputs look right the first time.



---



\## 0) Coordinates, Units, Scaling



\- \*\*Units are pixels\*\* assuming \*\*1080p\*\* reference. Take screenshots at \*\*1920×1080\*\* and set \*\*UI Size = 100%\*\* while designing for 1:1 pixel planning.

\- 2D basis: \*\*X increases right\*\*, \*\*Y increases down\*\*.

\- `pos="x,y"` is an offset in \*\*group anchor space\*\*; `pivot` decides \*\*which point of the element\*\* sits at that offset.

\- Colors must be \*\*RGBA integers\*\* or \*\*style tokens\*\* like `\[white]` (no hex).



---



\## 1) Anchors (critical)



\- A window’s `anchor` must be a \*\*name that exists inside the target `window\_group`\*\* (e.g., `compass`, `CenterCenter`, `toolbelt`, etc.), \*\*or\*\* the name of \*\*another window you also register in that group\*\* (custom anchor window pattern).

\- For center overlays, use:  

&nbsp; `window\_group: compass`, `anchor="CenterCenter"`.



\### Custom anchor window (pattern)

```xml

<!-- windows.xml -->

<window name="SkillTreeAnchor" anchor="compass" clipWindow="true">

&nbsp; <rect name="origin" pos="0,0" width="0" height="0"/>

</window>

<window name="SkillTreeWidget" anchor="SkillTreeAnchor" clipWindow="true"> ... </window>



<!-- xui.xml -->

<append xpath="/xui/ruleset\[@name='default']/window\_group\[@name='compass']">

&nbsp; <window name="SkillTreeAnchor"  anchor="compass"/>

&nbsp; <window name="SkillTreeWidget"  anchor="SkillTreeAnchor"/>

</append>



