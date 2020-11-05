using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab5
{

    public class AirPlane
    {
        protected string StartCity;
        protected string FinishCity;
        public Date[] StartDate = new Date[5];
        public Date[] FinishDate = new Date[5];
        Date StartTime;
        Date FinishTime;

        public AirPlane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public AirPlane()
        {

        }

        public TimeSpan GetTotalTime() //час поїздки
        {
            DateTime start = new DateTime();
            DateTime finish = new DateTime();
            for (int i = 0; i < 5; i++)
            {
                start = new DateTime(StartDate[i].GetYear(), StartDate[i].GetMonth(), StartDate[i].GetDay(), StartDate[i].GetHours(), StartDate[i].GetMinutes(), 0);
                finish = new DateTime(FinishDate[i].GetYear(), FinishDate[i].GetMonth(), FinishDate[i].GetDay(), FinishDate[i].GetHours(), FinishDate[i].GetMinutes(), 0);
            }
            return start.Subtract(finish);
        }

        public bool IsArrivingToday() //однаковий день вiдправлення i прибуття
        {
            if (StartTime.GetDay() == FinishTime.GetDay())
            {
                return true;
            }
            else
                return false;
        }

        public void SetStartCity(string Startcity)
        {
            if (Startcity.Length > 0)
                StartCity = Startcity;
        }
        public void SetFinishCity(string Finishcity)
        {
            if (Finishcity.Length > 0)
                FinishCity = Finishcity;
        }
        public void SetStartDate(Date startDate)
        {
            StartTime = startDate;
        }
        public void SetFinishDate(Date finishDate)
        {
            FinishTime = finishDate;
        }

        public string GetStartCity()
        {
            return StartCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public Date GetStartDate()
        {
            return StartTime;
        }
        public Date GetFinishDate()
        {
            return FinishTime;
        }
    }

    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public Date()
        {

        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public void SetYear(int year)
        {
            Year = year;
        }

        public void SetMonth(int month)
        {
            Month = month;
        }

        public void SetDay(int day)
        {
            Day = day;
        }

        public void SetHours(int hours)
        {
            Hours = hours;
        }

        public void SetMinutes(int minutes)
        {
            Minutes = minutes;
        }

        public int GetYear()
        {
            return Year;
        }

        public int GetMonth()
        {
            return Month;
        }

        public int GetDay()
        {
            return Day;
        }

        public int GetHours()
        {
            return Hours;
        }

        public int GetMinutes()
        {
            return Minutes;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            bool res;
            int n;

            do
            {
                Console.Write("Введiть кiлькiсть польотiв: ");
                string input = Console.ReadLine();
                res = int.TryParse(input, out n);
                if (res != true)
                    Console.WriteLine("Помилка вводу! Введiть числове значення!");
            } while (res != true);

            AirPlane[] mas = new AirPlane[n];

            ReadAirplaneArray(mas, n);

            Console.Clear();

            int sw;

            do
            {
                Console.Clear();

                Console.WriteLine("" +
                    "              1-Вивiд iнформацiї про певний полiт\n" +
                    "              2-Вивiд загальної iнформацiї про всi польоти\n" +
                    "              3-Вивiд найдовшого i найшвидшого польоту\n" +
                    "              4-Вивiд списку польотiв за спаданням дати вiдправлення\n" +
                    "              5-Вивiд списку польотiв за зростаннням часу подорожi\n" +
                    "              6-Вихiд");
                Console.WriteLine("-----------------------------------------------------------");
                Console.Write("\n>>>>> ");

                sw = int.Parse(Console.ReadLine());

                Console.Clear();

                int k;

                if (sw == 1) //вивiд iнформацiї про певний полiт (готово)
                {
                    do
                    {
                        Console.Write("Введiть номер польоту: ");
                        k = int.Parse(Console.ReadLine());

                        if (k > n)
                            Console.WriteLine("Помилка! Полiт з таким номером вiдсутнiй!");
                    } while (k > n);

                    PrintAirplane(mas[k - 1], k - 1);

                    Console.ReadLine();
                }

                if (sw == 2) //вивiд iнформацiї про всi польоти (готово)
                {
                    Console.Clear();

                    PrintAirPlanes(mas, n);

                    Console.ReadLine();
                }

                if (sw == 3) //вивiд найдовшого i найшвидшого польоту (готово) 
                {
                    Console.Clear();

                    GetAirplaneInfo(mas, n, out TimeSpan min, out TimeSpan max);

                    Console.WriteLine("\n\nНайшвидший полiт: \n");
                    for (int i = 0; i < n; i++)
                    {
                        if (min == mas[i].GetTotalTime())
                        {
                            PrintAirplane(mas[i], i + 1);
                            break;
                        }
                    }

                    Console.WriteLine("\n\nНайдовший полiт: \n");
                    for (int i = 0; i < n; i++)
                    {
                        if (max == mas[i].GetTotalTime())
                        {
                            PrintAirplane(mas[i], i + 1);
                            break;
                        }
                    }

                    Console.ReadLine();
                }
                  
               
            } while (sw != 6);

            Console.ReadKey();
        }

        public static void ReadAirplaneArray(AirPlane[] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nПоїздка №{i + 1}: ");
                mas[i] = new AirPlane();
                Console.Write("\nВведiть мiсто початку польоту: ");
                mas[i].SetStartCity(Console.ReadLine());
                Console.Write("Введiть мiсто закiнчення польоту: ");
                mas[i].SetFinishCity(Console.ReadLine());

                mas[i].StartDate[i] = new Date();
                Console.Write($"\nВведiть рiк, мiсяць, день, години, хвилини початку поїздки: \n");
                mas[i].StartDate[i].SetYear(int.Parse(Console.ReadLine()));
                mas[i].StartDate[i].SetMonth(int.Parse(Console.ReadLine()));
                mas[i].StartDate[i].SetDay(int.Parse(Console.ReadLine()));
                mas[i].StartDate[i].SetHours(int.Parse(Console.ReadLine()));
                mas[i].StartDate[i].SetMinutes(int.Parse(Console.ReadLine()));

                mas[i].FinishDate[i] = new Date();
                Console.Write($"\nВведiть рiк, мiсяць, день, години, хвилини прибуття: ");
                mas[i].FinishDate[i].SetYear(int.Parse(Console.ReadLine()));
                mas[i].FinishDate[i].SetMonth(int.Parse(Console.ReadLine()));
                mas[i].FinishDate[i].SetDay(int.Parse(Console.ReadLine()));
                mas[i].FinishDate[i].SetHours(int.Parse(Console.ReadLine()));
                mas[i].FinishDate[i].SetMinutes(int.Parse(Console.ReadLine()));
            }
        }

        static void PrintAirplane(AirPlane mas, int k)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write($"\nМiсто вiдправлення: {mas.GetStartCity()}\nМiсто прибуття: {mas.GetFinishCity()}\n");
            Console.WriteLine("\n-----------------------------------------------------------");

            Console.Write("\nДата вiдправлення: ");
            Console.Write($"{mas.StartDate[k].GetYear()}.{mas.StartDate[k].GetMonth()}.{mas.StartDate[k].GetDay()}  {mas.StartDate[k].GetHours()}:{mas.StartDate[k].GetMinutes()}\n");

            Console.Write("Дата прибуття:");
            Console.Write($"{mas.FinishDate[k].GetYear()}.{mas.FinishDate[k].GetMonth()}.{mas.FinishDate[k].GetDay()}  {mas.FinishDate[k].GetHours()}:{mas.FinishDate[k].GetMinutes()}\n");
        }

        static void PrintAirPlanes(AirPlane[] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.Write($"\nМiсто вiдправлення: {mas[i].GetStartCity()}\nМiсто прибуття: {mas[i].GetFinishCity()}");
                Console.WriteLine("\n-----------------------------------------------------------");

                Console.WriteLine("Дата вiдправлення: ");
                Console.Write($"{mas[i].StartDate[i].GetYear()}.{mas[i].StartDate[i].GetMonth()}.{mas[i].StartDate[i].GetDay()}  {mas[i].StartDate[i].GetHours()}:{mas[i].StartDate[i].GetMinutes()}\n");

                Console.WriteLine("\nДата прибуття:\n");
                Console.Write($"{mas[i].FinishDate[i].GetYear()}.{mas[i].FinishDate[i].GetMonth()}.{mas[i].FinishDate[i].GetDay()}  {mas[i].FinishDate[i].GetHours()}:{mas[i].FinishDate[i].GetMinutes()}\n");
            }
        }

        static void GetAirplaneInfo(AirPlane[] mas, int n, out TimeSpan min, out TimeSpan max)
        {
            min = mas[0].GetTotalTime();
            max = mas[0].GetTotalTime();

            for (int i = 0; i < n; i++)
            {
                if (mas[i].GetTotalTime() < min)
                {
                    min = mas[i].GetTotalTime();
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (mas[i].GetTotalTime() > max)
                {
                    max = mas[i].GetTotalTime();
                }
            }
        }
    }
}