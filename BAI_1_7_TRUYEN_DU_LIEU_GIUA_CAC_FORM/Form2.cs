using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_7_TRUYEN_DU_LIEU_GIUA_CAC_FORM
{
    public partial class Form2 : Form
    {
        public Form1 parent;

        public string lableText
        {
            get => label1.Text;
            set =>
                label1.Text = value;
            
        }

        // dùng constructor để truyền dữ liệu
        public Form2(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        public Form2()
        {
            InitializeComponent();
           
        }

        public void setText(string text)
        {
            label1.Text = text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //label1.Text = parent.textBox1.Text;
        }
    }
}
