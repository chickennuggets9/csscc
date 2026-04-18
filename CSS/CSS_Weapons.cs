using System.Collections.Generic;

public static class CSS_Weapons {

    public class Weapon {
        public int dmg;
        public int delay;
        public float spread;
        public bool auto;
        public int ammo;
        public int pen;
        public bool knife;
    }

    public static Dictionary<string, Weapon> W = new Dictionary<string, Weapon>() {

        { "knife", new Weapon{ dmg=40, delay=500, knife=true }},

        { "glock", new Weapon{ dmg=20, delay=200, ammo=20 }},
        { "usp", new Weapon{ dmg=25, delay=250, ammo=12 }},
        { "deagle", new Weapon{ dmg=50, delay=400, ammo=7 }},

        { "mp5", new Weapon{ dmg=22, delay=100, auto=true, ammo=30 }},
        { "p90", new Weapon{ dmg=21, delay=70, auto=true, ammo=50 }},

        { "ak47", new Weapon{ dmg=36, delay=100, auto=true, pen=2 }},
        { "m4a1", new Weapon{ dmg=33, delay=90, auto=true, pen=2 }},

        { "awp", new Weapon{ dmg=115, delay=1500, pen=3 }}
    };
}