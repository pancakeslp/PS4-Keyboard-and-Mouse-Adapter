using Serilog;
using System;
using System.Windows;
using System.Windows.Controls;
namespace PS4KeyboardAndMouseAdapter.UI.Controls
{

    public partial class AnalogStickBindings : UserControl
    {
        public MainViewModel vm;
        public static readonly DependencyProperty StickContextProperty = DependencyProperty.Register(
                "StickContext", typeof(string), typeof(AnalogStickBindings), new PropertyMetadata(default(string)));

        public string StickContext
        {
            get => (string)GetValue(StickContextProperty);
            set => SetValue(StickContextProperty, value);
        }

        public VirtualKey GetVirtualKey(AnalogStickActions stickAction)
        {
            Log.Logger.Information("GetVirtualKey - ?" + stickAction);
            
            if (StickContext == "LEFT")
            {
                Log.Logger.Information("GetVirtualKey - LEFT" );
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
                Log.Logger.Information("GetVirtualKey - RIGHT" );

                if (stickAction == AnalogStickActions.Down)
                    return VirtualKey.RightStickDown;

                if (stickAction == AnalogStickActions.Left)
                    return VirtualKey.RightStickLeft;

                if (stickAction == AnalogStickActions.Right)
                    return VirtualKey.RightStickRight;

                if (stickAction == AnalogStickActions.Up)
                    return VirtualKey.RightStickUp;

                if (stickAction == AnalogStickActions.L3R3)
                    return VirtualKey.R3;
            }

            return VirtualKey.NULL;
        }
        public VirtualKey GetVirtualKey2(Button button)
        {
            Console.WriteLine("GetVirtualKey - ?" + button.Name);

            if (button.Name == null)
            {
                return VirtualKey.NULL;
            }

            if (StickContext == "LEFT")
            {
                Console.WriteLine("GetVirtualKey - LEFT");
                Log.Logger.Information("GetVirtualKey - LEFT");
                if (button.Name == "buttonDown")
                    return VirtualKey.LeftStickDown;

                if (button.Name == "buttonLeft")
                    return VirtualKey.LeftStickLeft;

                if (button.Name == "buttonRight")
                    return VirtualKey.LeftStickRight;

                if (button.Name == "buttonUp")
                    return VirtualKey.LeftStickUp;

                if (button.Name == "buttonL3R3")
                    return VirtualKey.L3;

            }
            else if (StickContext == "RIGHT")
            {
                Console.WriteLine("GetVirtualKey - RIGHT");
                Log.Logger.Information("GetVirtualKey - RIGHT");

                if (button.Name == "buttonDown")
                    return VirtualKey.RightStickDown;
                
                if (button.Name == "buttonLeft")
                    return VirtualKey.RightStickLeft;

                if (button.Name == "buttonRight")
                    return VirtualKey.RightStickRight;

                if (button.Name == "buttonUp")
                    return VirtualKey.RightStickUp;

                if (button.Name == "buttonL3R3")
                    return VirtualKey.R3;
            }

            return VirtualKey.NULL;
        }

        public void Handler_ButtonClicked(object sender, RoutedEventArgs e)
        {

            MainWindowView mwv = (MainWindowView)((Grid)((Grid)this.Parent).Parent).Parent;

            this.KeyDown += mwv.OnKeyDown;

            Button button =  (Button)sender;
            button.Tag = GetVirtualKey2(button);
            mwv.lastClickedButton = button;

            mwv.WaitingForKeyPress_Show();
        }
        
        //public UserSettings Settings { get; set; } = new UserSettings();
        
        public AnalogStickBindings()
        {
            InitializeComponent();

            vm = (MainViewModel)DataContext;



            /*
                        Settings = ((MainWindowView)((Grid)((Grid)this.Parent).Parent).Parent).vm.Settings;

                        Log.Logger.Information("parent tri  " + ((MainWindowView)((Grid)((Grid)this.Parent).Parent).Parent).vm.Settings.Mappings[VirtualKey.Triangle]);


                        Log.Logger.Information("Settings Triangle - '" + Settings.Mappings[VirtualKey.Triangle]);
                        */
        }

    }
}
