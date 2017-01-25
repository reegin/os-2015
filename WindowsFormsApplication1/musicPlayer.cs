using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; //Để dùng lớp StringBuilder
using System.Threading.Tasks;
using System.Windows.Forms; //Để tạo form,dùng các toolbox
using System.Runtime.InteropServices; //Để dùng thư viện ImportDll


namespace WindowsFormsApplication1
{
    public partial class frmMusicPlayer : Form
    {
        public static frmMusicPlayer instance;
        public static frmMusicPlayer Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của frmMusic được khởi tạo 
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmMusicPlayer();
                }
                return instance;
            }
        }

        private string _command;
        private bool isOpen;

        [DllImport("winmm.dll")]                        // goi thu vien tuong tac chua anh/video. window multi-media

        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallBack);

        public frmMusicPlayer()
        {
            InitializeComponent();
        }

        private void frmMusicPlayer_Load(object sender, EventArgs e)
        {
            ;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();                                  // Khai báo đối tượng kiểu OpenFileDialog
            //Để mở hộp thoại các thư mục tìm danh sách bài hát
            ofd.InitialDirectory = Environment.SpecialFolder.MyMusic.ToString();        // Lấy đường dẫn file nhạc
            ofd.Filter = "mp3 files|*.mp3|All files (*.*)|*.*";
            ofd.Title = "Chọn danh sách bài hát";      
            ofd.FilterIndex = 1;                                                        // 
            if (ofd.ShowDialog() == DialogResult.OK)                                        
            {
                this.textBox1.Text = ofd.FileName.ToString();                          //Lấy đường dẫn file nhạc đặt vào TextBox
            }
        }
        // Hàm phát nhạc
        public void Play(bool loop)                                                     
        {
            if (isOpen)
            {
                _command = "play MediaFile";   //chuỗi chứa lệnh phát bài hát
                if (loop)
                    _command += "REPEAT";
                mciSendString(_command, null, 0, IntPtr.Zero);  // Gọi lệnh API truyền vào với đối số "play MediaFiles" "REPEAT"
            }
        }

        //Hàm mở file nhạc
        public void OpenPlayer(string sFileName)
        {
            _command = "open \"" + sFileName + "\" type mpegvideo alias MediaFile"; //chuỗi chứa lệnh mở bài hát
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = true;
        }

        // Hàm tắt nhạc
        public void ClosePlayer()
        {
            _command = "close MediaFile"; // lệnh đóng bài hát
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenPlayer(this.textBox1.Text);
                this.Play(false);
            }
            catch (Exception ex) //Bắt ngoại lệ phát sinh khi mở bài hát
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClosePlayer();
                // isopen = false
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
