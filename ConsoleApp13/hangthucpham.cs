using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp13
{
    internal class hangthucpham:mh
    {
        string ngaysx;
        string ngayhn;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap ngay sx:");
            ngaysx = Console.ReadLine();
            Console.WriteLine("nhap ngay hn:");
            ngayhn = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("ngay sx: "+ ngaysx);
            Console.WriteLine("ngay hn: " + ngayhn);
        }
        public hangthucpham():base()
        {
            ngaysx = "";
            ngayhn = "10/11";
        }
        public hangthucpham(string maso , string ten , string dvt , int soluong, int dongia , string ngaysx , string ngayhn):base(maso, ten, dvt, soluong, dongia)
        { 
            this.ngaysx = ngaysx;
            this.ngayhn = ngayhn;
        }

    }
}
