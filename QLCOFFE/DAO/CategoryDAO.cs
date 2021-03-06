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
    public class CategoryDAO
    {

        QuanLyLoaiThucDonDBContext db = new QuanLyLoaiThucDonDBContext();
        public List<LOAIHANGHOA> FindAll()
        {
            return db.LOAIHANGHOAs.ToList();
        }
        public void delete(LOAIHANGHOA catelogry)
        {
            LOAIHANGHOA ph = db.LOAIHANGHOAs.Find(catelogry.MALH);
            db.LOAIHANGHOAs.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm mới nhân viên
        public bool Insert(Category category)
        {
            try
            {
               LOAIHANGHOA p = new LOAIHANGHOA
                {
                    MALH = category.MaLH,
                    TENLH = category.TenLH,
                    MOTA = category.MoTa,
                    TRANGTHAI = category.TrangThai,


                };

                db.LOAIHANGHOAs.Add(p);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }
        public bool Update(Category category)
        {


            try
            { //&& u.TRANGTHAI == "1"//
                LOAIHANGHOA p = db.LOAIHANGHOAs.SingleOrDefault(u => u.MALH == category.MaLH);

                p.MALH = category.MaLH;
                p.TENLH = category.TenLH;
                p.MOTA = category.MoTa;
                p.TRANGTHAI = category.TrangThai;



                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        public CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from LoaiHangHoa";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        //---------------
        public Category GetCategoryByID(int maLH)
        {
            Category category = null;

            string query = "select * from dbo.LOAIHANGHOA where MaLH = " + maLH;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }



        public bool InsertCFood(string name, string des, string status)
        {
            string query = string.Format("INSERT dbo.LoaiHangHoa ( TenLH, MoTa,TrangThai )VALUES  ( N'{0}', N'{1}', {2})", name, des, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCFood(int idCFood, string name, string des, string status)
        {
            string query = string.Format("UPDATE dbo.LoaiHangHoa SET TenLH = N'{0}', MoTa = N'{1}',  Trangthai = {2} WHERE MaLH = {3} ", name, des, status, idCFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public int DemSLTD()
        {
            return db.LOAIHANGHOAs.Count();
        }
    }
}
