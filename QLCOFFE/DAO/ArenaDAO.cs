using QLCOFFE.DTO;
using QLCOFFE.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCOFFE.DAO
{
    
  public class ArenaDAO
    {
        QuanLyKhuVucDBContext db = new QuanLyKhuVucDBContext();


        // hàm FindAll là hàm lấy ra một danh sách ở dạng list<T>
        public List<KHUVUC> FindAll()
        {
            return db.KHUVUCs.ToList();
        }
        public void delete(KHUVUC p)
        {
            KHUVUC ph = db.KHUVUCs.Find(p.MAKV);
            db.KHUVUCs.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm mới nhân viên
        public bool Insert(Arena arena)
        {
            try
            {
                KHUVUC p = new KHUVUC
                {
                   
                    MAKV = arena.MaKV,
                    TENKV = arena.TenKV,
                    TRANGTHAI = arena.TrangThai,


                };

                db.KHUVUCs.Add(p);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }
        public bool Update(Arena arena)
        {


            try
            { //&& u.TRANGTHAI == "1"//
                KHUVUC p = db.KHUVUCs.SingleOrDefault(u => u.MAKV == arena.MaKV);

                p.MAKV = arena.MaKV;
                p.TENKV = arena.TenKV;
                
                p.TRANGTHAI = arena.TrangThai;



                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public int DemSLTD()
        {
            return db.KHUVUCs.Count();
        }
        private static ArenaDAO instance;

        public static ArenaDAO Instance
        {
            get { if (instance == null) instance = new ArenaDAO(); return ArenaDAO.instance; }
            private set => instance = value;
        }
        public  ArenaDAO() { }


        public List<Arena> LoadArenaList()
        {
            List<Arena> List = new List<Arena>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.KhuVuc  ");
            foreach (DataRow item in data.Rows)
            {
                Arena arena = new Arena(item);
                List.Add(arena);
            }
            return List;
        }
        public bool Insert(string id, string name, string status)
        {
            string query = string.Format("INSERT dbo.Khuvuc ( MaKV, TenKV,TrangThai ) VALUES  ( N'{0}' , N'{1}' , {2} ) ", id, name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Update(string id, string name, string status)
        {
            string query = string.Format("UPDATE dbo.KhuVuc SET TenKV = N'{0}',  Trangthai = {1} WHERE MaKV = N'{2}' ", name, status, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Del(string id)
        {
            string query = string.Format("UPDATE dbo.KhuVuc SET   Trangthai = 0 WHERE MaKV = N'{0}' ", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public int dem()
        {
            int i = 0;
            List<Arena> List = new List<Arena>();
            i = DataProvider.Instance.ExecuteNonQuery("select COUNT(*) from dbo.KHUVUC ");

            return i;

        }
    }

    }

