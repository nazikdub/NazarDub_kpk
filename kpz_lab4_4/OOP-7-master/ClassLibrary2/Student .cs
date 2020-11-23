using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class Student : Human
    {
        private int course;
        private string group;
        private string faculty;
        private string institution_of_higher_education;

        public void Init_Student()
        {
            Init_Human();
            Console.WriteLine("Введiть курс (число)");
            this.course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть групу");
            this.group = Console.ReadLine();
            Console.WriteLine("Введiть факультет");
            this.faculty = Console.ReadLine();
            Console.WriteLine("Введiть назву вищого навчального закладу");
            this.institution_of_higher_education = Console.ReadLine();

        }
        public Student(int course = 0, string group = "", string faculty = "",
            string institution_of_higher_education = "")
        {
            this.course = course;
            this.group = group;
            this.faculty = faculty;
            this.institution_of_higher_education = institution_of_higher_education;
        }
        public Student(Student student)
        {
            Set_Name(student.Get_Name());
            Set_Surname(student.Get_Surname());
            Set_Birthday(student.Get_Birthday());
            this.course = student.course;
            this.group = student.group;
            this.faculty = student.faculty;
            this.institution_of_higher_education = student.institution_of_higher_education;
        }
        public void Set_course(int course) { this.course = course; }
        public void Set_group(string group) { this.group = group; }
        public void Set_faculty(string faculty) { this.faculty = faculty; }
        public void Set_institution_of_higher_education(string institution_of_higher_education)
        {
            this.institution_of_higher_education = institution_of_higher_education;
        }
        public int Get_course() { return course; }
        public string Get_group() { return group; }
        public string Get_faculty() { return faculty; }
        public string Get_institution_of_higher_education() { return institution_of_higher_education; }
        public override void Show_Info()
        {
            System.Console.WriteLine("________________Студент_______________");
            System.Console.WriteLine("Iм'я            - " + Get_Name());
            System.Console.WriteLine("Прiзвище        - " + Get_Surname());
            System.Console.WriteLine("Дата народження - " + Get_Birthday());
            System.Console.WriteLine("");
            System.Console.WriteLine("Курс            - " + course);
            System.Console.WriteLine("Група           - " + group);
            System.Console.WriteLine("Факультет       - " + faculty);
            System.Console.WriteLine("Вищий заклад    - " + institution_of_higher_education);
            System.Console.WriteLine("______________________________________");
        }
    }
}
