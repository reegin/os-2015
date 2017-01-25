using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void chupManHinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaptureScreen.Instance.Show();
        }

       private void nhacMp3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusicPlayer.Instance.Show();
        }

        private void sleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFreeDiskSpace.Instance.Show();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriveType.Instance.Show();
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaskManager.Instance.Show();
        }
    }
}
