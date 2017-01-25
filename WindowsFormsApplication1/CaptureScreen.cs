using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging; 

namespace WindowsFormsApplication1
{
    public partial class frmCaptureScreen : Form
    {
        public frmCaptureScreen()
        {
            InitializeComponent();
        }

        public static frmCaptureScreen instance;
        public static frmCaptureScreen Instance
        {
            get
            {
               
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmCaptureScreen();
                }
                return instance;
            }
        }

        ImageFormat img;  
        Bitmap bmp;   
        Graphics g;  

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                System.Threading.Thread.Sleep(1000);

                Size s = Screen.PrimaryScreen.Bounds.Size;
                
                bmp = new Bitmap(s.Width, s.Height);

                g = Graphics.FromImage(bmp);

                g.CopyFromScreen(0, 0, 0, 0, s);
                
                switch (saveFileDialog1.FilterIndex)
                {
                    case 0: img = ImageFormat.Bmp; break;
                    case 1: img = ImageFormat.Png; break;
                    case 2: img = ImageFormat.Jpeg; break;
                }
                bmp.Save(saveFileDialog1.FileName, img);
                this.Show(); //hiện lại form 
            }
        }
    }
}
