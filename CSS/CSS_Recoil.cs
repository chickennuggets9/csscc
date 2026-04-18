using System.Collections.Generic;

public static class CSS_Recoil {

    public class Pattern {
        public List<float> yaw = new List<float>();
        public List<float> pitch = new List<float>();
    }

    public static Dictionary<string, Pattern> P = new Dictionary<string, Pattern>() {

        { "ak47", new Pattern {
            yaw = {0,0.2f,-0.3f,0.4f,-0.5f},
            pitch={0.2f,0.25f,0.3f,0.35f,0.4f}
        }},

        { "m4a1", new Pattern {
            yaw = {0,0.1f,-0.2f,0.2f},
            pitch={0.15f,0.2f,0.25f}
        }}
    };
}