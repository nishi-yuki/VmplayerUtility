using System.Collections.Generic;
using System.IO;

namespace VmplayerUtilityCore
{
    public class Vm
    {
        private readonly ILauncherMaker launcherMaker;
        private readonly string vmplayerPath;
        public readonly string Index;
        public readonly string VmxPath;
        public readonly string Name;
        public readonly bool Exists;

        public Vm(ILauncherMaker launcherMaker, string vmpPath,
            string index, string vmxPath, string name)
        {
            this.launcherMaker = launcherMaker;
            this.vmplayerPath = vmpPath;
            this.Index = index;
            this.VmxPath = vmxPath;
            this.Name = name;
            this.Exists = File.Exists(this.VmxPath);
        }

        public Vm(ILauncherMaker launcherMaker, string vmpPath,
            IEnumerable<KeyValuePair<string[], string>> propertys)
        {
            this.launcherMaker = launcherMaker;
            this.vmplayerPath = vmpPath;

            foreach (KeyValuePair<string[], string> property in propertys)
            {
                switch (property.Key[2])
                {
                    case "index":
                        this.Index = property.Value;
                        break;
                    case "filename":
                        this.VmxPath = property.Value;
                        break;
                    case "displayName":
                        this.Name = property.Value;
                        break;
                }
            }
            this.Exists = File.Exists(this.VmxPath);
        }

        /// <summary>
        /// ランチャーを作成する。
        /// </summary>
        /// <param name="fullscreenOption">フルスクリーンで起動するオプション</param>
        /// <param name="unityOption">ユニティーモードで起動するオプション</param>
        /// <param name="dir">作成先ディレクトリ</param>
        public void MakeLauncher(
            bool fullscreenOption, bool unityOption, string dir)
        {
            string launcherPath = Path.Combine(dir, this.Name);
            string args = this.GenerateArgs(fullscreenOption, unityOption);
            launcherMaker.MakeLauncher(this.vmplayerPath, args, launcherPath);
        }

        private string GenerateArgs(bool fullscreenOption, bool unityOption)
        {
            const string space = " ";
            const string quotation = "\"";
            List<string> args = new List<string>();
            if (fullscreenOption)
            {
                args.Add(" -X");
            }
            if (unityOption)
            {
                args.Add(" --unity");
            }
            args.Add(quotation + this.VmxPath + quotation);
            string argsString = string.Join(space, args);
            return argsString;
        }
    }
}
