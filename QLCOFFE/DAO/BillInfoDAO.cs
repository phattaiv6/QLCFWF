using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLCOFFE.DTO;
namespace QLCOFFE.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(string id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CTBH WHERE MaHDBH = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }


        public void InsertBillInfo(int maHDBH, int maHH, int soLuong, string trangThai, int giaBan)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_insertBillInfo @MaHDBH , @MaHH , @SoLuong , @GiaBan , @TrangThai", new object[] { maHDBH, maHH, soLuong, trangThai, giaBan });
        }

    }
}
