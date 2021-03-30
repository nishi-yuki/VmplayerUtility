using System;
using System.IO;
using System.Windows.Forms;
using VmplayerUtilityCore;

namespace VmplayerUtilityGui
{
    public partial class LauncherMakerForm : Form
    {
        private string AppName;
        private string desktopDir =
            Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private string myStartMenuDir;
        private string userDir =
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        private Vm targetVm;

        public LauncherMakerForm(string AppName, Vm target)
        {
            InitializeComponent();
            this.AppName = AppName;
            this.myStartMenuDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.StartMenu),
                AppName);
            this.targetVm = target;
            dirPathTextBox.Enabled = false;
            selectFolder.Enabled = false;
            desktopRadioButton.Checked = true; // デフォルトの作成先を指定
            header.Text = target.Name + "のショートカットを作成します。";
            dirPathTextBox.Text = userDir;
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            bool fullscreen = fullscreenCheckBox.Checked;
            bool unity = unityCheckBox.Checked;
            string dirPath;
            if (desktopRadioButton.Checked)
            {
                dirPath = desktopDir;
            }
            else if (startMenuRadioButton.Checked)
            {
                if (!Directory.Exists(myStartMenuDir))
                {
                    Directory.CreateDirectory(myStartMenuDir);
                }
                dirPath = myStartMenuDir;
            }
            else // Other
            {
                dirPath = dirPathTextBox.Text;
            }

            try
            {
                this.targetVm.MakeLauncher(fullscreen, unity, dirPath);
                this.Dispose();
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("作成先ディレクトリが見つかりません。",
                    AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("不明なエラー。",
                    AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectDirOption_CheckedChanged(object sender, EventArgs e)
        {
            if (otherRadioButton.Checked)
            {
                dirPathTextBox.Enabled = true;
                selectFolder.Enabled = true;
            }
            else
            {
                dirPathTextBox.Enabled = false;
                selectFolder.Enabled = false;
            }
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = this.targetVm.Name;
            DialogResult result = openFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                dirPathTextBox.Text = Path.GetDirectoryName(openFileDialog.FileName);
            }
        }
    }
}
