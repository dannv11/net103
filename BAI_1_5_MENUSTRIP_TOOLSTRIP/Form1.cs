namespace BAI_1_5_MENUSTRIP_TOOLSTRIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Menu strip: hiển thị một thanh menu neo ở trên cùng của form
        // ContextMenuStrip: (Menu chuột phải) là menu hiển thị khi click chuột phải
        //vào control được set thuộc tính contextMenuStrip = menustrip đã tạo

        // để xử lý sự kiện click của các item thì có thể double click vào item tương ứng
        // hoặc thêm vào ở menu properties -> event (hình sét màu vàng)
        // Có thể thêm phím tắt cho menu item thông qua thuộc tính shortcut

        private void taiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            Application.Exit();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            // Method Hide: ẩn form hiện tại
            this.Hide();
            // show: Hiển thị form mới, không disable form hiện tại
            //ShowDialog: forcus vào form mới, không thể tác động lên các controls của
            // form hiện tại
            info.ShowDialog();
            // gọi show để hiển thị form hiện tại khi mà form info đã đóng
            this.Show();
        }
    }
}