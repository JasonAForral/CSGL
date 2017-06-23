#region License
/*
    This is free and unencumbered software released into the public domain.

    Anyone is free to copy, modify, publish, use, compile, sell, or
    distribute this software, either in source code form or as a compiled
    binary, for any purpose, commercial or non-commercial, and by any
    means.

    In jurisdictions that recognize copyright laws, the author or authors
    of this software dedicate any and all copyright interest in the
    software to the public domain. We make this dedication for the benefit
    of the public at large and to the detriment of our heirs and
    successors. We intend this dedication to be an overt act of
    relinquishment in perpetuity of all present and future rights to this
    software under copyright law.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
    IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
    OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
    OTHER DEALINGS IN THE SOFTWARE.

    For more information, please refer to <http://unlicense.org>
*/
#endregion

using System;
using System.Runtime.InteropServices;

namespace CSGL
{
    public static class Glfw3
    {
        private const string _lib = "glfw3";

        #region Constants
        public const int GLFW_VERSION_MAJOR = 3;
        public const int GLFW_VERSION_MINOR = 2;
        public const int GLFW_VERSION_REVISION = 1;
        public const int GLFW_TRUE = 1;
        public const int GLFW_FALSE = 0;
        public const int GLFW_RELEASE = 0;
        public const int GLFW_PRESS = 1;
        public const int GLFW_REPEAT = 2;
        public const int GLFW_KEY_UNKNOWN = -1;
        public const int GLFW_KEY_SPACE = 32;
        public const int GLFW_KEY_APOSTROPHE = 39;
        public const int GLFW_KEY_COMMA = 44;
        public const int GLFW_KEY_MINUS = 45;
        public const int GLFW_KEY_PERIOD = 46;
        public const int GLFW_KEY_SLASH = 47;
        public const int GLFW_KEY_0 = 48;
        public const int GLFW_KEY_1 = 49;
        public const int GLFW_KEY_2 = 50;
        public const int GLFW_KEY_3 = 51;
        public const int GLFW_KEY_4 = 52;
        public const int GLFW_KEY_5 = 53;
        public const int GLFW_KEY_6 = 54;
        public const int GLFW_KEY_7 = 55;
        public const int GLFW_KEY_8 = 56;
        public const int GLFW_KEY_9 = 57;
        public const int GLFW_KEY_SEMICOLON = 59;
        public const int GLFW_KEY_EQUAL = 61;
        public const int GLFW_KEY_A = 65;
        public const int GLFW_KEY_B = 66;
        public const int GLFW_KEY_C = 67;
        public const int GLFW_KEY_D = 68;
        public const int GLFW_KEY_E = 69;
        public const int GLFW_KEY_F = 70;
        public const int GLFW_KEY_G = 71;
        public const int GLFW_KEY_H = 72;
        public const int GLFW_KEY_I = 73;
        public const int GLFW_KEY_J = 74;
        public const int GLFW_KEY_K = 75;
        public const int GLFW_KEY_L = 76;
        public const int GLFW_KEY_M = 77;
        public const int GLFW_KEY_N = 78;
        public const int GLFW_KEY_O = 79;
        public const int GLFW_KEY_P = 80;
        public const int GLFW_KEY_Q = 81;
        public const int GLFW_KEY_R = 82;
        public const int GLFW_KEY_S = 83;
        public const int GLFW_KEY_T = 84;
        public const int GLFW_KEY_U = 85;
        public const int GLFW_KEY_V = 86;
        public const int GLFW_KEY_W = 87;
        public const int GLFW_KEY_X = 88;
        public const int GLFW_KEY_Y = 89;
        public const int GLFW_KEY_Z = 90;
        public const int GLFW_KEY_LEFT_BRACKET = 91;
        public const int GLFW_KEY_BACKSLASH = 92;
        public const int GLFW_KEY_RIGHT_BRACKET = 93;
        public const int GLFW_KEY_GRAVE_ACCENT = 96;
        public const int GLFW_KEY_WORLD_1 = 161;
        public const int GLFW_KEY_WORLD_2 = 162;
        public const int GLFW_KEY_ESCAPE = 256;
        public const int GLFW_KEY_ENTER = 257;
        public const int GLFW_KEY_TAB = 258;
        public const int GLFW_KEY_BACKSPACE = 259;
        public const int GLFW_KEY_INSERT = 260;
        public const int GLFW_KEY_DELETE = 261;
        public const int GLFW_KEY_RIGHT = 262;
        public const int GLFW_KEY_LEFT = 263;
        public const int GLFW_KEY_DOWN = 264;
        public const int GLFW_KEY_UP = 265;
        public const int GLFW_KEY_PAGE_UP = 266;
        public const int GLFW_KEY_PAGE_DOWN = 267;
        public const int GLFW_KEY_HOME = 268;
        public const int GLFW_KEY_END = 269;
        public const int GLFW_KEY_CAPS_LOCK = 280;
        public const int GLFW_KEY_SCROLL_LOCK = 281;
        public const int GLFW_KEY_NUM_LOCK = 282;
        public const int GLFW_KEY_PRINT_SCREEN = 283;
        public const int GLFW_KEY_PAUSE = 284;
        public const int GLFW_KEY_F1 = 290;
        public const int GLFW_KEY_F2 = 291;
        public const int GLFW_KEY_F3 = 292;
        public const int GLFW_KEY_F4 = 293;
        public const int GLFW_KEY_F5 = 294;
        public const int GLFW_KEY_F6 = 295;
        public const int GLFW_KEY_F7 = 296;
        public const int GLFW_KEY_F8 = 297;
        public const int GLFW_KEY_F9 = 298;
        public const int GLFW_KEY_F10 = 299;
        public const int GLFW_KEY_F11 = 300;
        public const int GLFW_KEY_F12 = 301;
        public const int GLFW_KEY_F13 = 302;
        public const int GLFW_KEY_F14 = 303;
        public const int GLFW_KEY_F15 = 304;
        public const int GLFW_KEY_F16 = 305;
        public const int GLFW_KEY_F17 = 306;
        public const int GLFW_KEY_F18 = 307;
        public const int GLFW_KEY_F19 = 308;
        public const int GLFW_KEY_F20 = 309;
        public const int GLFW_KEY_F21 = 310;
        public const int GLFW_KEY_F22 = 311;
        public const int GLFW_KEY_F23 = 312;
        public const int GLFW_KEY_F24 = 313;
        public const int GLFW_KEY_F25 = 314;
        public const int GLFW_KEY_KP_0 = 320;
        public const int GLFW_KEY_KP_1 = 321;
        public const int GLFW_KEY_KP_2 = 322;
        public const int GLFW_KEY_KP_3 = 323;
        public const int GLFW_KEY_KP_4 = 324;
        public const int GLFW_KEY_KP_5 = 325;
        public const int GLFW_KEY_KP_6 = 326;
        public const int GLFW_KEY_KP_7 = 327;
        public const int GLFW_KEY_KP_8 = 328;
        public const int GLFW_KEY_KP_9 = 329;
        public const int GLFW_KEY_KP_DECIMAL = 330;
        public const int GLFW_KEY_KP_DIVIDE = 331;
        public const int GLFW_KEY_KP_MULTIPLY = 332;
        public const int GLFW_KEY_KP_SUBTRACT = 333;
        public const int GLFW_KEY_KP_ADD = 334;
        public const int GLFW_KEY_KP_ENTER = 335;
        public const int GLFW_KEY_KP_EQUAL = 336;
        public const int GLFW_KEY_LEFT_SHIFT = 340;
        public const int GLFW_KEY_LEFT_CONTROL = 341;
        public const int GLFW_KEY_LEFT_ALT = 342;
        public const int GLFW_KEY_LEFT_SUPER = 343;
        public const int GLFW_KEY_RIGHT_SHIFT = 344;
        public const int GLFW_KEY_RIGHT_CONTROL = 345;
        public const int GLFW_KEY_RIGHT_ALT = 346;
        public const int GLFW_KEY_RIGHT_SUPER = 347;
        public const int GLFW_KEY_MENU = 348;
        public const int GLFW_KEY_LAST = GLFW_KEY_MENU;
        public const int GLFW_MOD_SHIFT = 1;
        public const int GLFW_MOD_CONTROL = 2;
        public const int GLFW_MOD_ALT = 4;
        public const int GLFW_MOD_SUPER = 8;
        public const int GLFW_MOUSE_BUTTON_1 = 0;
        public const int GLFW_MOUSE_BUTTON_2 = 1;
        public const int GLFW_MOUSE_BUTTON_3 = 2;
        public const int GLFW_MOUSE_BUTTON_4 = 3;
        public const int GLFW_MOUSE_BUTTON_5 = 4;
        public const int GLFW_MOUSE_BUTTON_6 = 5;
        public const int GLFW_MOUSE_BUTTON_7 = 6;
        public const int GLFW_MOUSE_BUTTON_8 = 7;
        public const int GLFW_MOUSE_BUTTON_LAST = GLFW_MOUSE_BUTTON_8;
        public const int GLFW_MOUSE_BUTTON_LEFT = GLFW_MOUSE_BUTTON_1;
        public const int GLFW_MOUSE_BUTTON_RIGHT = GLFW_MOUSE_BUTTON_2;
        public const int GLFW_MOUSE_BUTTON_MIDDLE = GLFW_MOUSE_BUTTON_3;
        public const int GLFW_JOYSTICK_1 = 0;
        public const int GLFW_JOYSTICK_2 = 1;
        public const int GLFW_JOYSTICK_3 = 2;
        public const int GLFW_JOYSTICK_4 = 3;
        public const int GLFW_JOYSTICK_5 = 4;
        public const int GLFW_JOYSTICK_6 = 5;
        public const int GLFW_JOYSTICK_7 = 6;
        public const int GLFW_JOYSTICK_8 = 7;
        public const int GLFW_JOYSTICK_9 = 8;
        public const int GLFW_JOYSTICK_10 = 9;
        public const int GLFW_JOYSTICK_11 = 10;
        public const int GLFW_JOYSTICK_12 = 11;
        public const int GLFW_JOYSTICK_13 = 12;
        public const int GLFW_JOYSTICK_14 = 13;
        public const int GLFW_JOYSTICK_15 = 14;
        public const int GLFW_JOYSTICK_16 = 15;
        public const int GLFW_JOYSTICK_LAST = GLFW_JOYSTICK_16;
        public const int GLFW_NOT_INITIALIZED = 65537;
        public const int GLFW_NO_CURRENT_CONTEXT = 65538;
        public const int GLFW_INVALID_ENUM = 65539;
        public const int GLFW_INVALID_VALUE = 65540;
        public const int GLFW_OUT_OF_MEMORY = 65541;
        public const int GLFW_API_UNAVAILABLE = 65542;
        public const int GLFW_VERSION_UNAVAILABLE = 65543;
        public const int GLFW_PLATFORM_ERROR = 65544;
        public const int GLFW_FORMAT_UNAVAILABLE = 65545;
        public const int GLFW_NO_WINDOW_CONTEXT = 65546;
        public const int GLFW_FOCUSED = 131073;
        public const int GLFW_ICONIFIED = 131074;
        public const int GLFW_RESIZABLE = 131075;
        public const int GLFW_VISIBLE = 131076;
        public const int GLFW_DECORATED = 131077;
        public const int GLFW_AUTO_ICONIFY = 131078;
        public const int GLFW_FLOATING = 131079;
        public const int GLFW_MAXIMIZED = 131080;
        public const int GLFW_RED_BITS = 135169;
        public const int GLFW_GREEN_BITS = 135170;
        public const int GLFW_BLUE_BITS = 135171;
        public const int GLFW_ALPHA_BITS = 135172;
        public const int GLFW_DEPTH_BITS = 135173;
        public const int GLFW_STENCIL_BITS = 135174;
        public const int GLFW_ACCUM_RED_BITS = 135175;
        public const int GLFW_ACCUM_GREEN_BITS = 135176;
        public const int GLFW_ACCUM_BLUE_BITS = 135177;
        public const int GLFW_ACCUM_ALPHA_BITS = 135178;
        public const int GLFW_AUX_BUFFERS = 135179;
        public const int GLFW_STEREO = 135180;
        public const int GLFW_SAMPLES = 135181;
        public const int GLFW_SRGB_CAPABLE = 135182;
        public const int GLFW_REFRESH_RATE = 135183;
        public const int GLFW_DOUBLEBUFFER = 135184;
        public const int GLFW_CLIENT_API = 139265;
        public const int GLFW_CONTEXT_VERSION_MAJOR = 139266;
        public const int GLFW_CONTEXT_VERSION_MINOR = 139267;
        public const int GLFW_CONTEXT_REVISION = 139268;
        public const int GLFW_CONTEXT_ROBUSTNESS = 139269;
        public const int GLFW_OPENGL_FORWARD_COMPAT = 139270;
        public const int GLFW_OPENGL_DEBUG_CONTEXT = 139271;
        public const int GLFW_OPENGL_PROFILE = 139272;
        public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 139273;
        public const int GLFW_CONTEXT_NO_ERROR = 139274;
        public const int GLFW_CONTEXT_CREATION_API = 139275;
        public const int GLFW_NO_API = 0;
        public const int GLFW_OPENGL_API = 196609;
        public const int GLFW_OPENGL_ES_API = 196610;
        public const int GLFW_NO_ROBUSTNESS = 0;
        public const int GLFW_NO_RESET_NOTIFICATION = 200705;
        public const int GLFW_LOSE_CONTEXT_ON_RESET = 200706;
        public const int GLFW_OPENGL_ANY_PROFILE = 0;
        public const int GLFW_OPENGL_CORE_PROFILE = 204801;
        public const int GLFW_OPENGL_COMPAT_PROFILE = 204802;
        public const int GLFW_CURSOR = 208897;
        public const int GLFW_STICKY_KEYS = 208898;
        public const int GLFW_STICKY_MOUSE_BUTTONS = 208899;
        public const int GLFW_CURSOR_NORMAL = 212993;
        public const int GLFW_CURSOR_HIDDEN = 212994;
        public const int GLFW_CURSOR_DISABLED = 212995;
        public const int GLFW_ANY_RELEASE_BEHAVIOR = 0;
        public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 217089;
        public const int GLFW_RELEASE_BEHAVIOR_NONE = 217090;
        public const int GLFW_NATIVE_CONTEXT_API = 221185;
        public const int GLFW_EGL_CONTEXT_API = 221186;
        public const int GLFW_ARROW_CURSOR = 221185;
        public const int GLFW_IBEAM_CURSOR = 221186;
        public const int GLFW_CROSSHAIR_CURSOR = 221187;
        public const int GLFW_HAND_CURSOR = 221188;
        public const int GLFW_HRESIZE_CURSOR = 221189;
        public const int GLFW_VRESIZE_CURSOR = 221190;
        public const int GLFW_CONNECTED = 262145;
        public const int GLFW_DISCONNECTED = 262146;
        public const int GLFW_DONT_CARE = -1;
        #endregion

        #region Delegates
        public delegate void GLFWvkproc();
        public delegate void GLFWerrorfun( int code, [In] [MarshalAs( UnmanagedType.LPStr )] string description );
        public delegate void GLFWwindowposfun( IntPtr window, int x, int y );
        public delegate void GLFWwindowsizefun( IntPtr window, int w, int h );
        public delegate void GLFWwindowclosefun( IntPtr window );
        public delegate void GLFWwindowrefreshfun( IntPtr window );
        public delegate void GLFWwindowfocusfun( IntPtr window, int got );
        public delegate void GLFWwindowiconifyfun( IntPtr window, int iconify );
        public delegate void GLFWframebuffersizefun( IntPtr window, int w, int h );
        public delegate void GLFWmousebuttonfun( IntPtr window, int button, int action, int mods );
        public delegate void GLFWcursorposfun( IntPtr window, double x, double y );
        public delegate void GLFWcursorenterfun( IntPtr window, int entered );
        public delegate void GLFWscrollfun( IntPtr window, double xoffset, double yoffset );
        public delegate void GLFWkeyfun( IntPtr window, int key, int scancode, int action, int mods );
        public delegate void GLFWcharfun( IntPtr window, uint codepoint );
        public delegate void GLFWcharmodsfun( IntPtr window, uint codepoint, int mods );
        public delegate void GLFWdropfun( IntPtr window, int count, [Out] string[] paths );
        public delegate void GLFWmonitorfun( IntPtr window, int ev );
        public delegate void GLFWjoystickfun( int window, int ev );
        #endregion

        #region Structures
        [StructLayout( LayoutKind.Sequential )]
        public struct GLFWvidmode
        {
            public int width;
            public int height;
            public int redBits;
            public int greenBits;
            public int blueBits;
            public int refreshRate;
        }

        [StructLayout( LayoutKind.Sequential )]
        public struct GLFWgammaramp
        {
            public IntPtr red;
            public IntPtr green;
            public IntPtr blue;
            public uint size;
        }

        [StructLayout( LayoutKind.Sequential )]
        public struct GLFWimage
        {
            public int width;
            public int height;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pixels;
        }
        #endregion

        #region Methods
        [DllImport( _lib, EntryPoint = "glfwInit" )]
        public static extern int glfwInit();
        [DllImport( _lib, EntryPoint = "glfwTerminate" )]
        public static extern void glfwTerminate();
        [DllImport( _lib, EntryPoint = "glfwGetVersion" )]
        public static extern void glfwGetVersion( ref int major, ref int minor, ref int rev );
        [DllImport( _lib, EntryPoint = "glfwGetVersionString" )]
        public static extern IntPtr glfwGetVersionString();
        [DllImport( _lib, EntryPoint = "glfwSetErrorCallback" )]
        public static extern GLFWerrorfun glfwSetErrorCallback( GLFWerrorfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwGetMonitors" )]
        public static extern IntPtr glfwGetMonitors( ref int count );
        [DllImport( _lib, EntryPoint = "glfwGetPrimaryMonitor" )]
        public static extern IntPtr glfwGetPrimaryMonitor();
        [DllImport( _lib, EntryPoint = "glfwGetMonitorPos" )]
        public static extern void glfwGetMonitorPos( IntPtr monitor, ref int xpos, ref int ypos );
        [DllImport( _lib, EntryPoint = "glfwGetMonitorPhysicalSize" )]
        public static extern void glfwGetMonitorPhysicalSize( IntPtr monitor, ref int widthMM, ref int heightMM );
        [DllImport( _lib, EntryPoint = "glfwGetMonitorName" )]
        public static extern IntPtr glfwGetMonitorName( IntPtr monitor );
        [DllImport( _lib, EntryPoint = "glfwSetMonitorCallback" )]
        public static extern GLFWmonitorfun glfwSetMonitorCallback( GLFWmonitorfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwGetVideoModes" )]
        public static extern IntPtr glfwGetVideoModes( IntPtr monitor, ref int count );
        [DllImport( _lib, EntryPoint = "glfwGetVideoMode" )]
        public static extern IntPtr glfwGetVideoMode( IntPtr monitor );
        [DllImport( _lib, EntryPoint = "glfwSetGamma" )]
        public static extern void glfwSetGamma( IntPtr monitor, float gamma );
        [DllImport( _lib, EntryPoint = "glfwGetGammaRamp" )]
        public static extern IntPtr glfwGetGammaRamp( IntPtr monitor );
        [DllImport( _lib, EntryPoint = "glfwSetGammaRamp" )]
        public static extern void glfwSetGammaRamp( IntPtr monitor, ref GLFWgammaramp ramp );
        [DllImport( _lib, EntryPoint = "glfwDefaultWindowHints" )]
        public static extern void glfwDefaultWindowHints();
        [DllImport( _lib, EntryPoint = "glfwWindowHint" )]
        public static extern void glfwWindowHint( int hint, int value );
        [DllImport( _lib, EntryPoint = "glfwCreateWindow" )]
        public static extern IntPtr glfwCreateWindow( int width, int height, [In] [MarshalAs( UnmanagedType.LPStr )] string title, IntPtr monitor, IntPtr share );
        [DllImport( _lib, EntryPoint = "glfwDestroyWindow" )]
        public static extern void glfwDestroyWindow( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwWindowShouldClose" )]
        public static extern int glfwWindowShouldClose( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwSetWindowShouldClose" )]
        public static extern void glfwSetWindowShouldClose( IntPtr window, int value );
        [DllImport( _lib, EntryPoint = "glfwSetWindowTitle" )]
        public static extern void glfwSetWindowTitle( IntPtr window, [In] [MarshalAs( UnmanagedType.LPStr )] string title );
        [DllImport( _lib, EntryPoint = "glfwSetWindowIcon" )]
        public static extern void glfwSetWindowIcon( IntPtr window, int count, ref GLFWimage images );
        [DllImport( _lib, EntryPoint = "glfwGetWindowPos" )]
        public static extern void glfwGetWindowPos( IntPtr window, ref int xpos, ref int ypos );
        [DllImport( _lib, EntryPoint = "glfwSetWindowPos" )]
        public static extern void glfwSetWindowPos( IntPtr window, int xpos, int ypos );
        [DllImport( _lib, EntryPoint = "glfwGetWindowSize" )]
        public static extern void glfwGetWindowSize( IntPtr window, ref int width, ref int height );
        [DllImport( _lib, EntryPoint = "glfwSetWindowSizeLimits" )]
        public static extern void glfwSetWindowSizeLimits( IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight );
        [DllImport( _lib, EntryPoint = "glfwSetWindowAspectRatio" )]
        public static extern void glfwSetWindowAspectRatio( IntPtr window, int numer, int denom );
        [DllImport( _lib, EntryPoint = "glfwSetWindowSize" )]
        public static extern void glfwSetWindowSize( IntPtr window, int width, int height );
        [DllImport( _lib, EntryPoint = "glfwGetFramebufferSize" )]
        public static extern void glfwGetFramebufferSize( IntPtr window, ref int width, ref int height );
        [DllImport( _lib, EntryPoint = "glfwGetWindowFrameSize" )]
        public static extern void glfwGetWindowFrameSize( IntPtr window, ref int left, ref int top, ref int right, ref int bottom );
        [DllImport( _lib, EntryPoint = "glfwIconifyWindow" )]
        public static extern void glfwIconifyWindow( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwRestoreWindow" )]
        public static extern void glfwRestoreWindow( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwMaximizeWindow" )]
        public static extern void glfwMaximizeWindow( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwShowWindow" )]
        public static extern void glfwShowWindow( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwHideWindow" )]
        public static extern void glfwHideWindow( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwFocusWindow" )]
        public static extern void glfwFocusWindow( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwGetWindowMonitor" )]
        public static extern IntPtr glfwGetWindowMonitor( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwSetWindowMonitor" )]
        public static extern void glfwSetWindowMonitor( IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate );
        [DllImport( _lib, EntryPoint = "glfwGetWindowAttrib" )]
        public static extern int glfwGetWindowAttrib( IntPtr window, int attrib );
        [DllImport( _lib, EntryPoint = "glfwSetWindowUserPointer" )]
        public static extern void glfwSetWindowUserPointer( IntPtr window, IntPtr pointer );
        [DllImport( _lib, EntryPoint = "glfwGetWindowUserPointer" )]
        public static extern IntPtr glfwGetWindowUserPointer( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwSetWindowPosCallback" )]
        public static extern GLFWwindowposfun glfwSetWindowPosCallback( IntPtr window, GLFWwindowposfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetWindowSizeCallback" )]
        public static extern GLFWwindowsizefun glfwSetWindowSizeCallback( IntPtr window, GLFWwindowsizefun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetWindowCloseCallback" )]
        public static extern GLFWwindowclosefun glfwSetWindowCloseCallback( IntPtr window, GLFWwindowclosefun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetWindowRefreshCallback" )]
        public static extern GLFWwindowrefreshfun glfwSetWindowRefreshCallback( IntPtr window, GLFWwindowrefreshfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetWindowFocusCallback" )]
        public static extern GLFWwindowfocusfun glfwSetWindowFocusCallback( IntPtr window, GLFWwindowfocusfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetWindowIconifyCallback" )]
        public static extern GLFWwindowiconifyfun glfwSetWindowIconifyCallback( IntPtr window, GLFWwindowiconifyfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetFramebufferSizeCallback" )]
        public static extern GLFWframebuffersizefun glfwSetFramebufferSizeCallback( IntPtr window, GLFWframebuffersizefun cbfun );
        [DllImport( _lib, EntryPoint = "glfwPollEvents" )]
        public static extern void glfwPollEvents();
        [DllImport( _lib, EntryPoint = "glfwWaitEvents" )]
        public static extern void glfwWaitEvents();
        [DllImport( _lib, EntryPoint = "glfwWaitEventsTimeout" )]
        public static extern void glfwWaitEventsTimeout( double timeout );
        [DllImport( _lib, EntryPoint = "glfwPostEmptyEvent" )]
        public static extern void glfwPostEmptyEvent();
        [DllImport( _lib, EntryPoint = "glfwGetInputMode" )]
        public static extern int glfwGetInputMode( IntPtr window, int mode );
        [DllImport( _lib, EntryPoint = "glfwSetInputMode" )]
        public static extern void glfwSetInputMode( IntPtr window, int mode, int value );
        [DllImport( _lib, EntryPoint = "glfwGetKeyName" )]
        public static extern IntPtr glfwGetKeyName( int key, int scancode );
        [DllImport( _lib, EntryPoint = "glfwGetKey" )]
        public static extern int glfwGetKey( IntPtr window, int key );
        [DllImport( _lib, EntryPoint = "glfwGetMouseButton" )]
        public static extern int glfwGetMouseButton( IntPtr window, int button );
        [DllImport( _lib, EntryPoint = "glfwGetCursorPos" )]
        public static extern void glfwGetCursorPos( IntPtr window, ref double xpos, ref double ypos );
        [DllImport( _lib, EntryPoint = "glfwSetCursorPos" )]
        public static extern void glfwSetCursorPos( IntPtr window, double xpos, double ypos );
        [DllImport( _lib, EntryPoint = "glfwCreateCursor" )]
        public static extern IntPtr glfwCreateCursor( ref GLFWimage image, int xhot, int yhot );
        [DllImport( _lib, EntryPoint = "glfwCreateStandardCursor" )]
        public static extern IntPtr glfwCreateStandardCursor( int shape );
        [DllImport( _lib, EntryPoint = "glfwDestroyCursor" )]
        public static extern void glfwDestroyCursor( IntPtr cursor );
        [DllImport( _lib, EntryPoint = "glfwSetCursor" )]
        public static extern void glfwSetCursor( IntPtr window, IntPtr cursor );
        [DllImport( _lib, EntryPoint = "glfwSetKeyCallback" )]
        public static extern GLFWkeyfun glfwSetKeyCallback( IntPtr window, GLFWkeyfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetCharCallback" )]
        public static extern GLFWcharfun glfwSetCharCallback( IntPtr window, GLFWcharfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetCharModsCallback" )]
        public static extern GLFWcharmodsfun glfwSetCharModsCallback( IntPtr window, GLFWcharmodsfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetMouseButtonCallback" )]
        public static extern GLFWmousebuttonfun glfwSetMouseButtonCallback( IntPtr window, GLFWmousebuttonfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetCursorPosCallback" )]
        public static extern GLFWcursorposfun glfwSetCursorPosCallback( IntPtr window, GLFWcursorposfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetCursorEnterCallback" )]
        public static extern GLFWcursorenterfun glfwSetCursorEnterCallback( IntPtr window, GLFWcursorenterfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetScrollCallback" )]
        public static extern GLFWscrollfun glfwSetScrollCallback( IntPtr window, GLFWscrollfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetDropCallback" )]
        public static extern GLFWdropfun glfwSetDropCallback( IntPtr window, GLFWdropfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwJoystickPresent" )]
        public static extern int glfwJoystickPresent( int joy );
        [DllImport( _lib, EntryPoint = "glfwGetJoystickAxes" )]
        public static extern IntPtr glfwGetJoystickAxes( int joy, ref int count );
        [DllImport( _lib, EntryPoint = "glfwGetJoystickButtons" )]
        public static extern IntPtr glfwGetJoystickButtons( int joy, ref int count );
        [DllImport( _lib, EntryPoint = "glfwGetJoystickName" )]
        public static extern IntPtr glfwGetJoystickName( int joy );
        [DllImport( _lib, EntryPoint = "glfwSetJoystickCallback" )]
        public static extern GLFWjoystickfun glfwSetJoystickCallback( GLFWjoystickfun cbfun );
        [DllImport( _lib, EntryPoint = "glfwSetClipboardString" )]
        public static extern void glfwSetClipboardString( IntPtr window, [In] [MarshalAs( UnmanagedType.LPStr )] string @string );
        [DllImport( _lib, EntryPoint = "glfwGetClipboardString" )]
        public static extern IntPtr glfwGetClipboardString( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwGetTime" )]
        public static extern double glfwGetTime();
        [DllImport( _lib, EntryPoint = "glfwSetTime" )]
        public static extern void glfwSetTime( double time );
        [DllImport( _lib, EntryPoint = "glfwGetTimerValue" )]
        public static extern uint glfwGetTimerValue();
        [DllImport( _lib, EntryPoint = "glfwGetTimerFrequency" )]
        public static extern uint glfwGetTimerFrequency();
        [DllImport( _lib, EntryPoint = "glfwMakeContextCurrent" )]
        public static extern void glfwMakeContextCurrent( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwGetCurrentContext" )]
        public static extern IntPtr glfwGetCurrentContext();
        [DllImport( _lib, EntryPoint = "glfwSwapBuffers" )]
        public static extern void glfwSwapBuffers( IntPtr window );
        [DllImport( _lib, EntryPoint = "glfwSwapInterval" )]
        public static extern void glfwSwapInterval( int interval );
        [DllImport( _lib, EntryPoint = "glfwExtensionSupported" )]
        public static extern int glfwExtensionSupported( [In] [MarshalAs( UnmanagedType.LPStr )] string extension );
        [DllImport( _lib, EntryPoint = "glfwGetProcAddress" )]
        public static extern IntPtr glfwGetProcAddress( [In] [MarshalAs( UnmanagedType.LPStr )] string procname );
        [DllImport( _lib, EntryPoint = "glfwVulkanSupported" )]
        public static extern int glfwVulkanSupported();
        [DllImport( _lib, EntryPoint = "glfwGetRequiredInstanceExtensions" )]
        public static extern IntPtr glfwGetRequiredInstanceExtensions( ref uint count );
        #endregion
    }
}
