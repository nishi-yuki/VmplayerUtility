using System.IO;
using VmplayerUtilityCore;
using IWshRuntimeLibrary;

namespace WindowsMain
{
    class WinLauncherMaker : ILauncherMaker
    {
        const string ShortcutExtension = @".lnk";

        public void MakeLauncher(string command, string args, string launcherPath)
        {
            string shortcutFilePath = Path.ChangeExtension(
                launcherPath, ShortcutExtension);
            WshShell wshShell = new IWshRuntimeLibrary.WshShell();
            WshShortcut shortcut = (WshShortcut)wshShell
                .CreateShortcut(shortcutFilePath);
            shortcut.TargetPath = command;
            shortcut.Arguments = args;
            shortcut.Save();
            return;
        }
    }
}
