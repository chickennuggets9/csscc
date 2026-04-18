using System.Collections.Generic;
using MCGalaxy;

public static class CSS_Teams {

    public static bool IsEnemy(Player a, Player b) {
        return CSS_Core.Get(a).team != CSS_Core.Get(b).team;
    }

    public static string Balance() {

        int t = 0, ct = 0;

        foreach (var kv in CSS_Core.players) {
            if (kv.Value.team == "T") t++;
            if (kv.Value.team == "CT") ct++;
        }

        return (t <= ct) ? "T" : "CT";
    }
}