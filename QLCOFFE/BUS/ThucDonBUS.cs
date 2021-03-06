using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCOFFE.DAO;
using QLCOFFE.DTO;
namespace QLCOFFE.BUS
{
    class ThucDonBUS
    {
        MenuDAO menuDAO = new MenuDAO();
        MenuDAO menu = new MenuDAO();
        public bool Insert(MenuFood menu)
        {
            return menuDAO.Insert(menu);
        }
        public bool Update(MenuFood menu)
        {
            return menuDAO.Update(menu);
        }
        public bool Delete(MenuFood menu)
        {
            return menuDAO.Update(menu);
        }

        public int DemSLTD()
        {
            return menuDAO.DemSLTD();
        }
    }
}
