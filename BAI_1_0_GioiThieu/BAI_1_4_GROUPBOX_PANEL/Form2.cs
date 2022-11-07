using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_4_GROUPBOX_PANEL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int i = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            Button btn = new Button()
            {
                Text = i.ToString(),
                // Location: vị trí của control trên parent(control hoặc form)
                Location = new Point(rd.Next(pn1.Width), rd.Next(pn1.Height)),
                AutoSize = true,
                
            };
            btn.Click += Btn_Click;
            // add button vào panel
            pn1.Controls.Add(btn);
            // FlowLayoutPanel: tự sắp xếp các control trên nó
            fpn1.Controls.Add(btn);
            // tăng biến đếm i
            i++;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            var btn = sender as Button;
            MessageBox.Show(btn?.Text);
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            pn1.Enabled = !pn1.Enabled;
            fpn1.Enabled = !fpn1.Enabled;
        }
    }
}
