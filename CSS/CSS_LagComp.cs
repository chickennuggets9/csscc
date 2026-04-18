using System;
using System.Collections.Generic;
using MCGalaxy;

public static class CSS_LagComp {

    class Snap {
        public double x,y,z;
        public DateTime t;
    }

    static Dictionary<Player, Snap> last = new Dictionary<Player, Snap>();

    public static void Update(Player p) {
        last[p] = new Snap {
            x = p.Pos.X / 32.0,
            y = p.Pos.Y / 32.0,
            z = p.Pos.Z / 32.0,
            t = DateTime.UtcNow
        };
    }

    public static void Get(Player p, out double x, out double y, out double z) {

        if (last.ContainsKey(p) &&
            (DateTime.UtcNow - last[p].t).TotalMilliseconds < 250) {

            var s = last[p];
            x = s.x; y = s.y; z = s.z;
            return;
        }

        x = p.Pos.X / 32.0;
        y = p.Pos.Y / 32.0;
        z = p.Pos.Z / 32.0;
    }
}