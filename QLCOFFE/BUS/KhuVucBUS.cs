using QLCOFFE.DAO;
using QLCOFFE.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCOFFE.BUS
{
    class KhuVucBUS
    {
        ArenaDAO arenaDAO = new ArenaDAO();


        ArenaDAO arena = new ArenaDAO();
        public bool Insert(Arena arena)
        {
            return arenaDAO.Insert(arena);
        }
        public bool Update(Arena arena)
        {
            return arenaDAO.Update(arena);
        }
        public bool Delete(Arena arena)
        {
            return arenaDAO.Update(arena);
        }
        public int DemSLTD()
        {
            return arenaDAO.DemSLTD();
        }
    }
}
