using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace kpz_lab2_2
{
    class Airplane
    {
        private string StartCity;
        private string FinishCity;
        private Date StartDate;
        private Date FinishDate;
    }

    class Date
    {
        private int Year;
        private int Month;
        private int Day;
        private int Hours;
        private int Minutes;

        extern Date(int Year = 0, int Month = 0, int Day = 0, int Hours = 0, int Minutes = 0)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
            this.Hours = Hours;
            this.Minutes = Minutes;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
