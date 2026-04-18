using System.Collections.Generic;
using MCGalaxy;

public static class CSS_Loadout {

    // what player is allowed to use
    static Dictionary<Player, HashSet<string>> owned = new Dictionary<Player, HashSet<string>>();

    public static void Init(Player p) {

        if (!owned.ContainsKey(p)) {
            owned[p] = new HashSet<string>();

            // default loadout
            owned[p].Add("knife");
            owned[p].Add("glock");
        }
    }

    public static bool Has(Player p, string weapon) {
        Init(p);
        return owned[p].Contains(weapon);
    }

    public static void Give(Player p, string weapon) {
        Init(p);
        owned[p].Add(weapon);
    }

    public static void ResetRound(Player p) {
        Init(p);
        owned[p].Clear();

        owned[p].Add("knife");
        owned[p].Add("glock");
    }

    /* ================= INVENTORY ENFORCER ================= */

    public static bool CanUse(Player p, string weapon) {
        return Has(p, weapon);
    }
}