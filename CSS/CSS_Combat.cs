using System;
using MCGalaxy;

public static class CSS_Combat {

    public static void Tick(Player p) {
        CSS_LagComp.Update(p);
    }

    public static void Shoot(Player a, string w) {

        var d = CSS_Core.Get(a);

        foreach (Player b in PlayerInfo.Online.Items) {

            if (!CSS_Teams.IsEnemy(a,b)) continue;

            double x,y,z;
            CSS_LagComp.Get(b,out x,out y,out z);

            double sx=a.Pos.X/32.0;
            double sy=a.Pos.Y/32.0;
            double sz=a.Pos.Z/32.0;

            double dist = (x-sx)*(x-sx)+(y-sy)*(y-sy)+(z-sz)*(z-sz);

            if (dist < 2.0) {

                var bd = CSS_Core.Get(b);
                bd.hp -= 40;

                if (bd.hp <= 0) {
                    bd.deaths++;
                    d.kills++;
                    b.HandleDeath(Block.Air);
                }
            }
        }
    }
}