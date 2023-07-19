using System.Runtime.InteropServices;

namespace Altairis.Pooka;

internal class WindowsOperations {

    [DllImport("user32.dll")]
    public static extern bool LockWorkStation();

    public static void Shutdown(string method) {
        switch (method) {
            case "Shutdown":
                DoExitWin(EWX_SHUTDOWN);
                break;
            case "Shutdown_Force":
                DoExitWin(EWX_SHUTDOWN | EWX_FORCE);
                break;
            case "Shutdown_ForceIfHung":
                DoExitWin(EWX_SHUTDOWN | EWX_FORCEIFHUNG);
                break;
            case "PowerOff":
                DoExitWin(EWX_POWEROFF);
                break;
            case "PowerOff_Force":
                DoExitWin(EWX_POWEROFF | EWX_FORCE);
                break;
            case "PowerOff_ForceIfHung":
            default:
                DoExitWin(EWX_POWEROFF | EWX_FORCEIFHUNG);
                break;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    private struct TokPriv1Luid {
        public int Count;
        public long Luid;
        public int Attr;
    }

    [DllImport("kernel32.dll", ExactSpelling = true)]
    private static extern IntPtr GetCurrentProcess();

    [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
    private static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

    [DllImport("advapi32.dll", SetLastError = true)]
    private static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

    [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
    private static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

    [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
    internal static extern bool ExitWindowsEx(int flg, int rea);

    internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
    internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
    internal const int TOKEN_QUERY = 0x00000008;
    internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
    internal const int EWX_LOGOFF = 0x00000000;
    internal const int EWX_SHUTDOWN = 0x00000001;
    internal const int EWX_REBOOT = 0x00000002;
    internal const int EWX_FORCE = 0x00000004;
    internal const int EWX_POWEROFF = 0x00000008;
    internal const int EWX_FORCEIFHUNG = 0x00000010;

    private static void DoExitWin(int flg) {
        TokPriv1Luid tp;
        var hproc = GetCurrentProcess();
        var htok = IntPtr.Zero;
        _ = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
        tp.Count = 1;
        tp.Luid = 0;
        tp.Attr = SE_PRIVILEGE_ENABLED;
        _ = LookupPrivilegeValue(string.Empty, SE_SHUTDOWN_NAME, ref tp.Luid);
        _ = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
        _ = ExitWindowsEx(flg, 0);
    }

}
