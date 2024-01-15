using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class hangquanaogiaydep:mh
    {

        double kichco;
        string mausac;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap kich co: ");
            kichco = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau sac: ");
            mausac = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("kich co: "+ kichco);
            Console.WriteLine("mau sac: "+ mausac);
        }
        public hangquanaogiaydep():base()
        {
            kichco = 32.5;
            mausac = "trắng";
        }
        public hangquanaogiaydep(string maso, string ten, string dvt, int soluong, int dongia, double kichco , string mausac) : base(maso, ten, dvt, soluong, dongia) 
        {
            this.kichco = kichco;
            this.mausac = mausac;
        }
    }
}
