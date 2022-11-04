using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_0_GioiThieu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUser.Text;
            var pass = txtPass.Text;
            if(userName == "dannv" && pass == "12345")
            {
                // Khởi tạo form chính
                var mainForm = new Form1();
                // gọi method Hide() của form login để đóng chính nó
                this.Hide(); 
                // Hiển thị form chính
                mainForm.Show();
            }
            else
            {
                //lbThongBao.Text = "Bạn đã nhập sai tên đăng nhập hoặc mật khẩu";
                MessageBox.Show("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu!");
            }
        }
    }
}
