using System;
using MCGalaxy;

public class CSS_Match : Plugin {

    static int round = 1;
    static int max = 20;
    static DateTime start;

    public override string name => "CSS_Match";

    public override void Load(bool s) {
        Server.Heartbeat += Tick;
        start = DateTime.UtcNow;
    }

    static void Tick() {

        if ((DateTime.UtcNow - start).TotalMinutes > 10) {
            End("DRAW");
        }
    }

    public static void End(string reason) {

        Server.Message("&6Round ended: " + reason);

        round++;

        if (round > max) {
            CSS_Maps.NextMap();
            round = 1;
        }
    }
}