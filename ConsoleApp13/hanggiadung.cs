using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class hanggiadung:mh
    {

        string baohanh;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap bao hanh");
            baohanh = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("bảo hành : "+ baohanh);
        }
        public hanggiadung():base()
        { 
            baohanh = "2 năm";
        }
        public hanggiadung(string maso, string ten, string dvt, int soluong, int dongia, string baohanh):base(maso , ten, dvt , soluong , dongia)
        {
            this.baohanh = baohanh;
        }
    }
}
