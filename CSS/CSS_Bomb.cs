using System;
using MCGalaxy;

public class CSS_Bomb : Plugin {

    static bool planted;
    static DateTime plantTime;

    public override string name => "CSS_Bomb";

    public override void Load(bool s) {
        Command.Register(new CmdPlant());
    }

    class CmdPlant : Command2 {
        public override string name => "plant";

        public override void Use(Player p,string m,CommandData d) {

            if (p.ClientHeldBlock.ToString().ToLower() != "bomb") return;

            planted = true;
            plantTime = DateTime.UtcNow;

            Server.Message("&cBomb planted!");
        }
    }

    public static void Tick() {

        if (!planted) return;

        if ((DateTime.UtcNow - plantTime).TotalSeconds > 35) {
            CSS_Match.End("T");
        }
    }
}