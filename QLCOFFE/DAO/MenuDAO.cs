using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLCOFFE.DTO;
using QLCOFFE.EF;
namespace QLCOFFE.DAO
{
    public class MenuDAO
    {
        QuanLyThucDonDBContext db = new QuanLyThucDonDBContext();
        public List<HANGHOA> FindAll()
        {
            return db.HANGHOAs.ToList();
        }
        public void delete(HANGHOA menu)
        {
            HANGHOA ph = db.HANGHOAs.Find(menu.MAHH);
            db.HANGHOAs.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm mới nhân viên
        public bool Insert(MenuFood menu)
        {
            try
            {
                HANGHOA p = new HANGHOA
                {
                    MAHH = menu.MaHH,
                    TENHH = menu.TenHH,
                    GIASP = menu.GiaBan,
                    TRANGTHAI = menu.TrangThai,
                    MALH = menu.MaLH,



                };

                db.HANGHOAs.Add(p);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }
        public bool Update(MenuFood menu)
        {


            try
            { //&& u.TRANGTHAI == "1"//
                HANGHOA p = db.HANGHOAs.SingleOrDefault(u => u.MAHH == menu.MaHH);

                p.MALH = menu.MaLH;
                p.TENHH = menu.TenHH;
                p.GIASP = menu.GiaBan;
                p.TRANGTHAI = menu.TrangThai;
                p.MAHH = menu.MaHH;


                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        public int DemSLTD()
        {
            return db.HANGHOAs.Count();
        }

        public MenuDAO()
        {

        }
        public List<MenuFood> GetListMenuByTable(int id)
        {
            List<MenuFood> listMenu = new List<MenuFood>();

            string query = "SELECT f.TenHH, bi.SoLuong, f.GiaSP, f.GiaSP*bi.SoLuong AS totalPrice FROM dbo.CTBH AS bi, dbo.HoaDonBanhang AS b, dbo.HangHoa AS f WHERE bi.MaHDBH = b.MAHDBH AND bi.MaHH = f.MaHH AND b.Trangthai=0 AND b.MaBan = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuFood menu = new MenuFood(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
