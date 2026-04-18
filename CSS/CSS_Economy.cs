using System.Collections.Generic;
using MCGalaxy;

public static class CSS_Economy {

    public static Dictionary<Player, int> money = new Dictionary<Player, int>();

    public static int Get(Player p) {
        if (!money.ContainsKey(p))
            money[p] = 800;
        return money[p];
    }

    public static void Add(Player p, int amt) {
        Get(p);
        money[p] += amt;
    }

    public static bool Spend(Player p, int amt) {
        if (Get(p) < amt) return false;

        money[p] -= amt;
        return true;
    }

    public static void RewardKill(Player p) {
        Add(p, 300);
    }

    public static void RewardRoundWin(Player p) {
        Add(p, 3000);
    }
}