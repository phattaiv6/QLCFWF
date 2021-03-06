using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCOFFE.DAO;
using QLCOFFE.DTO;
namespace QLCOFFE.BUS
{
    class BanBus
    {
        TableDAO tableDAO = new TableDAO();


        TableDAO table = new TableDAO();
        public bool Insert(Table table)
        {
            return tableDAO.Insert(table);
        }
        public bool Update(Table table)
        {
            return tableDAO.Update(table);
        }
        public bool Delete(Table table)
        {
            return tableDAO.Update(table);
        }
        public int DemSLTD()
        {
            return tableDAO.DemSLTD();
        }
    }
}
