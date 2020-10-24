using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Logging;
using FlaUI.UIA2;
using Newtonsoft.Json;
using PS4KeyboardAndMouseAdapter.Annotations;
using PS4RemotePlayInjection;
using PS4RemotePlayInterceptor;
using Serilog;
using SFML.System;
using SFML.Window;
using Application = FlaUI.Core.Application;
using Window = FlaUI.Core.AutomationElements.Window;

namespace PS4KeyboardAndMouseAdapter
{
    public enum VirtualKey
    {
        Left,
        Right,
        Up,
        Down,
        Triangle,
        Circle,
        Cross,
        Square,
        L1,
        L2,
        L3,
        R1,
        R2,
        R3,
        Options,
        TouchButton,
        DPadLeft,
        DPadRight,
        DPadUp,
        DPadDown,
    }

}
