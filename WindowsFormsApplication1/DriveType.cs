using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1
{
    public partial class frmDriveType : Form
    {
        public frmDriveType()
        {
            InitializeComponent();
        }

        public static frmDriveType instance;
        public static frmDriveType Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo 
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmDriveType();
                }
                return instance;
            }
        }

        [DllImport("kernel32.dll")]//import api
        public static extern DriveType GetDriveType([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName);
        public enum DriveType : uint
        {
            /// <summary>Loại ổ đĩa máy không đoán nhận được.</summary>
            Unknown = 0,    //DRIVE_UNKNOWN
                             /// <summary>Không có ổ đĩa.</summary>
            Error = 1,        //DRIVE_NO_ROOT_DIR
                              /// <summary>Ổ kiểu flash</summary>
            Removable = 2,    //DRIVE_REMOVABLE
                              /// <summary>Ổ đĩa cứng cố định</summary>
            Fixed = 3,        //DRIVE_FIXED
                              /// <summary>Card mạng</summary>
            Remote = 4,        //DRIVE_REMOTE
                               /// <summary>Ổ CD ROm</summary>
            CDROM = 5,        //DRIVE_CDROM
                              /// <summary>Ổ đĩa RAM</summary>
            RAMDisk = 6        //DRIVE_RAMDISK
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            string namePath;
            namePath = textBox.Text.ToString() + ":\\";
            DriveType dt = GetDriveType(namePath);
            if (dt == DriveType.Unknown)
                MessageBox.Show("Tôi không biết thiết bị này","Thông báo");
            if (dt == DriveType.Error)
                MessageBox.Show("Không có thiết bị này", "Thông báo");
            if (dt == DriveType.Removable)
                MessageBox.Show("Ổ flash?", "Thông báo");
            if (dt == DriveType.Fixed)
                MessageBox.Show("Ổ đĩa cứng", "Thông báo");
            if (dt == DriveType.Remote)
                MessageBox.Show("CARD MẠNG", "Thông báo");
            if (dt == DriveType.CDROM)
                MessageBox.Show("CD-ROM", "Thông báo");
            if (dt == DriveType.RAMDisk)
                MessageBox.Show("RAM", "Thông báo");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
