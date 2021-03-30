using System;
using System.IO;
using System.Windows.Forms;
using VmplayerUtilityCore;
using VmplayerUtilityGui;
using File = System.IO.File;

namespace MonoTest
{
    static class Program
    {
        public const string AppName = @"VM Player Util";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string vmwareName = @"VMware";
            const string vmwarePlayer = @"VMware Player";
            const string vmplayerName = @"vmplayer.exe";
            const string pereferencesFileName = @"preferences.ini";

            // VMware Player の実行ファイルを探す
            string[] vmplayerPathOptions = {
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), // Windows 64bit用
                vmwareName, vmwarePlayer, vmplayerName),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),    // Windows 32bit用
                vmwareName, vmwarePlayer, vmplayerName)
            };
           
            SelectVaildPath vp = new SelectVaildPath(vmplayerPathOptions);
            
            if (!vp.Found)
            {
                MessageBox.Show("VMware Player が見つかりません。", AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string vmplayerPath = vp.Path;

            // 設定ファイルを探す
            string preferencesFilePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                vmwareName, pereferencesFileName);
            if (!File.Exists(preferencesFilePath))
            {
                MessageBox.Show("VMware Player が見つかりません。", AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ILauncherMaker launcherMaker = new BatchLancherMaker();
            WmpUtil wmpUtil = new WmpUtil(launcherMaker, vmplayerPath, preferencesFilePath);

            // GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //MessageBox.Show((++i).ToString(), AppName, MessageBoxButtons.OK, MessageBoxIcon.Stop);//++++++++++++++++++++++++++
            Application.Run(new SelectVmForm(AppName, wmpUtil));
        }
    }
}
