using System.IO;
using VmplayerUtilityCore;
using File = System.IO.File;

namespace MonoTest
{
    class BatchLancherMaker : ILauncherMaker
    {
        const string batchFileExtension = @".bat";

        public void MakeLauncher(string command, string args, string launcherPath)
        {
            string filePath = Path.ChangeExtension(
                launcherPath, batchFileExtension);
            string cmdLine = string.Format("\"{0}\" {1}", command, args);
            using (StreamWriter s = File.CreateText(filePath))
            {
                s.WriteLine(cmdLine);
            }
        }
    }
}
