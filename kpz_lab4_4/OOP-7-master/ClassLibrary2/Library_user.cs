using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class Library_user : Human
    {
        private int ticket_number;
        private string date_of_issue;
        private double readers_fee;

        public void Init_Library_user()
        {
            Init_Human();
            Console.WriteLine("Введiть номер читального квитка");
            this.ticket_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть дату видачi квитка");
            this.date_of_issue = Console.ReadLine();
            Console.WriteLine("Введiть розмiр щомiсячногочитацького внеску ");
            this.readers_fee = Convert.ToDouble(Console.ReadLine());
        }
        public int Get_ticket_number() { return ticket_number; }
        public string Get_date_of_issue() { return date_of_issue; }
        public double Get_readers_fee() { return readers_fee; }
        public void Set_ticket_number(int ticket_number) { this.ticket_number = ticket_number; }
        public void Set_date_of_issue(string date_of_issue) { this.date_of_issue = date_of_issue; }
        public void Set_readers_fee(double readers_fee) { this.readers_fee = readers_fee; }
        public Library_user(int ticket_number = 0, string date_of_issue = "", double readers_fee = 0)
        {
            this.ticket_number = ticket_number;
            this.date_of_issue = date_of_issue;
            this.readers_fee = readers_fee;
        }
        public Library_user(Library_user library_User)
        {
            Set_Name(library_User.Get_Name());
            Set_Surname(library_User.Get_Surname());
            Set_Birthday(library_User.Get_Birthday());

            this.ticket_number = library_User.ticket_number;
            this.date_of_issue = library_User.date_of_issue;
            this.readers_fee = library_User.readers_fee;
        }
        public override void Show_Info()
        {
            System.Console.WriteLine("________________Студент_______________");
            System.Console.WriteLine("Iм'я            - " + Get_Name());
            System.Console.WriteLine("Прiзвище        - " + Get_Surname());
            System.Console.WriteLine("Дата народження - " + Get_Birthday());
            System.Console.WriteLine("");
            System.Console.WriteLine("-----------Читацький квиток-----------");
            System.Console.WriteLine("Номер квитка    - "+ ticket_number);
            System.Console.WriteLine("Дата видачi     - " + date_of_issue);
            System.Console.WriteLine("Цiна за мiсяць  - "+ readers_fee);

        }
    }
}
