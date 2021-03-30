using System;
using System.Windows.Forms;
using VmplayerUtilityCore;

namespace VmplayerUtilityGui
{
    public partial class SelectVmForm : Form
    {
        private string AppName;
        private WmpUtil wmpUtil;
        private bool selected = false;
        private Vm selectedVm;

        public SelectVmForm(string AppName, WmpUtil wmpUtil)
        {
            this.AppName = AppName;
            this.wmpUtil = wmpUtil;
            InitializeComponent();

            vmList.Items.Clear();
            for (int i = 0; i < wmpUtil.Vms.Count; i++)
            {
                Vm vm = wmpUtil.Vms[i];
                addRow(vm.Name, vm.VmxPath, vm.Exists ? "" : "見つかりません");
            }
            makeShortcut.Enabled = false;
        }

        private void addRow(string name, string path, string info)
        {
            string[] vs = { name, path, info };
            vmList.Items.Add(new ListViewItem(vs));
        }

        private void makeShortcut_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                LauncherMakerForm launcherMakerForm = new LauncherMakerForm(AppName, selectedVm);
                launcherMakerForm.ShowDialog(this);
                launcherMakerForm.Dispose();
            }
        }

        private void vmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vmList.SelectedItems.Count > 0)
            {
                string msg = "選択中";
                int i = vmList.SelectedItems[0].Index;
                this.selectedVm = wmpUtil.Vms[i];
                status.Text = msg + ":" + this.selectedVm.Name;
                selected = true;
                makeShortcut.Enabled = true;
            }
            else
            {
                selected = false;
                status.Text = "未選択";
                makeShortcut.Enabled = false;
            }
        }
    }
}
