using System.Security.Cryptography.X509Certificates;

namespace BAI_1_2_COLLECTIONS_CONTROLS
{
    public partial class Form1 : Form
    {
        private List<string> _quocGia;
        public Form1()
        {
            InitializeComponent();
            
            _quocGia = new List<string>()
            {
                "Mỹ",
                "Anh",
                "Pháp"
            };
            // gọi phương thức thêm item
            // cho combobox
            addItemCBB();
            // gọi phương thức thêm item cho
            // listbox
            addItemLstBox();
        }
        // Item: thuộc tính quản lý danh sách
        // item của combobox và listbox
        private void addItemLstBox()
        {
            // clear: xoá hết danh sách item hiện tại 
            // của listbox, tương tự với listbox
            lstMonHoc.Items.Clear();
            // phương thức item.add():
            // thêm item cho combobox và listbox
            lstMonHoc.Items.Add("Sinh");
            lstMonHoc.Items.Add("Sử");
            lstMonHoc.Items.Add("Địa");
        }

        private void addItemCBB()
        {
            // DataSource: set nguồn dữ liệu cho collection controls
            cbbCountry.DataSource = _quocGia;
            
        }
        // sự kiện selectedIndexchaged
        // kích hoạt khi thay đổi lựa chọn trên collection controls
        private void lstMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            //SelectedItem lấy ra item hiện đang được chọn
            //SelectedIndex: lấy ra vị trí của item đang được
            //chọn trong danh sách
            //var index = lstMonHoc.SelectedIndex;
            //var mesage = lstMonHoc.SelectedItem.ToString();
            var message = "";
            // SelectedItems: lấy ra tất cả item đang được chọn
            foreach (var x in lstMonHoc.SelectedItems)
            {
                message += x.ToString() + ", ";
            }
            MessageBox.Show(message);
        }

        private void cbbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbbCountry.SelectedIndex;

            MessageBox.Show(_quocGia[index]);

        }
    }
}