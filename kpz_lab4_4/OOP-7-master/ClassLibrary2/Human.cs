using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class Human
    {
        private string Name;
        private string Surname;
        private string Birthday;
        public Human(string Name = "", string Surname = "", string Birthday = "")
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Birthday = Birthday;
        }
        public Human(Human human)
        {
            this.Name = human.Name;
            this.Surname = human.Surname;
            this.Birthday = human.Birthday;
        }
        public Human(string Surname, string Birthday)
        {
            this.Name = "";
            this.Surname = Surname;
            this.Birthday = Birthday;
        }
        public Human(string Birthday)
        {
            this.Name = "";
            this.Surname = "";
            this.Birthday = Birthday;
        }
        public void Set_Name(string Name)
        {
            this.Name = Name;
        }
        public void Set_Surname(string Surname)
        {
            this.Surname = Surname;
        }
        public void Set_Birthday(string Birthday)
        {
            this.Birthday = Birthday;
        }
        public string Get_Name() { return Name; }
        public string Get_Surname() { return Surname; }
        public string Get_Birthday() { return Birthday; }
        public virtual void Show_Info()
        {
            System.Console.WriteLine("______________Людина_____________");
            System.Console.WriteLine("Iм'я            - " + Name);
            System.Console.WriteLine("Прiзвище        - " + Surname);
            System.Console.WriteLine("Дата народження - " + Birthday);
            System.Console.WriteLine("_________________________________");
        }
        public void Init_Human()
        {
            System.Console.WriteLine("Введiть iм'я");
            this.Name = System.Console.ReadLine();
            System.Console.WriteLine("Введiть прiзвище");
            this.Surname = System.Console.ReadLine();
            System.Console.WriteLine("Введiть дату народження");
            this.Birthday = System.Console.ReadLine();
        }
    }
}