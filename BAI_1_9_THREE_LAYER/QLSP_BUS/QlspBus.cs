using QLSP_DAL;
using System;
using System.Data;

namespace QLSP_BUS
{
    public class QlspBus
    {
        private QlspDAL _dal = new QlspDAL();

        public DataTable getDanhMuc()
        {
            return _dal.getDanhMuc();
        }
        public DataTable getCungCap()
        {
            return _dal.getCungCap();
        }
        public DataTable getSanPham()
        {
            return _dal.getSanPham();
        }
    }
}
