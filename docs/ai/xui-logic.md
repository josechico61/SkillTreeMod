# 7DTD XUi Logic & Controller Binding (SkillTreeMod)

This document teaches how vanilla-style UI parts connect so generators build working UIs (not just layouts).

## File Roles
- **Config/XUi/windows.xml** — Define individual `<window>` layouts (rects/grids/sprites/labels/buttons). May include `controller="XUiC_*"` on the window or child.
- **Config/XUi/xui.xml** — Register windows into `window_group`s under the active ruleset:
  ```xml
  <configs>
    <append xpath="/xui/ruleset[@name='default']">
      <window_group name="groupName" controller="XUiC_SomeGroup" defaultSelected="content">
        <window name="SomeWindow" anchor="Center"/>
      </window_group>
    </append>
  </configs>
