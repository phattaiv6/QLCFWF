using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCOFFE.DAO;
using QLCOFFE.DTO;
namespace QLCOFFE.BUS
{
    class GoiMonBUS
    {
        BillDAO bill = new BillDAO();
        CategoryDAO cate = new CategoryDAO();
        FoodDAO food = new FoodDAO();
        UserDAO user = new UserDAO();
        MenuDAO menu = new MenuDAO();
        TableDAO table = new TableDAO();
        public int GetUncheckBillIDByTableID(int id)
        {
            return bill.GetUncheckBillIDByTableID(id);

        }

        public List<Food> GetFoodByCategoryID(int maLH)
        {
            return food.GetFoodByCategoryID(maLH);
        }

        public List<Category> GetListCategory()
        {
            return cate.GetListCategory();
        }
        public List<MenuFood> GetListMenuByTable(int id)
        {
            return menu.GetListMenuByTable(id);
        }

        public List<Table> LoadTableList()
        {
            return table.LoadTableList();
        }
    }
}
