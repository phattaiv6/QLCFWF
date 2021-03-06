using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLCOFFE.DTO;
using QLCOFFE.EF;
using System.Data.SqlClient;
using System.Configuration;
using QLCOFFE.Views;
using DevExpress.XtraReports.UI;

namespace QLCOFFE.DAO
{
    public class BillDAO
    {

        QuanLyHoaDonDBContext db = new QuanLyHoaDonDBContext();
        public List<HOADONBANHANG> FindAll()
        {
            return db.HOADONBANHANGs.ToList();
        }
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        public BillDAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HoaDonBanHang WHERE MaBan = " + id + " AND TrangThai = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.MaHDBH;
            }

            return -1;
        }

        public void InsertBill(int maBan)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_insertBill1 @idTable", new object[] { maBan });
        }


        public DataTable GetBillListByDate(DateTime thoiGiandi, DateTime thoiGianend)
        {
            return DataProvider.Instance.ExecuteQuery("select TenBan,TenHH ,THOIGIAN, TongTien from dbo.HoaDonBanHang,dbo.Ban ,dbo.HANGHOA,dbo.CTBH  where dbo.HOADONBANHANG.MABAN=dbo.Ban.MaBan and  dbo.HOADONBANHANG.MAHDBH=dbo.CTBH.MAHDBH and dbo.CTBH.MAHH=dbo.HANGHOA.MAHH and THOIGIAN>=N%" + thoiGiandi + " and THOIGIAN<=N%" + thoiGianend + " ", new object[] { thoiGiandi, thoiGianend });
        }


        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(MaHDBH) FROM dbo.HoaDonBanHang");
            }
            catch
            {
                return 1;
            }
        }


        public void CheckOut(int id, int giamGia, int tongTien , string moTa)
        {
            string query = "UPDATE dbo.HoaDonBanHang SET  trangthai = 1, " + "GiamGia = " + giamGia + ", tongtien = " + tongTien + ", mota = N'" + moTa + "' WHERE MaHDBH = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void CreateReport()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GI4R9EJ;Initial Catalog=QUANLYCF1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from HOADONBANHANG where MONTH(THOIGIAN)  = Month(GETDATE()) and day(THOIGIAN)  = day(GETDATE()) and year(THOIGIAN)  = year(GETDATE())", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            Report1 report = new Report1();
            report.DataSouce = dt;
            report.ShowPreview();
        }

    }
}
