using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLCOFFE.DTO;
namespace QLCOFFE.DAO
{
    class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        public FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int maLH)
        {
            List<Food> list = new List<Food>();

            string query = "select * from HangHoa where MaLH = " + maLH;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public List<Food> LoadList()
        {
            List<Food> foodList = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HangHoa");
            foreach (DataRow item in data.Rows)
            {
                Food f = new Food(item);
                foodList.Add(f);
            }
            return foodList;
        }
        public bool InsertFood(string name, int idC, int price, string status)
        {
            string query = string.Format("INSERT dbo.HangHoa ( TenHH, MaLH, GiaSP,TrangThai )VALUES  ( N'{0}', {1}, {2},{3})", name, idC, price, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int idC, int price, string status)
        {
            string query = string.Format("UPDATE dbo.HangHoa SET TenHH = N'{0}', MaLH = {1}, GiaSP = {2}, Trangthai={3} WHERE Mahh = {4}", name, idC, price, status, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //public bool DeleteFood(int idFood)
        //{
        //    BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);

        //    string query = string.Format("Delete Food where id = {0}", idFood);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}
    }
}
