using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCOFFE.DTO
{
   
   


        public class Arena
        {
        public Arena()
        {

        }
        public Arena(string maKV, string tenKV, string trangThai)
            {

                this.MaKV = MaKV;
                this.TenKV = tenKV;

                this.TrangThai = trangThai;
            }
            public Arena(DataRow row)
            {
                this.MaKV = row["MaKV"].ToString();
                this.TenKV = row["TenKV"].ToString();

                this.TrangThai = row["TrangThai"].ToString();
            }

            private string maKV;
            private string tenKV;

            private string trangThai;


            public string MaKV { get => maKV; set => maKV = value; }
            public string TenKV { get => tenKV; set => tenKV = value; }

            public string TrangThai { get => trangThai; set => trangThai = value; }
        }
    }
