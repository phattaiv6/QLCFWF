using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLCOFFE.DTO
{
    public class Table
    {
        public Table(int maBan, string maKV, string tenBan, string trangThai)
        {
            this.MaBan = maBan;
            this.MaKV = MaKV;
            this.TenBAn = tenBan;

            this.TrangThai = trangThai;
        }
        public Table(DataRow row)
        {
            this.MaBan = (int)row["MaBan"];
            this.MaKV = row["MaKV"].ToString();
            this.TenBAn = row["TenBan"].ToString();

            this.TrangThai = row["TrangThai"].ToString();
        }
        public Table()
        {

        }
        private int maBan;
        private string maKV;
        private string tenBAn;

        private string trangThai;

        public int MaBan { get => maBan; set => maBan = value; }
        public string MaKV { get => maKV; set => maKV = value; }
        public string TenBAn { get => tenBAn; set => tenBAn = value; }

        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
