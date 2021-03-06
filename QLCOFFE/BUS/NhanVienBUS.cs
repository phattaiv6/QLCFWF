using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCOFFE.DAO;
using System.Data.Entity.Validation;
using QLCOFFE.DTO;

namespace QLCOFFE.BUS
{
    public class NhanVienBUS
    {
        StaffDAO staff = new StaffDAO();

        
        StaffDAO nvmod = new StaffDAO();
        public bool Insert(Staff nv)
        {
            return staff.Insert(nv);
        }
        public bool Update(Staff nv)
        {
            return staff.Update(nv);
        }
        public bool Delete(Staff nv)
        {
            return staff.Update(nv);
        }
        public int DemSLNV()
        {
            return staff.DemSLNV();
        }
        public bool Update1(Staff nv)
        {
            return staff.Update1(nv);
        }
    }
}
