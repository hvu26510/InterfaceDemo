using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IHinh
    {
        int Cao { get; set; }
        int Rong { get; set; }
        int TinhDienTich();
    }

    interface IColor
    {
        string Color { get; set; }

        string getColor();
    }

    class HinhChuNhat : IHinh, IColor
    {
        public int Cao { get; set; }    
        public int Rong { get; set; }
        public string Color { get; set; }

        public int TinhDienTich()
        {
            return (this.Cao*this.Rong);
        }

        public string getColor()
        {
            return this.Color;
        }



    }
}
