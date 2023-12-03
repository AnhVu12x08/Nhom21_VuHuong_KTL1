using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Nhom21_VuHuong_KTL1
{
    class KhuTro
    {
        string tenkhu;
        string diachi;
        List<PhongTro> listpt;
        public List<PhongTro> ListPT
        {
            get { return listpt; }
            set { listpt = value; }
        }
        public KhuTro()
        {
            listpt = new List<PhongTro>();
        }

        public void DocXML(string filepath)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filepath);

            XmlNode node_khutro = read.SelectSingleNode("/khutro");
            tenkhu = node_khutro["ten"].InnerText;
            diachi = node_khutro["diachi"].InnerText;
            XmlNodeList nodelist = read.SelectNodes("/khutro/phongs/phong");
            foreach (XmlNode node in nodelist)
            {
                int maylanh = int.Parse(node["loai"].InnerText);
                string maphong = node["map"].InnerText;
                int soluong = int.Parse(node["soluong"].InnerText);
                double sodien = double.Parse(node["sodien"].InnerText);
                double gia = double.Parse(node["gia"].InnerText);
                PhongTro pt = new PhongTro(maphong,soluong, gia, sodien,maylanh);
                listpt.Add(pt);
            }
        }
        public double tongtien()
        {
            double sum = 0;
            sum = +listpt.Sum(pt => pt.tinhtienphong());
            return sum;
        }
        public void xuatpt()
        {
            Console.WriteLine("Ten khu: "+tenkhu);
            Console.WriteLine("Dia chi: "+diachi);
            Console.WriteLine("---");
            foreach (PhongTro x in listpt)
                x.xuat();
            Console.WriteLine("---");
            Console.WriteLine("Tong tien phong: "+tongtien());
        }
         public void sapxep()
        {
            listpt.Sort((pt1, pt2) =>
            {
                if (pt1.Soluong == pt2.Soluong)
                    return pt2.Giathue.CompareTo(pt1.Giathue);
                else
                    return pt2.Soluong.CompareTo(pt1.Soluong);
            });
        }
        

    }
}
