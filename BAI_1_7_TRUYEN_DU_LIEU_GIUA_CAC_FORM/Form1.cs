namespace BAI_1_7_TRUYEN_DU_LIEU_GIUA_CAC_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Khởi tạo delegate để truyền dữ liệu
        public delegate void setText(string text);
        private void button1_Click(object sender, EventArgs e)
        {
            // sử dụng constructor để truyền dữ liệu
            //Form2 frm = new Form2(textBox1.Text);
            //frm.ShowDialog();

            // cách 2 dùng properties
            //Form2 frm = new Form2();
            //frm.parent = this;
            //frm.ShowDialog();

            //cach 3

            //Form2 frm = new Form2();
            //frm.lableText = textBox1.Text;
            //frm.ShowDialog();

            // Cách 4 dùng delegate
            // b1: tại form này Khai báo 1 delegate
            // b2: sang form cần truyền dữ liệu khai báo 1 cái method
            // để set dữ liệu
            // b3: Khởi tạo form con
            // b4: Khởi tạo delegate
            // b5: truyền dữ liệu qua delegate
            Form2 frm = new Form2();
            // Khởi tạo delegate
            setText st = new setText(frm.setText);
            // Gọi delegate để truyền dữ liệu
            st(textBox1.Text);
            frm.ShowDialog();
        }
    }
}