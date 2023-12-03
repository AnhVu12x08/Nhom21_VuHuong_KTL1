using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom21_VuHuong_KTL1
{
    class Program
    {
        static void Main(string[] args)
        {
            KhuTro ds = new KhuTro();
            ds.DocXML(@"..\..\khutro.xml");
            ds.xuatpt();
            ds.sapxep();
            ds.xuatpt();
            Console.ReadLine();

        }
    }
}
