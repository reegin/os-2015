namespace WindowsFormsApplication1
{
    partial class frmFreeDiskSpace
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
            this.btnCDrive = new System.Windows.Forms.Button();
            this.btnDDrive = new System.Windows.Forms.Button();
            this.btnEDrive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstFreeDisk = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCDrive
            // 
            this.btnCDrive.Image = global::WindowsFormsApplication1.Properties.Resources.generic_drive_icon_72_72;
            this.btnCDrive.Location = new System.Drawing.Point(12, 26);
            this.btnCDrive.Name = "btnCDrive";
            this.btnCDrive.Size = new System.Drawing.Size(72, 72);
            this.btnCDrive.TabIndex = 0;
            this.btnCDrive.UseVisualStyleBackColor = true;
            this.btnCDrive.Click += new System.EventHandler(this.btnCDrive_Click);
            // 
            // btnDDrive
            // 
            this.btnDDrive.Image = global::WindowsFormsApplication1.Properties.Resources.generic_drive_icon_72_72;
            this.btnDDrive.Location = new System.Drawing.Point(121, 26);
            this.btnDDrive.Name = "btnDDrive";
            this.btnDDrive.Size = new System.Drawing.Size(72, 72);
            this.btnDDrive.TabIndex = 0;
            this.btnDDrive.UseVisualStyleBackColor = true;
            this.btnDDrive.Click += new System.EventHandler(this.btnDDrive_Click);
            // 
            // btnEDrive
            // 
            this.btnEDrive.Image = global::WindowsFormsApplication1.Properties.Resources.generic_drive_icon_72_72;
            this.btnEDrive.Location = new System.Drawing.Point(237, 26);
            this.btnEDrive.Name = "btnEDrive";
            this.btnEDrive.Size = new System.Drawing.Size(72, 72);
            this.btnEDrive.TabIndex = 0;
            this.btnEDrive.UseVisualStyleBackColor = true;
            this.btnEDrive.Click += new System.EventHandler(this.btnEDrive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "C:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "D:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "E:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstFreeDisk
            // 
            this.lstFreeDisk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstFreeDisk.FormattingEnabled = true;
            this.lstFreeDisk.Location = new System.Drawing.Point(0, 133);
            this.lstFreeDisk.Name = "lstFreeDisk";
            this.lstFreeDisk.Size = new System.Drawing.Size(346, 186);
            this.lstFreeDisk.TabIndex = 2;
            // 
            // frmFreeDiskSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 319);
            this.Controls.Add(this.lstFreeDisk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEDrive);
            this.Controls.Add(this.btnDDrive);
            this.Controls.Add(this.btnCDrive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFreeDiskSpace";
            this.Text = "free Disk Space";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCDrive;
        private System.Windows.Forms.Button btnDDrive;
        private System.Windows.Forms.Button btnEDrive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstFreeDisk;
    }
}