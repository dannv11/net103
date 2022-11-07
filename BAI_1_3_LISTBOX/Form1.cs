namespace BAI_1_3_LISTBOX
{
    public partial class Form1 : Form
    {
        List<Item> _items;
        public Form1()
        {
            InitializeComponent();
            addListItem();
        }

        private void addListItem()
        {
            _items = new List<Item>()
            {
                new Item(){Name="Iphone 14",Price=14000},
                new Item(){Name="Iphone 15",Price=15000},
                new Item(){Name="Iphone 16",Price=16000},
                new Item(){Name="Iphone 17",Price=17000},
                new Item(){Name="Iphone 18",Price=18000},
            };
            
            // set thuộc tính DisplayMember của listBox
            // bằng thuộc tính của item muốn hiển thị 
            // ra đại diện cho item
            lstItem.DisplayMember = "Name";
            //ValueMember: set thuộc tính làm giá trị của item khi được chọn
            lstItem.ValueMember = "Price";

            lstItem.DataSource = _items;
        }

        private void lstItem_SelectedIndexChanged(object sender, EventArgs e)
        {

           // MessageBox.Show("Index Selected: "+lstItem.SelectedIndex);
        }

        private void lstItem_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = lstItem.SelectedIndex;
            // SelectedItem: tương đương với item trong danh sách datasource mà được lựa chọn
            // selectedvalue: mặc định = selectedItem, nếu set valuemember của listbox(combobox ...)
            // thì sẽ mang giá trị của thuộc tính được set là value member của item
            MessageBox.Show($"Bạn đã chọn sản phẩm có giá {lstItem.SelectedValue}");
        }
    }
}