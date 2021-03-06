using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLCOFFE.DTO
{
    public class Category
    {
        public Category(int maLH, string tenLH, string moTa, string trangThai)
        {
            this.MaLH = maLH;
            this.TenLH = tenLH;
            this.MoTa = moTa;
            this.TrangThai = trangThai;

        }
        public Category(DataRow row)
        {
            this.MaLH = (int)row["MaLH"];
            this.TenLH = row["TenLH"].ToString();
            this.MoTa = row["MoTa"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }
        public Category()
        {

        }

        private int maLH;
        private string tenLH;
        private string moTa;
        private string trangThai;

        public int MaLH { get => maLH; set => maLH = value; }
        public string TenLH { get => tenLH; set => tenLH = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
