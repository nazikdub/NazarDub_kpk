using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class Teacher : Human
    {
        private string posada;
        private string cathedra;
        private string institution_of_higher_education;

        public void Init_Teacher()
        {
            Init_Human();
            Console.WriteLine("Введiть посаду");
            this.posada = Console.ReadLine();
            Console.WriteLine("Введiть кафедру");
            this.cathedra = Console.ReadLine();
            Console.WriteLine("Введiть назву вищого навчального закладу");
            this.institution_of_higher_education = Console.ReadLine();
        }
        public string Get_posada() { return posada; }
        public string Get_cathedra() { return cathedra; }
        public string Get_institution_of_higher_education() { return institution_of_higher_education; }
        public void Set_posada(string posada) { this.posada = posada; }
        public void Set_cathedra(string cathedra) { this.cathedra = cathedra; }
        public void Set_institution_of_higher_education(string institution_of_higher_education)
        {
            this.institution_of_higher_education = institution_of_higher_education;
        }
        public Teacher(string posada = "", string cathedra = "", string institution_of_higher_education = "")
        {
            this.posada = posada;
            this.cathedra = cathedra;
            this.institution_of_higher_education = institution_of_higher_education;
        }
        public Teacher(Teacher teacher)
        {
            Set_Name(teacher.Get_Name());
            Set_Surname(teacher.Get_Surname());
            Set_Birthday(teacher.Get_Birthday());
            this.posada = teacher.posada;
            this.cathedra = teacher.cathedra;
            this.institution_of_higher_education = teacher.institution_of_higher_education;
        }
        public override void Show_Info()
        {
            System.Console.WriteLine("________________Викладач_______________");
            System.Console.WriteLine("Iм'я            - " + Get_Name());
            System.Console.WriteLine("Прiзвище        - " + Get_Surname());
            System.Console.WriteLine("Дата народження - " + Get_Birthday());
            System.Console.WriteLine("");
            System.Console.WriteLine("Посада          - " + posada);
            System.Console.WriteLine("Кафедра         - " + cathedra);
            System.Console.WriteLine("Вищий заклад    - " + institution_of_higher_education);
            System.Console.WriteLine("______________________________________");
        }
    }
}
