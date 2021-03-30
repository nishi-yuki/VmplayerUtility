using System.Collections.Generic;
using System.IO;

namespace VmplayerUtilityCore
{
    public class WmpUtil
    {
        private readonly ILauncherMaker launcherMaker;
        string vmplayerPath;
        string preferencesFilePath;
        private Preferences preferences;
        public readonly List<Vm> Vms;

        public WmpUtil(ILauncherMaker launcherMaker, string vmPlayerPath, string preferencesFilePath)
        {
            this.launcherMaker = launcherMaker;
            this.vmplayerPath = vmPlayerPath;
            this.preferencesFilePath = preferencesFilePath;
            this.preferences = new Preferences(File.ReadLines(preferencesFilePath));
            this.Vms = this.preferences.GenerateVms(launcherMaker, vmplayerPath);
        }
    }
}
