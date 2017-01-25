namespace WindowsFormsApplication1
{
    partial class frmTaskManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskManager));
            this.btnEndProcs = new System.Windows.Forms.Button();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblNumbProcs = new System.Windows.Forms.Label();
            this.lstProcess = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnEndProcs
            // 
            this.btnEndProcs.Location = new System.Drawing.Point(12, 22);
            this.btnEndProcs.Name = "btnEndProcs";
            this.btnEndProcs.Size = new System.Drawing.Size(75, 23);
            this.btnEndProcs.TabIndex = 0;
            this.btnEndProcs.Text = "End Process";
            this.btnEndProcs.UseVisualStyleBackColor = true;
            this.btnEndProcs.Click += new System.EventHandler(this.btnEndProcs_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(128, 27);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(51, 13);
            this.lblProcess.TabIndex = 1;
            this.lblProcess.Text = "Process: ";
            this.lblProcess.Click += new System.EventHandler(this.lblProcess_Click);
            // 
            // lblNumbProcs
            // 
            this.lblNumbProcs.AutoSize = true;
            this.lblNumbProcs.Location = new System.Drawing.Point(175, 27);
            this.lblNumbProcs.Name = "lblNumbProcs";
            this.lblNumbProcs.Size = new System.Drawing.Size(13, 13);
            this.lblNumbProcs.TabIndex = 2;
            this.lblNumbProcs.Text = "0";
            // 
            // lstProcess
            // 
            this.lstProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstProcess.FormattingEnabled = true;
            this.lstProcess.Location = new System.Drawing.Point(0, 58);
            this.lstProcess.Name = "lstProcess";
            this.lstProcess.Size = new System.Drawing.Size(391, 277);
            this.lstProcess.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 335);
            this.Controls.Add(this.lstProcess);
            this.Controls.Add(this.lblNumbProcs);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.btnEndProcs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaskManager";
            this.Text = "Task Manager ";
            this.Load += new System.EventHandler(this.frmTaskManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndProcs;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblNumbProcs;
        private System.Windows.Forms.ListBox lstProcess;
        private System.Windows.Forms.Timer timer1;
    }
}