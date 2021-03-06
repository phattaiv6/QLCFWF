using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCOFFE.DAO;
using QLCOFFE.DTO;
namespace QLCOFFE.BUS
{
    class LoaiHangHoaBUS
    {
        CategoryDAO categoryDAO = new CategoryDAO();


        CategoryDAO category = new CategoryDAO();
        public bool Insert(Category category)
        {
            return categoryDAO.Insert(category);
        }
        public bool Update(Category category)
        {
            return categoryDAO.Update(category);
        }
        public bool Delete(Category category)
        {
            return categoryDAO.Update(category);
        }
        public int DemSLTD()
        {
            return categoryDAO.DemSLTD();
        }
    }
}
