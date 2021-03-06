using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCOFFE.DAO;
using QLCOFFE.DTO;
namespace QLCOFFE.BUS
{
    class KhachHangBUS
    {
         UserDAO userDAO= new UserDAO();


        UserDAO user = new UserDAO();
        public bool Insert(User user)
        {
            return userDAO.Insert(user);
        }
        public bool Update(User user)
        {
            return userDAO.Update(user);
        }
        public bool Delete(User user)
        {
            return userDAO.Update(user);
        }
        public int DemSLKH()
        {
            return userDAO.DemSLKH();
        }
    }
}
