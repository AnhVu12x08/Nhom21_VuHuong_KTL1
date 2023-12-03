using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom21_VuHuong_KTL1
{
    class PhongTro
    {
        string maphong;

        public string Maphong
        {
            get { return maphong; }
            set 
            {
                if (value.StartsWith("PT") && value.Length == 4)
                    maphong = value;
                else
                    maphong = "PT00";
            }
        }
        int soluong;

        public int Soluong
        {
            get { return soluong; }
            set
            {
                if (value < 0)
                {
                    soluong = 0;
                }
                else soluong=value;
            }
        }
        double giathue;
        public double Giathue
        {
            get { return giathue; }
            set
            {
                if (value < 0)
                {
                    giathue = 0;
                }
                else giathue = value;
            }
        }
        double sodien;
        public double Sodien
        {
            get { return sodien; }
            set
            {
                if (value < 0)
                {
                    sodien = 0;
                }
                else sodien = value;
            }
        }
        int maylanh;

        public int Maylanh
        {
            get { return maylanh; }
            set
            {
                if (value == 1)
                    maylanh = 1;
                else if (value == 0)
                    maylanh = 0;
                else maylanh = 0;
            }
        }
        public PhongTro()
        {
            Maphong = "PT01";
            Soluong = 3;
            Giathue = 1.5;
            Sodien = 0;
            maylanh = 1;
        }
        public PhongTro(string ma, int so, double gia, double dien, int lanh)
        {
            Maphong = ma;
            Soluong = so;
            Giathue = gia;
            Sodien = dien;
            Maylanh = lanh;
        }
        public PhongTro(PhongTro pt)
        {
            pt.Maphong = maphong;
            pt.Soluong = soluong;
            pt.Giathue = giathue;
            pt.Sodien = sodien;
            pt.Maylanh = maylanh;
        }
        static double giadien = 3500;
        public double phimaylanh()
        {
            if (maylanh == 1)
                return soluong * 50;
            else return 0;
        }
        public double tinhtienphong()
        {
            return giathue + sodien * PhongTro.giadien + phimaylanh();
        }
        public void xuat(){
            Console.WriteLine("Ma phong: "+maphong);
            Console.WriteLine("So khach: " +Soluong);
            Console.WriteLine("Gia thue: " +Giathue);
            Console.WriteLine("So dien: "+ Sodien);
            Console.WriteLine("May lanh: " +Maylanh);
            Console.WriteLine("Tien phong: " +tinhtienphong());
        }
    }
}
