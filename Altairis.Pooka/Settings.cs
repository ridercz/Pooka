using Microsoft.Win32;

namespace Altairis.Pooka;

internal class Settings {
    private const string RegistryPath = "HKEY_CURRENT_USER\\SOFTWARE\\Altairis\\Pooka";
    public const string WatchFileName = "WatchFileName";
    public const string WatchFileInterval = "WatchFileInterval";
    public const int WatchFileIntervalDefault = 1000;
    public const string OnPlugAction = "OnPlugAction";
    public const string OnPlugActionDefault = "";
    public const string OnUnplugAction = "OnUnplugAction";
    public const string OnUnplugActionDefault = "lock";
    public const string Active = "Active";
    public const string ShutdownMethod = "ShutdownMethod";
    public const string ShutdownMethodDefault = "PowerOff_ForceIfHung";

    public static void Set(string name, string value) => Registry.SetValue(RegistryPath, name, value, RegistryValueKind.String);

    public static void Set(string name, bool value) => Registry.SetValue(RegistryPath, name, value.ToString(), RegistryValueKind.String);

    public static void Set(string name, int value) => Registry.SetValue(RegistryPath, name, value, RegistryValueKind.DWord);

    public static void Set(string name, long value) => Registry.SetValue(RegistryPath, name, value, RegistryValueKind.QWord);

    public static string Get(string name, string defaultValue) => Registry.GetValue(RegistryPath, name, defaultValue) as string ?? defaultValue;

    public static bool Get(string name, bool defaultValue) => bool.Parse(Get(name, defaultValue.ToString()));

    public static int Get(string name, int defaultValue) => (int)(Registry.GetValue(RegistryPath, name, defaultValue) ?? defaultValue);

    public static long Get(string name, long defaultValue) => (long)(Registry.GetValue(RegistryPath, name, defaultValue) ?? defaultValue);

}
