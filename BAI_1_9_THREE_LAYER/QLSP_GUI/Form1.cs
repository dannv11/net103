using QLSP_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSP_GUI
{
    public partial class Form1 : Form
    {
        /* Khái niệm:

Mô hình 3 lớp hay còn được gọi là mô hình Three Layer(3-Layer), mô hình này ra đời nhằm phân chia các thành phần trong hệ thống, các thành phần cùng chức năng sẽ được nhóm lại với nhau và phân chia công việc cho từng nhóm để dữ liệu không bị chồng chéo và chạy lộn xộn.
Mô hình này phát huy hiệu quả nhất khi bạn xây dựng một hệ thống lớn, việc quản lý code và xử lý dữ liệu lỗi dễ dàng hơn.
Ưu điểm:

Phân loại rõ ràng các lớp có các nhiệm vụ khác nhau. Từ đó ta có thể quản lý và maintain project tốt hơn.
Dễ dàng phân loại các hành động tại Business.
Dễ dàng phân loại các hàm truy xuất tại Database, phân loại hàm theo table,…
Ứng dụng được cho các project lớn ở bên ngoài.
…
Lưu ý khi xây dựng mô hình 3 lớp:

Cần một solution riêng cho project.
Cần 3 project khác nhau để làm nên 3 lớp, tên Project đặt như sau:
Lớp GUI: (VD: QuanLy_GUI)
Lớp Business: (VD: QuanLy_BUS)
Lớp Data Access: (VD: QuanLy_DAL)
Lớp DTO: (VD: QuanLy_DTO)

Mô hình 3-layer gồm có 3 phần chính:

Presentation Layer (GUI)

Lớp này có nhiệm vụ chính là giao tiếp với người dùng. Nó gồm các thành phần giao diện ( winform, webform, …) và thực hiện các công việc như nhập liệu, hiển thị dữ liệu, kiểm tra tính đúng đắn dữ liệu trước khi gọi lớp Business Logic Layer (BLL).
Business Logic Layer (BLL) Layer này phân ra 2 thành nhiệm vụ:

Đây là nơi đáp ứng các yêu cầu thao tác dữ liệu của GUI layer, xử lý chính nguồn dữ liệu từ Presentation Layer trước khi truyền xuống Data Access Layer và lưu xuống hệ quản trị CSDL.
Đây còn là nơi kiểm tra các ràng buộc, tính toàn vẹn và hợp lệ dữ liệu, thực hiện tính toán và xử lý các yêu cầu nghiệp vụ, trước khi trả kết quả về Presentation Layer.
Data Access Layer (DAL)

Lớp này có chức năng giao tiếp với hệ quản trị CSDL như thực hiện các công việc liên quan đến lưu trữ và truy vấn dữ liệu ( tìm kiếm, thêm, xóa, sửa,…).
*/
        // thêm vào để gọi tầng business
        private QlspBus _bus = new QlspBus();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // gọi dữ liệu cho 2 combobox
            // display member tên cột nhà cung cấp trong sql, tương tự với value mem là cột id
            cbbCungCap.DisplayMember = "Tendaydu";
            cbbCungCap.ValueMember = "CungcapID";
            // add datasource để lấy dữ liệu từ business
            cbbCungCap.DataSource = _bus.getCungCap();
            // tương tự cho danh mục
            cbbDanhMuc.DisplayMember = "TenDanhMuc";
            cbbDanhMuc.ValueMember = "DanhmucID";
            // add datasource để lấy dữ liệu từ business
            cbbDanhMuc.DataSource = _bus.getDanhMuc();



        }
    }
}
