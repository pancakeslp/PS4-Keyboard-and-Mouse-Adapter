using System.Collections.Generic;
using SFML.Window;

namespace PS4KeyboardAndMouseAdapter
{

    public class UserSettings
    {


        public Dictionary<VirtualKey, Keyboard.Key> Mappings { get; set; }

        //////////////////////////////////////////////////////////////////////

        public int AnalogStickLowerRange { get; set; } = 40;
        public int AnalogStickUpperRange { get; set; } = 95;

        public double MouseDistanceLowerRange { get; set; } = 5;
        public double MouseDistanceUpperRange { get; set; } = VideoMode.DesktopMode.Width / 20f;
        public double MouseMaxDistance => VideoMode.DesktopMode.Width / 2f;

        public bool MouseControlsL3 { get; set; } = true;
        public bool MouseControlsR3 { get; set; } = false;


        public double MouseXAxisSensitivityModifier { get; set; } = 2;
        public double MouseYAxisSensitivityModifier { get; set; } = 1;

        
        //TODO do we still need this ?
        public double XYRatio { get; set; } = 0.6;
    }

}
