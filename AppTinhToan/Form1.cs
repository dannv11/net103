using System.Text.RegularExpressions;

namespace AppTinhToan
{
    public partial class Form1 : Form
    {
        private List<string> _phepTinh = new List<string> {
        "Cộng",
        "Trừ",
        "Nhân",
        "Chia"
        };
        public Form1()
        {
            InitializeComponent();
            // gán datasource cho phép tính
            cbbPhepTinh.DataSource = _phepTinh;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            var index = cbbPhepTinh.SelectedIndex;
            string pheptinh="";
            
           if(validate(txtSox.Text) && validate(txtSoy.Text))
            {
                // chuyển string sang int
                int x = int.Parse(txtSox.Text);
                int y = int.Parse(txtSoy.Text);
                int ketqua = 0;
                // lấy phép tính dựa vào lựa chọn người dùng, thứ tự tuân theo thứ tự trong datasource
                switch (index)
                {
                    case 0:
                        pheptinh = "+";
                        ketqua = x + y;
                        break;
                    case 1:
                        pheptinh = "-";
                        ketqua = x - y;
                        break;
                    case 2:
                        pheptinh = "*";
                        ketqua = x * y;
                        break;
                    case 3:
                        pheptinh = "/";
                        ketqua = x / y;
                        break;

                }
                // Thêm kết quả tính vào history
                lsbHistory.Items.Add($"{x} {pheptinh} {y} = {ketqua}");

            }
            else
            {
                MessageBox.Show("Một trong 2 số bạn nhập vào không phải là số");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xoá hết item của list box
            lsbHistory.Items.Clear();
        }
        private bool validate(string text)
        {
            // validate có tối thiểu 1 chữ số
            return Regex.IsMatch(text,@"^[0-9]+$");
        }
    }
}