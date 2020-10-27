using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz_lab1_1
{
    struct Result
    {
        public string Subject;
        public string Teacher;
        public int Points;

        public Result(string Subject = "0", string Teacher = "0", int Points = 0)
        {
            this.Subject = Subject;
            this.Teacher = Teacher;
            this.Points = Points;
        }

    }
    struct Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Year;

        public Result[] Results;

        public Student(string Name = "0", string Surname = "0", string Group = "0", int Year = 0)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Group = Group;
            this.Year = Year;
            this.Results = null;
        }
        public int GetAveragePoints()
        {
            int AveragePoints = 0;
            for (int i = 0; i < Results.Length; i++)
            {
                AveragePoints += Results[i].Points;
            }

            return AveragePoints / Results.Length;
        }
        public string GetBestSubject()
        {
            string BestSubject = Results[0].Subject;
            int AveragePoint = Results[0].Points;
            for (int i = 1; i < Results.Length; i++)
            {
                if (AveragePoint < Results[i].Points)
                {
                    AveragePoint = Results[i].Points;
                    BestSubject = Results[i].Subject;
                }
            }
            return BestSubject;
        }
        public string GetWorstSubject()
        {
            string WorstSubject = Results[0].Subject;
            int AveragePoint = Results[0].Points;
            for (int i = 1; i < Results.Length; i++)
            {
                if (AveragePoint > Results[i].Points)
                {
                    AveragePoint = Results[i].Points;
                    WorstSubject = Results[i].Subject;
                }
            }
            return WorstSubject;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);

            Student[] MyStudents;
            MyStudents = ReadStudentsArray();
            int BestAveragePoints = 0, WorstAveragePoints = 0;

            PrintStudents(MyStudents);

            GetStudentsInfo(MyStudents, out BestAveragePoints, out WorstAveragePoints);
            Console.WriteLine("Найкращий середнiй бал - " + BestAveragePoints + ("Найгiрший середнiй бал - " + WorstAveragePoints + (" (З усiх студентiв) ")));

            MyStudents = SortStudentsByPoints(MyStudents);
            Console.WriteLine("");
            Console.WriteLine("Вивiд списку студентiв пiсля сортування по середньому балу");
            Console.WriteLine("");
            PrintStudents(MyStudents);

            MyStudents = SortStudentsByName(MyStudents);
            Console.WriteLine("");
            Console.WriteLine("Вивiд списку студентiв пiсля сортування по iнiцiалах");
            Console.WriteLine("");
            PrintStudents(MyStudents);
            Console.ReadKey();
        }
        static Student[] ReadStudentsArray()
        {
            string templine;
            int size_student, size_result;
            Console.WriteLine("Введiть кiлькiсть студентiв!");
            templine = Console.ReadLine();
            size_student = Convert.ToInt32(templine);
            Student[] temp_arry = new Student[size_student];
            for (int i = 0; i < size_student; i++)
            {
                Console.WriteLine("Введiть iм'я студента");
                temp_arry[i].Name = Console.ReadLine();
                Console.WriteLine("Введiть прiзвище студента");
                temp_arry[i].Surname = Console.ReadLine();
                Console.WriteLine("Введiть групу студента");
                temp_arry[i].Group = Console.ReadLine();
                Console.WriteLine("Введiть номер курсу студента");
                templine = Console.ReadLine();
                temp_arry[i].Year = Convert.ToInt32(templine);

                Console.WriteLine("Введiть кiлькiсть предметiв у даного студента");
                templine = Console.ReadLine();
                size_result = Convert.ToInt32(templine);

                Console.WriteLine("");
                temp_arry[i].Results = new Result[size_result];
                for (int j = 0; j < size_result; j++)
                {
                    Console.WriteLine("Введiть назву " + (j + 1) + "-го предмету");
                    temp_arry[i].Results[j].Subject = Console.ReadLine();
                    Console.WriteLine("Введiть ПIБ викладача ");
                    temp_arry[i].Results[j].Teacher = Console.ReadLine();
                    Console.WriteLine("Введiть Бал з " + (temp_arry[i].Results[j].Subject) + " (по 100-Бальнiй шкалi)!");
                    templine = Console.ReadLine();
                    temp_arry[i].Results[j].Points = Convert.ToInt32(templine);
                    Console.Clear();
                }
            }
            return temp_arry;
        }
        static void PrintStudent(Student obj)
        {
            Console.WriteLine("Iм'я студента        - " + obj.Name);
            Console.WriteLine("Прiзвище студента    - " + obj.Surname);
            Console.WriteLine("Група студента       - " + obj.Group);
            Console.WriteLine("Курс студента        - " + obj.Year);
            Console.WriteLine("");
            Console.WriteLine("Перелiк предметiв студента" + " ( " + obj.Results.Length + " )");

            for (int i = 0; i < obj.Results.Length; i++)
            {
                Console.WriteLine("Назва предмету   - " + obj.Results[i].Subject);
                Console.WriteLine("ПIБ викладача    - " + obj.Results[i].Teacher);
                Console.WriteLine("Бал              - " + obj.Results[i].Points);
                Console.WriteLine("");
            }

        }
        static void PrintStudents(Student[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                PrintStudent(obj[i]);
            }
        }
        static void GetStudentsInfo(Student[] obj, out int BestAveragePoints, out int WorstAveragePoints)
        {
            BestAveragePoints = obj[0].GetAveragePoints();
            WorstAveragePoints = obj[0].GetAveragePoints();
            for (int i = 1; i < obj.Length; i++)
            {
                if (BestAveragePoints < obj[i].GetAveragePoints())
                {
                    BestAveragePoints = obj[i].GetAveragePoints();
                }
                else if (WorstAveragePoints > obj[i].GetAveragePoints())
                {
                    WorstAveragePoints = obj[i].GetAveragePoints();
                }
            }
        }
        static Student[] SortStudentsByPoints(Student[] obj)
        {
            for (int i = 1; i < obj.Length; i++)
            {
                for (int j = 0; j < obj.Length - i; j++)
                {
                    if (obj[j].GetAveragePoints() > obj[j + 1].GetAveragePoints())
                    {
                        Student temp = obj[j];
                        obj[j] = obj[j + 1];
                        obj[j + 1] = temp;
                    }
                }
            }
            return obj;
        }
        static Student[] SortStudentsByName(Student[] obj)
        {
            for (int i = 1; i < obj.Length; i++)
            {
                for (int j = 0; j < obj.Length - i; j++)
                {
                    if ((obj[j].Surname.CompareTo(obj[j + 1].Surname)) > 0)
                    {
                        Student temp = obj[j];
                        obj[j] = obj[j + 1];
                        obj[j + 1] = temp;

                    }
                    else if ((obj[j].Surname.CompareTo(obj[j + 1].Surname)) == 0)
                    {
                        if ((obj[j].Name.CompareTo(obj[j + 1].Name)) > 0)
                        {
                            Student temp = obj[j];
                            obj[j] = obj[j + 1];
                            obj[j + 1] = temp;

                        }
                    }
                }
            }
            return obj;
        }
    }

}
