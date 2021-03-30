
namespace VmplayerUtilityGui
{
    partial class LauncherMakerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.header = new System.Windows.Forms.Label();
            this.optionGroup = new System.Windows.Forms.GroupBox();
            this.fullscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.unityCheckBox = new System.Windows.Forms.CheckBox();
            this.saveGroup = new System.Windows.Forms.GroupBox();
            this.desktopRadioButton = new System.Windows.Forms.RadioButton();
            this.startMenuRadioButton = new System.Windows.Forms.RadioButton();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.selectFolder = new System.Windows.Forms.Button();
            this.dirPathTextBox = new System.Windows.Forms.TextBox();
            this.makeButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainPanel.SuspendLayout();
            this.optionGroup.SuspendLayout();
            this.saveGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.header);
            this.mainPanel.Controls.Add(this.optionGroup);
            this.mainPanel.Controls.Add(this.saveGroup);
            this.mainPanel.Controls.Add(this.makeButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(3);
            this.mainPanel.Size = new System.Drawing.Size(222, 280);
            this.mainPanel.TabIndex = 0;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(6, 6);
            this.header.Margin = new System.Windows.Forms.Padding(3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(33, 12);
            this.header.TabIndex = 7;
            this.header.Text = "TEXT";
            // 
            // optionGroup
            // 
            this.optionGroup.Controls.Add(this.fullscreenCheckBox);
            this.optionGroup.Controls.Add(this.unityCheckBox);
            this.optionGroup.Location = new System.Drawing.Point(6, 23);
            this.optionGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionGroup.Name = "optionGroup";
            this.optionGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionGroup.Size = new System.Drawing.Size(206, 61);
            this.optionGroup.TabIndex = 15;
            this.optionGroup.TabStop = false;
            this.optionGroup.Text = "起動オプション";
            // 
            // fullscreenCheckBox
            // 
            this.fullscreenCheckBox.AutoSize = true;
            this.fullscreenCheckBox.Location = new System.Drawing.Point(6, 21);
            this.fullscreenCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullscreenCheckBox.Name = "fullscreenCheckBox";
            this.fullscreenCheckBox.Size = new System.Drawing.Size(85, 16);
            this.fullscreenCheckBox.TabIndex = 1;
            this.fullscreenCheckBox.Text = "フルスクリーン";
            this.fullscreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // unityCheckBox
            // 
            this.unityCheckBox.AutoSize = true;
            this.unityCheckBox.Location = new System.Drawing.Point(7, 41);
            this.unityCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unityCheckBox.Name = "unityCheckBox";
            this.unityCheckBox.Size = new System.Drawing.Size(97, 16);
            this.unityCheckBox.TabIndex = 2;
            this.unityCheckBox.Text = "ユニティーモード";
            this.unityCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveGroup
            // 
            this.saveGroup.Controls.Add(this.desktopRadioButton);
            this.saveGroup.Controls.Add(this.startMenuRadioButton);
            this.saveGroup.Controls.Add(this.otherRadioButton);
            this.saveGroup.Controls.Add(this.selectFolder);
            this.saveGroup.Controls.Add(this.dirPathTextBox);
            this.saveGroup.Location = new System.Drawing.Point(6, 88);
            this.saveGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveGroup.Name = "saveGroup";
            this.saveGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveGroup.Size = new System.Drawing.Size(206, 126);
            this.saveGroup.TabIndex = 14;
            this.saveGroup.TabStop = false;
            this.saveGroup.Text = "保存先フォルダ";
            // 
            // desktopRadioButton
            // 
            this.desktopRadioButton.AutoSize = true;
            this.desktopRadioButton.Location = new System.Drawing.Point(5, 18);
            this.desktopRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desktopRadioButton.Name = "desktopRadioButton";
            this.desktopRadioButton.Size = new System.Drawing.Size(74, 16);
            this.desktopRadioButton.TabIndex = 4;
            this.desktopRadioButton.TabStop = true;
            this.desktopRadioButton.Text = "デスクトップ";
            this.desktopRadioButton.UseVisualStyleBackColor = true;
            // 
            // startMenuRadioButton
            // 
            this.startMenuRadioButton.AutoSize = true;
            this.startMenuRadioButton.Location = new System.Drawing.Point(4, 38);
            this.startMenuRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startMenuRadioButton.Name = "startMenuRadioButton";
            this.startMenuRadioButton.Size = new System.Drawing.Size(93, 16);
            this.startMenuRadioButton.TabIndex = 5;
            this.startMenuRadioButton.TabStop = true;
            this.startMenuRadioButton.Text = "スタートメニュー";
            this.startMenuRadioButton.UseVisualStyleBackColor = true;
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(5, 58);
            this.otherRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(54, 16);
            this.otherRadioButton.TabIndex = 6;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "その他";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.CheckedChanged += new System.EventHandler(this.selectDirOption_CheckedChanged);
            // 
            // selectFolder
            // 
            this.selectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFolder.AutoSize = true;
            this.selectFolder.Location = new System.Drawing.Point(126, 101);
            this.selectFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(74, 22);
            this.selectFolder.TabIndex = 13;
            this.selectFolder.Text = "フォルダ選択";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // dirPathTextBox
            // 
            this.dirPathTextBox.Location = new System.Drawing.Point(4, 78);
            this.dirPathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dirPathTextBox.Name = "dirPathTextBox";
            this.dirPathTextBox.Size = new System.Drawing.Size(197, 19);
            this.dirPathTextBox.TabIndex = 12;
            // 
            // makeButton
            // 
            this.makeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.makeButton.Location = new System.Drawing.Point(148, 218);
            this.makeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(64, 18);
            this.makeButton.TabIndex = 0;
            this.makeButton.Text = "作成";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.CheckFileExists = false;
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Folder|.";
            // 
            // LauncherMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 280);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LauncherMakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shortcut Maker";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.optionGroup.ResumeLayout(false);
            this.optionGroup.PerformLayout();
            this.saveGroup.ResumeLayout(false);
            this.saveGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.CheckBox fullscreenCheckBox;
        private System.Windows.Forms.CheckBox unityCheckBox;
        private System.Windows.Forms.RadioButton desktopRadioButton;
        private System.Windows.Forms.RadioButton startMenuRadioButton;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.TextBox dirPathTextBox;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.GroupBox saveGroup;
        private System.Windows.Forms.GroupBox optionGroup;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
