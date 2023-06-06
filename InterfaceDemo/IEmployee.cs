using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IEmployee
    {
        string Name { get; set; }
        void DisplayInformation();
        double TinhLuong();
    }

    class FullTimeEmployee : IEmployee
    {

        public string Name { get; set; }
        public double LuongThang { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine("Nhan vien fulltime");
            Console.WriteLine($"Name {this.Name}");
        }
        public double TinhLuong()
        {
            return this.LuongThang;
        }

    }

    class PartTimeEmployee : IEmployee
    {
        public string Name { get;set; }
        public double HourlyRate { get; set; }
        public double SoGio { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine("Nhan vien partTime");
            Console.WriteLine($"Name {this.Name}");
        }
        public double TinhLuong()
        {
            return (this.HourlyRate*this.SoGio);
        }

    }
}
