using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyMatHang qlmh = new QuanLyMatHang();
            do
            {
                Console.WriteLine("1.thêm");
                Console.WriteLine("2.tim kiem");
                Console.WriteLine("3.xoa");
                Console.WriteLine("4.hien thi");
                Console.WriteLine( "5.in thông tin mặt hang có giá trị cao nhất: ");
                Console.WriteLine("6.thoát");
                Console.WriteLine("chon chức năng: ");
                int chonchucnang = 0;
                chonchucnang = int.Parse(Console.ReadLine());
                if (chonchucnang == 1)
                {
                    Console.WriteLine("a.hàng thuc pham");
                    Console.WriteLine("b.hang gia dung");
                    Console.WriteLine("c.hang quan ao giay dep");
                    Console.WriteLine("d.thoat");
                    string chonchu = "";
                    chonchu = Console.ReadLine();
                    if (chonchu.ToLower() == "a")
                    {
                        
                        hangthucpham htp = new hangthucpham();
                        htp.xuat();
                        qlmh.themmathang(htp);
                    }
                    if (chonchu.ToLower() == "b")
                    {
                        hanggiadung hgd = new hanggiadung();
                        hgd.xuat();
                        qlmh.themmathang(hgd);
                    }
                    if (chonchu.ToLower() == "c")
                    {
                        hangquanaogiaydep qagd = new hangquanaogiaydep();
                        qagd.xuat();
                        qlmh.themmathang(qagd);
                    }

                }
                else if (chonchucnang == 2)
                {
                    string tenmh = "";
                    tenmh = Console.ReadLine();
                    qlmh.timkiemmh(tenmh);
                }
                else if (chonchucnang == 3)
                {
                    string tenmx = "";
                    tenmx = Console.ReadLine();
                    qlmh.mathangmx(tenmx);
                }
                else if (chonchucnang == 4)
                {
                    qlmh.hienthimh();
                }
                else if (chonchucnang == 5)
                {
                    qlmh.danhsmathang();
                }
                else
                {
                    return;
                }
            } while (true); 
        }
    }
}
