using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class QuanLyMatHang
    {
        List<mh> math;
        public QuanLyMatHang()
        {
            math = new List<mh>();
        }
        public QuanLyMatHang(List<mh> math)
        { 
            this.math = math;   
        }
        public void themmathang(mh hangmoi)
        {
            math.Add(hangmoi);
        }
        public void timkiemmh(string tk)
        {
            var tkmh = math.Where(o=>o.getten() == tk);
            {
                foreach (var item in tkmh)
                {
                    item.xuat();
                }
            }
        }
        public void mathangmx(string mhmx)
        {
            var tkmh = math.Where(o=>o.getten()==mhmx);
            {
                foreach (var item in tkmh)
                {
                    math.Remove(item);
                }
            }
        }
        public void hienthimh()
        { 
            foreach(var item in math) 
            {
                item.xuat();
            }
        }
        public void dsmh()
        {
            foreach (var item in math)
            {
                item.xuat();
            }
        }
        public void danhsmathang()
        {
            int giacaonhat = math.Select(o=>o.getdongia()).Max();
            var tkds = math.Where(o=>o.getdongia()== giacaonhat);
            {
                foreach (var item in tkds)
                {
                    item.xuat();
                }
            }
        }
    }
}
