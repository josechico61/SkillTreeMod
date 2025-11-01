using System;
using System.Reflection;
using HarmonyLib;
using UnityEngine;


    [HarmonyPatch(typeof(EntityPlayerLocal), "Update")]
    public static class SkillTree_Keybind
    {
        // Use the GROUP name from xui.xml, EXACTLY as written there:
        // <window_group name="skilltree">...</window_group>
        private const string GroupId = "SkillTreeMenu";   // <-- changed

        private static object _wm;                 // LocalPlayerUI.windowManager
        private static object _xui;                // LocalPlayerUI.xui
        private static MethodInfo _miIsOpen;
        private static MethodInfo _miOpenIfNotOpen;
        private static MethodInfo _miOpen;
        private static MethodInfo _miClose;
        private static MethodInfo _miShortcutsAllowed;
        private static bool _cacheTried;

        static void Postfix(EntityPlayerLocal __instance)
        {
            if (!Input.GetKeyDown(KeyCode.K)) return;

            var lpui = __instance?.PlayerUI;
            if (lpui == null) { Debug.Log("[SkillTreeMod] PlayerUI is null."); return; }

            var xuiField = lpui.GetType().GetProperty("xui")?.GetValue(lpui, null)
                        ?? lpui.GetType().GetField("xui")?.GetValue(lpui);
            if (xuiField == null) { Debug.Log("[SkillTreeMod] xui is null."); return; }

            var isReadyProp = xuiField.GetType().GetProperty("isReady");
            if (isReadyProp != null && isReadyProp.PropertyType == typeof(bool))
            {
                if (!(bool)isReadyProp.GetValue(xuiField, null))
                { Debug.Log("[SkillTreeMod] xui not ready."); return; }
            }

            EnsureCache(lpui, xuiField);
            if (_wm == null && _xui == null)
            { Debug.Log("[SkillTreeMod] Could not cache window targets/methods."); return; }

            if (_wm != null && _miShortcutsAllowed != null)
            {
                var allowed = (bool)_miShortcutsAllowed.Invoke(_wm, null);
                if (!allowed) { Debug.Log("[SkillTreeMod] Shortcuts blocked."); return; }
            }

            try
            {
                object tgt = _wm ?? _xui;

                bool isOpen = false;
                if (_miIsOpen != null)
                    isOpen = (bool)_miIsOpen.Invoke(tgt, new object[] { GroupId }); // <-- group
                else
                    Debug.Log("[SkillTreeMod] IsWindowOpen unavailable; assuming closed.");

                if (isOpen)
                {
                    if (_miClose != null)
                    {
                        _miClose.Invoke(tgt, new object[] { GroupId });            // <-- group
                        Debug.Log("[SkillTreeMod] Close -> " + GroupId);
                    }
                    else Debug.Log("[SkillTreeMod] Close method not found.");
                }
                else
                {
                    if (_miOpenIfNotOpen != null)
                    {
                        //                id        modal   pause   focus
                        _miOpenIfNotOpen.Invoke(tgt, new object[] { GroupId, true, false, true }); // <-- modal=true
                        Debug.Log("[SkillTreeMod] OpenIfNotOpen (modal) -> " + GroupId);
                    }
                    else if (_miOpen != null)
                    {
                        // Prefer the 4-arg Open if present; otherwise it will fall back to 1-arg in EnsureCache
                        var p = _miOpen.GetParameters();
                        if (p.Length == 4)
                            _miOpen.Invoke(tgt, new object[] { GroupId, true, false, true });        // <-- modal=true
                        else
                            _miOpen.Invoke(tgt, new object[] { GroupId });
                        Debug.Log("[SkillTreeMod] Open -> " + GroupId);
                    }
                    else Debug.Log("[SkillTreeMod] Open method not found.");
                }
            }
            catch (Exception e)
            {
                Debug.Log("[SkillTreeMod] Toggle failed: " + e);
            }
        }

        private static void EnsureCache(object lpui, object xuiField)
        {
            if (_cacheTried) return;
            _cacheTried = true;

            _xui = xuiField;
            _wm = lpui.GetType().GetProperty("windowManager")?.GetValue(lpui, null)
                ?? lpui.GetType().GetField("windowManager")?.GetValue(lpui);

            if (_wm != null)
            {
                var wt = _wm.GetType();
                _miIsOpen = GetMethod(wt, "IsWindowOpen", new[] { typeof(string) });
                _miOpenIfNotOpen = GetMethod(wt, "OpenIfNotOpen", new[] { typeof(string), typeof(bool), typeof(bool), typeof(bool) });
                _miOpen = GetMethod(wt, "Open", new[] { typeof(string), typeof(bool), typeof(bool), typeof(bool) })
                       ?? GetMethod(wt, "Open", new[] { typeof(string) });
                _miClose = GetMethod(wt, "Close", new[] { typeof(string) });
                _miShortcutsAllowed = GetMethod(wt, "IsKeyShortcutsAllowed", Type.EmptyTypes);

                Debug.Log($"[SkillTreeMod] windowManager bound: IsOpen={_miIsOpen != null}, OpenIfNotOpen={_miOpenIfNotOpen != null}, Open={_miOpen != null}, Close={_miClose != null}");
                if (_miIsOpen != null && (_miOpenIfNotOpen != null || _miOpen != null) && _miClose != null) return;
            }

            if (_xui != null)
            {
                var xt = _xui.GetType();
                _miIsOpen = GetMethod(xt, "IsWindowOpen", new[] { typeof(string) });
                _miOpenIfNotOpen = null; // not on XUi
                _miOpen = GetMethod(xt, "OpenWindow", new[] { typeof(string) });     // expects the GROUP name
                _miClose = GetMethod(xt, "CloseWindow", new[] { typeof(string) });   // expects the GROUP name
                _miShortcutsAllowed = null;

                Debug.Log($"[SkillTreeMod] XUi bound: IsOpen={_miIsOpen != null}, OpenWindow={_miOpen != null}, CloseWindow={_miClose != null}");
            }
        }

        private static MethodInfo GetMethod(Type t, string name, Type[] sig)
        {
            if (t == null) return null;
            var mi = t.GetMethod(name,
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                binder: null, types: sig, modifiers: null);
            if (mi != null) return mi;

            foreach (var m in t.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                if (m.Name != name) continue;
                var p = m.GetParameters();
                if (p.Length != sig.Length) continue;
                bool match = true;
                for (int i = 0; i < p.Length; i++)
                    if (p[i].ParameterType != sig[i]) { match = false; break; }
                if (match) return m;
            }
            return null;
        }
    }
