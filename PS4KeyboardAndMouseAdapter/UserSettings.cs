using System.Collections.Generic;
using SFML.Window;

namespace PS4KeyboardAndMouseAdapter
{
 
        public class UserSettings
        {
            public Dictionary<VirtualKey, Keyboard.Key> Mappings { get; set; }

            public double MouseDistanceLowerRange { get; set; } = 5;
            public double MouseDistanceUpperRange { get; set; } = VideoMode.DesktopMode.Width / 20f;

            public int AnalogStickLowerRange { get; set; } = 40;
            public int AnalogStickUpperRange { get; set; } = 95;

            public double MouseMaxDistance => VideoMode.DesktopMode.Width / 2f;
            public double XYRatio { get; set; } = 0.6;
        }

}
