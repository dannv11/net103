namespace BAI_1_6_LISTVIEW
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            loadListView();
        }
        private ImageList smallIcon;
        private ImageList largeIcon;
        private void loadListView()
        {
            // khởi tạo 2 danh sách icon
            smallIcon = new ImageList()
            {
                ImageSize = new Size(32,32)
            };
            largeIcon = new ImageList()
            {
                ImageSize = new Size(68, 68)
            };
            // add image vào image list
            // Application.StartupPath: đường dẫn đến thư mục khởi chạy của chương trình 
            smallIcon.Images.Add(new Bitmap
                ($"{Application.StartupPath}/Images/1.png"));
            smallIcon.Images.Add(new Bitmap
                ($"{Application.StartupPath}/Images/2.png"));
            smallIcon.Images.Add(new Bitmap
                ($"{Application.StartupPath}/Images/3.png"));
            largeIcon.Images.Add(new Bitmap
                ($"{Application.StartupPath}/Images/1.png"));
            largeIcon.Images.Add(new Bitmap
                ($"{Application.StartupPath}/Images/2.png"));
            largeIcon.Images.Add(new Bitmap
                ($"{Application.StartupPath}/Images/3.png"));
            // set Imagelist cho ListView
            lstTest.SmallImageList = smallIcon;
            lstTest.LargeImageList = largeIcon;

            // add cột cho listView
            lstTest.Columns.Add("Cột 1");
            lstTest.Columns.Add("Cột 2");
            lstTest.Columns.Add("Cột 3");

            //add Item vào listView
            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item 1";
            item1.ImageIndex = 0; // set icon là image có
                                  // thứ tự đầu tiên trong image list
            item1.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 1 1"
            });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 1 2"
            });
            // add item vào ListView
            lstTest.Items.Add(item1);

            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item 2";
            item2.ImageIndex = 1; // set icon là image có
                                  // thứ tự đầu tiên trong image list
            item2.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 2 1"
            });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 2 2"
            });
            // add item vào ListView
            lstTest.Items.Add(item2);

            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item 3";
            item3.ImageIndex = 2; // set icon là image có
                                  // thứ tự đầu tiên trong image list
            item3.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 3 1"
            });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 3 2"
            });
            // add item vào ListView
            lstTest.Items.Add(item3);


        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            // todo đổi hiển thị listview sang Small Icon
            lstTest.View = View.SmallIcon;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            // todo đổi hiển thị listview sang Detail Icon
            lstTest.View = View.Details;
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            // todo đổi hiển thị listview sang Large Icon
            lstTest.View = View.LargeIcon;
        }

        private void lstTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstTest.SelectedItems;
            if (item.Count > 0)
            {
                var text = item[0].Text;
                var sText1 = item[0].SubItems[1].Text;
                var sText2 = item[0].SubItems[2].Text;
                MessageBox.Show($"{text} {sText1} {sText2}");
            }
        }
    }
}