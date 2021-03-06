using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLCOFFE.DTO;
using QLCOFFE.EF;

namespace QLCOFFE.DAO
{
    public class TableDAO
    {
        QuanLyBanDBContext db = new QuanLyBanDBContext();


        // hàm FindAll là hàm lấy ra một danh sách ở dạng list<T>
        public List<BAN> FindAll()
        {
            return db.BANs.ToList();
        }
        public void delete(BAN p)
        {
            BAN ph = db.BANs.Find(p.MABAN);
            db.BANs.Remove(ph);
            db.SaveChanges();
        }
        //hàm thêm mới nhân viên
        public bool Insert(Table table)
        {
            try
            {
                BAN p = new BAN
                {
                    MABAN = table.MaBan,
                    MAKV = table.MaKV,
                    TENBAN = table.TenBAn,
                    TRANGTHAI = table.TrangThai,
                   

                };

                db.BANs.Add(p);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }
        public bool Update(Table table)
        {


            try
            { 
                BAN p = db.BANs.SingleOrDefault(u => u.MABAN == table.MaBan);

                p.MABAN = table.MaBan;
                p.TENBAN = table.TenBAn;
                p.MAKV = table.MaKV;
                p.TRANGTHAI = table.TrangThai;

               

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
            return db.BANs.Count();
        }
        public List<Table> LoadTableListA(string a)
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Ban where MaKV = '" + a + "' ");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public TableDAO() { }
        private static TableDAO instance;
        public static int Width = 90;
        public static int Height = 90;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set => instance = value;
        }
       

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Ban");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }
    }
}
