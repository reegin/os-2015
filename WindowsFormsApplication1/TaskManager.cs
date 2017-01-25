using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //thư viện tương tác với tiến trình hệ thống
//using System.Runtime.InteropServices; // Thư viện chứa các hàm API
//using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class frmTaskManager : Form
    {
        //[DllImport("user32.dll")]
        public static frmTaskManager instance;
        public static frmTaskManager Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của frmTaskManager được khởi tạo 
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmTaskManager();
                }
                return instance;
            }
        }

        Process[] process;              // tạo 1 mảng chứa đối tượng kiểu process

        //hàm lấy các Process đang chạy đưa vào listBox
        private void getProcess() 
        {
            process = Process.GetProcesses();                            // lay cac tien trinh hien co trong he thong
            // so tien trinh dang hien tren form khac tien trinh dang chay trong he thong thi xoa di va thiet lap lai
            if (int.Parse(lblNumbProcs.Text) != process.Length)                       
            {
                lstProcess.Items.Clear();
                for (int i = 0; i < process.Length; i++)
                    lstProcess.Items.Add(process[i].ProcessName);           // ten cua cac tien trinh dang chay
                lblNumbProcs.Text = process.Length.ToString();              // So tien trinh dang chay
            }
        }


        public frmTaskManager()
        {
            InitializeComponent();
        }

        //Hàm hủy process
        private void killProcess(int index)
        {
            process[index].Kill();
        }
        private void lblProcess_Click(object sender, EventArgs e)               
        {
            ;
        }

        private void frmTaskManager_Load(object sender, EventArgs e)
        {
            getProcess();
        }

        private void timer1_Tick(object sender, EventArgs e)        // Cap nhap tien trinh sau mỗi 1s
        {
            getProcess();
        }

        private void btnEndProcs_Click(object sender, EventArgs e)
        {
            killProcess(lstProcess.SelectedIndex);
        }
    }
}
