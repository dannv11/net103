namespace BAI_1_4_GROUPBOX_PANEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addEvenRB();
        }

        private void addEvenRB()
        {
            // add sự kiện cho controls
            radioButton3.CheckedChanged += new EventHandler(radioButton3_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButton3_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(radioButton3_CheckedChanged);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // sender chính là control kích hoạt sự kiện
            // đang xử lý sự kiện của RadioButton => sender có kiểu là RadioButton
            var rb = sender as RadioButton;

            label1.Text = rb.Text;
        }
    }
}