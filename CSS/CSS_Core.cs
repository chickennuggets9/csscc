using System;
using System.Collections.Generic;
using MCGalaxy;

public class CSS_Core : Plugin {

    public override string name => "CSS_Core";

    public class Data {
        public string team = "NONE";
        public int hp = 100;
        public int armor = 0;
        public int kills = 0;
        public int deaths = 0;
        public DateTime lastShot = DateTime.MinValue;
    }

    public static Dictionary<Player, Data> players = new Dictionary<Player, Data>();

    public static Data Get(Player p) {
        if (!players.ContainsKey(p))
            players[p] = new Data();
        return players[p];
    }

    public override void Load(bool startup) {
        Command.Register(new CmdJoinTeam());
    }

    class CmdJoinTeam : Command2 {
        public override string name => "jointeam";

        public override void Use(Player p, string msg, CommandData data) {

            var d = Get(p);

            if (msg == "auto") {
                d.team = CSS_Teams.Balance();
            } else {
                d.team = msg.ToUpper();
            }

            p.Message("&aJoined " + d.team);
        }
    }
}