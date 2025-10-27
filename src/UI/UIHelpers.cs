using System;
using System.Linq;
using System.Reflection;

namespace SkillTreeMod.UI
{
    internal static class UIHelpers
    {
        // Try to get the local player's SkillPoints across versions.
        internal static int GetSkillPointsSafe()
        {
            try
            {
                var world = GameManager.Instance?.World;
                var ep = world?.GetPrimaryPlayer();          // EntityPlayerLocal
                if (ep == null) return 0;

                // Try common property/field names on the player: Progression / progression / PlayerProgression
                object progression = GetMember(ep, "Progression")
                                  ?? GetMember(ep, "progression")
                                  ?? GetMember(ep, "PlayerProgression");

                if (progression == null) return 0;

                // Now read SkillPoints off the progression object
                // (property or getter method)
                if (TryGetInt(progression, "SkillPoints", out var sp)) return sp;
                if (TryGetIntViaGetter(progression, "SkillPoints", out sp)) return sp;

                return 0;
            }
            catch { return 0; }
        }

        private static object GetMember(object instance, string name)
        {
            var t = instance.GetType();
            var flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

            // property
            var p = t.GetProperty(name, flags);
            if (p != null) return p.GetValue(instance, null);

            // field
            var f = t.GetField(name, flags);
            if (f != null) return f.GetValue(instance);

            return null;
        }

        private static bool TryGetInt(object obj, string propName, out int value)
        {
            value = 0;
            var t = obj.GetType();
            var flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

            var p = t.GetProperty(propName, flags);
            if (p != null)
            {
                var v = p.GetValue(obj, null);
                if (v is int i) { value = i; return true; }
            }
            return false;
        }

        private static bool TryGetIntViaGetter(object obj, string propName, out int value)
        {
            value = 0;
            var t = obj.GetType();
            var flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            var m = t.GetMethod("get_" + propName, flags);
            if (m != null)
            {
                var v = m.Invoke(obj, null);
                if (v is int i) { value = i; return true; }
            }
            return false;
        }
    }
}
