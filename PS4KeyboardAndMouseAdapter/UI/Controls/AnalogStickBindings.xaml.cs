using Serilog;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Button = System.Windows.Controls.Button;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace PS4KeyboardAndMouseAdapter.UI.Controls
{

    public partial class AnalogStickBindings : UserControl
    {

        private UserSettings Settings;

        private MainWindowView mwv;

        public static readonly DependencyProperty StickContextProperty = DependencyProperty.Register(
                "StickContext", typeof(string), typeof(AnalogStickBindings), new PropertyMetadata(default(string)));

        public string StickContext
        {
            get => (string)GetValue(StickContextProperty);
            set => SetValue(StickContextProperty, value);
        }

        ////////////////////////////////

        public AnalogStickBindings()
        {
            InitializeComponent();
            Settings = UserSettingsManager.ReadUserSettings();
        }

        private void fixButtons()
        {
            fixButton("buttonDown");
            fixButton("buttonL3R3");
            fixButton("buttonLeft");
            fixButton("buttonRight");
            fixButton("buttonUp");
        }

        private void fixButton(string buttonName)
        {
            Console.WriteLine("buttonName" + buttonName);
            Button button = FindName(buttonName) as Button;
            Console.WriteLine("button" + button);
            if (button != null)
            {
                VirtualKey virtualKey = GetVirtualKey2(button);

                button.Tag = virtualKey;
                Binding dataBinding = new Binding("Settings.Mappings["+virtualKey+"]");
                button.SetBinding(ContentProperty, dataBinding);
            }
        }

        public VirtualKey GetVirtualKey2(Button button)
        {
            Console.WriteLine("GetVirtualKey - ?" + button.Name);
            Console.WriteLine("StickContext - " + StickContext);

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

            // you should NEVER get this, if you do you fudged the code
            return VirtualKey.NULL;
        }

        private void Handler_ButtonClicked(object sender, RoutedEventArgs e)
        {
            mwv = (MainWindowView)((Grid)((Grid)this.Parent).Parent).Parent;

        

            Button button = (Button)sender;
            button.Tag = GetVirtualKey2(button);
            mwv.lastClickedButton = button;

            mwv.WaitingForKeyPress_Show();
        }

        private void Handler_ButtonLoaded(object sender, RoutedEventArgs e)
        {
            fixButtons();
        }

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("listener in analog");

            if (mwv != null)
            {
                mwv.OnKeyDown_Super(sender, e);
            }


            
            if (mwv != null)
                Settings = mwv.vm.Settings;

            Settings = UserSettingsManager.ReadUserSettings();
            fixButtons();
        }

   
    }
}
