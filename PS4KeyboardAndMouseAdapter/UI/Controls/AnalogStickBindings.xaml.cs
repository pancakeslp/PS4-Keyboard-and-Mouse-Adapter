using System.Windows;
using System.Windows.Controls;

namespace PS4KeyboardAndMouseAdapter.UI.Controls
{

    public partial class AnalogStickBindings : UserControl
    {

        public enum AnalogStickActions
        {
            Left,
            Right,
            Up,
            Down,

            //aka click the stick in
            L3R3
        }

        public static readonly DependencyProperty StickContextProperty = DependencyProperty.Register(
                "StickContext", typeof(string), typeof(AnalogStickBindings), new PropertyMetadata(default(string)));


        public string StickContext
        {
            get => (string)GetValue(StickContextProperty);
            set => SetValue(StickContextProperty, value);
        }

        public VirtualKey GetVirtualKey(AnalogStickActions stickAction) {
            if (StickContext == "Left") {
                if (stickAction == AnalogStickActions.Down) 
                    return VirtualKey.LeftStickDown;
                
                if (stickAction == AnalogStickActions.Left)
                    return VirtualKey.LeftStickLeft;

                if (stickAction == AnalogStickActions.Right)
                    return VirtualKey.LeftStickRight;

                if (stickAction == AnalogStickActions.Up)
                    return VirtualKey.LeftStickUp;

                if (stickAction == AnalogStickActions.L3R3)
                    return VirtualKey.L3;

            }
            //  StickContext == "Right"
            else
            {

                if (stickAction == AnalogStickActions.Down)
                    return VirtualKey.LeftStickDown;

                if (stickAction == AnalogStickActions.Left)
                    return VirtualKey.LeftStickLeft;

                if (stickAction == AnalogStickActions.Right)
                    return VirtualKey.LeftStickRight;

                if (stickAction == AnalogStickActions.Up)
                    return VirtualKey.LeftStickUp;
                
                if (stickAction == AnalogStickActions.L3R3)
                    return VirtualKey.L3;
            }

            return VirtualKey.NULL;
        }

        public AnalogStickBindings()
        {
            InitializeComponent();
        }

    }
}
