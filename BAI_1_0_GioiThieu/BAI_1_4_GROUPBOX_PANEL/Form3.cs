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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            addTabPage();
        }

        private void addTabPage()
        {
            //add tabpage vào tabcontrol
            TabPage page = new TabPage();
            page.Text = "My tab page";
            tabControl1.TabPages.Add(page);
        }
    }
}
