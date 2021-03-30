
namespace VmplayerUtilityGui
{
    partial class SelectVmForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectVmForm));
            this.makeShortcut = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.vmList = new System.Windows.Forms.ListView();
            this.vmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vmPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // makeShortcut
            // 
            this.makeShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.makeShortcut.Location = new System.Drawing.Point(391, 273);
            this.makeShortcut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeShortcut.Name = "makeShortcut";
            this.makeShortcut.Size = new System.Drawing.Size(99, 22);
            this.makeShortcut.TabIndex = 2;
            this.makeShortcut.Text = "ショートカット作成";
            this.makeShortcut.UseVisualStyleBackColor = true;
            this.makeShortcut.Click += new System.EventHandler(this.makeShortcut_Click);
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(10, 273);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(41, 12);
            this.status.TabIndex = 3;
            this.status.Text = "未選択";
            // 
            // vmList
            // 
            this.vmList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vmList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vmList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vmName,
            this.vmPath,
            this.info});
            this.vmList.FullRowSelect = true;
            this.vmList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.vmList.HideSelection = false;
            this.vmList.Location = new System.Drawing.Point(10, 10);
            this.vmList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vmList.MultiSelect = false;
            this.vmList.Name = "vmList";
            this.vmList.Size = new System.Drawing.Size(480, 256);
            this.vmList.TabIndex = 4;
            this.vmList.UseCompatibleStateImageBehavior = false;
            this.vmList.View = System.Windows.Forms.View.Details;
            this.vmList.SelectedIndexChanged += new System.EventHandler(this.vmList_SelectedIndexChanged);
            // 
            // vmName
            // 
            this.vmName.Text = "名前";
            this.vmName.Width = 180;
            // 
            // vmPath
            // 
            this.vmPath.Text = "場所";
            this.vmPath.Width = 280;
            // 
            // info
            // 
            this.info.Text = "その他";
            this.info.Width = 280;
            // 
            // SelectVmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 302);
            this.Controls.Add(this.vmList);
            this.Controls.Add(this.status);
            this.Controls.Add(this.makeShortcut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectVmForm";
            this.Text = "Vmplayer Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button makeShortcut;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ListView vmList;
        private System.Windows.Forms.ColumnHeader vmName;
        private System.Windows.Forms.ColumnHeader vmPath;
        private System.Windows.Forms.ColumnHeader info;
    }
}
