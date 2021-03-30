using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VmplayerUtilityCore
{
    class Preferences
    {
        private readonly Dictionary<string, string> Propertys;

        public Preferences(IEnumerable<string> file)
        {
            this.Propertys = Util.ReadConfig(file);
        }

        public List<Vm> GenerateVms(ILauncherMaker launcherMaker, string vmplayerPath)
        {
            List<Vm> vms =
                (from property in this.Propertys
                 let key = property.Key.Split('.')
                 where key.Length > 2 && key[1].Contains("mruVM")
                 group new KeyValuePair<string[], string>
                 (key, property.Value) by key[1] into rvm
                 orderby rvm.Key
                 select new Vm(launcherMaker, vmplayerPath, rvm)).ToList();
            return vms;
        }
    }
}
