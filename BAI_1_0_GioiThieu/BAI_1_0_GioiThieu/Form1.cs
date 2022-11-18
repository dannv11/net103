using BAI_1_0_GioiThieu.Properties;

namespace BAI_1_0_GioiThieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            var a = new Bitmap(resources.GetObject("icon1") as Image);
            a.SetResolution(40, 40);
            btnCong.Image = a;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            var so1 = int.Parse(txtSo1.Text);
            var so2 = int.Parse(txtSo2.Text);
            float kq=0;
            if(rbCong.Checked == true)
            {
                kq = so1 + so2;
            }else if(rbTru.Checked == true)
            {
                kq = so1 - so2;
            }
            else if (rbNhan.Checked == true)
            {
                kq = so1 * so2;
            }
            else if (rbChia.Checked == true)
            {
                kq = so1 / so2;
            }
            lbKetQua.Text = $"{kq}";
        }

        private void rbCong_CheckedChanged(object sender, EventArgs e)
        {
            var so1 = int.Parse(txtSo1.Text);
            var so2 = int.Parse(txtSo2.Text);
            float kq = 0;
            if (rbCong.Checked == true)
            {
                kq = so1 + so2;
                lbKetQua.Text = $"{kq}";
            }
        }

        private void rbTru_CheckedChanged(object sender, EventArgs e)
        {
            var so1 = int.Parse(txtSo1.Text);
            var so2 = int.Parse(txtSo2.Text);
            float kq = 0;
            if (rbTru.Checked == true)
            {
                kq = so1 - so2;
                lbKetQua.Text = $"{kq}";
            }
        }

        private void rbNhan_CheckedChanged(object sender, EventArgs e)
        {
            var so1 = int.Parse(txtSo1.Text);
            var so2 = int.Parse(txtSo2.Text);
            float kq = 0;
            if (rbNhan.Checked == true)
            {
                kq = so1 * so2;
                lbKetQua.Text = $"{kq}";
            }
        }

        private void rbChia_CheckedChanged(object sender, EventArgs e)
        {
            var so1 = int.Parse(txtSo1.Text);
            var so2 = int.Parse(txtSo2.Text);
            float kq = 0;
            if (rbChia.Checked == true)
            {
                try
                {
                    kq = so1 / so2;
                    lbKetQua.Text = $"{kq}";
                }catch(Exception ex)
                {
                    lbKetQua.Text = "Không thể chia cho 0";
                }
            }
        }
    }
}