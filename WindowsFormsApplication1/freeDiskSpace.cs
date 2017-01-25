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
    public partial class frmFreeDiskSpace : Form
    {
        public frmFreeDiskSpace()
        {
            InitializeComponent();
        }

        public static frmFreeDiskSpace instance;
        public static frmFreeDiskSpace Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo 
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmFreeDiskSpace();
                }
                return instance;
            }
        }

        [DllImport("kernel32.dll", SetLastError=true, CharSet=CharSet.Auto)]

        static extern bool GetDiskFreeSpace(string lpRootPathName,
        out uint lpSectorsPerCluster,
        out uint lpBytesPerSector,
        out uint lpNumberOfFreeClusters,
        out uint lpTotalNumberOfClusters);

        uint SectorsPerCluster;
        uint BytesPerSector;
        uint NumberOfFreeClusters;
        uint TotalNumberOfClusters;
        //string rootPath;

        private void GlobalGetDiskFree(string namePath)
        {
            //Lấy thông tin về ổ đĩa trả về từng biến
            GetDiskFreeSpace(namePath, out SectorsPerCluster, out BytesPerSector,
              out NumberOfFreeClusters, out TotalNumberOfClusters);
            //Mỗi cluster có bao nhiêu sector
            lstFreeDisk.Items.Add("Sectors Per Cluster: " + SectorsPerCluster.ToString());
            //Mỗi sector có bao nhiêu byte
            lstFreeDisk.Items.Add("Bytes Per Sector: " + BytesPerSector.ToString());
            //Số cluster còn trống
            lstFreeDisk.Items.Add("Number Of Free Clusters: " + NumberOfFreeClusters.ToString());
            //Tổng số cluster
            lstFreeDisk.Items.Add("Total Number Of Clusters: " + TotalNumberOfClusters.ToString());

            long Bytes = (long)NumberOfFreeClusters * SectorsPerCluster * BytesPerSector;
            decimal KiloBytes = (decimal)Bytes / 1024;
            decimal MegaBytes = (decimal)KiloBytes / 1024;
            decimal GigaBytes = (decimal)MegaBytes / 1024;

            lstFreeDisk.Items.Add("Total Free Space in giga bytes: " + GigaBytes);
        }
        
        private void btnCDrive_Click(object sender, EventArgs e)
        {
            lstFreeDisk.Items.Clear();
            GlobalGetDiskFree("C:\\");
        }

        private void btnDDrive_Click(object sender, EventArgs e)
        {
            lstFreeDisk.Items.Clear();
            GlobalGetDiskFree("D:\\");
        }

        private void btnEDrive_Click(object sender, EventArgs e)
        {
            lstFreeDisk.Items.Clear();
            GlobalGetDiskFree("E:\\");
        }
    }
}


