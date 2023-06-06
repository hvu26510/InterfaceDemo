using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IEmployee e1 = new FullTimeEmployee()
            //{
            //    Name = "Foo",
            //    LuongThang = 15
            //};


            //IEmployee e2 = new PartTimeEmployee()
            //{
            //    Name = "Pham quang phu",
            //    HourlyRate = 10,
            //    SoGio = 80
            //};

            //e1.DisplayInformation();
            //Console.WriteLine("Luong:" + e1.TinhLuong());

            // e2.DisplayInformation();
            //Console.WriteLine("Luong:" + e2.TinhLuong());


            HinhChuNhat hcn = new HinhChuNhat();
            hcn.Cao = 5;
            hcn.Rong = 10;
            hcn.Color = "Blackpink";

            Console.WriteLine("Cao:" +hcn.Cao);
            Console.WriteLine("Rong:" + hcn.Rong);
            Console.WriteLine("Color:" + hcn.getColor());
            Console.WriteLine("Dien Tich:" + hcn.TinhDienTich());

            Console.ReadLine();
        }
    }
}
