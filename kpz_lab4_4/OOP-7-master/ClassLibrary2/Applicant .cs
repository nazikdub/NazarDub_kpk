using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class Applicant : Human
    {
        // Абітурієнт
        private ZNO[] zno;
        private medium_ed[] _medium_ed;
        private string Name_of_educational_institution;
        public void Init_Aplicant()
        {
            Init_Human();
            Console.WriteLine("Введiть кiлькiсть предметiв ЗНО"); 
            int size = Convert.ToInt32(Console.ReadLine());
            zno = new ZNO[size];
            for(int i = 0; i<size; i++)
            {
                zno[i] = new ZNO();
                zno[i].Init_Zno();


            }
            Console.WriteLine("Введiть кiлькiсть предметiв середньої школи");
            size = Convert.ToInt32(Console.ReadLine());
            _medium_ed = new medium_ed[size];
            for (int i = 0; i < size; i++)
            {
                _medium_ed[i] = new medium_ed();
                _medium_ed[i].Init_Medium_ed();
            }
            Console.WriteLine("Введiть назву навчального iнституту");
            this.Name_of_educational_institution = Console.ReadLine();
        }
        public Applicant(ZNO[] zno = null, medium_ed[] _medium_ed = null, string Name_of_educational_institution = "")
        {
            if (zno == null)
            {
                this.zno = new ZNO[0];
            }
            else
            {
                this.zno = new ZNO[zno.Length - 1];
                for (int i = 0; i < zno.Length; i++)
                {
                    this.zno[i] = zno[i];
                }

            }
            if (_medium_ed == null)
            {
                this._medium_ed = new medium_ed[0];
            }
            else
            {
                this._medium_ed = new medium_ed[_medium_ed.Length - 1];
                for (int i = 0; i < _medium_ed.Length; i++)
                {
                    this._medium_ed[i] = _medium_ed[i];
                }
            }
            this.Name_of_educational_institution = Name_of_educational_institution;
        }
        public Applicant(Applicant applicant)
        {
            this.zno = new ZNO[applicant.zno.Length - 1];
            this._medium_ed = new medium_ed[applicant._medium_ed.Length - 1];
            for (int i = 0; i < applicant.zno.Length; i++)
            {
                this.zno[i] = applicant.zno[i];
            }
            for (int i = 0; i < applicant._medium_ed.Length; i++)
            {
                this._medium_ed[i] = applicant._medium_ed[i];
            }
            this.Name_of_educational_institution = applicant.Name_of_educational_institution;
        }
        public Applicant(string Name_of_educational_institution)
        {
            this.zno = new ZNO[0];
            this._medium_ed = new medium_ed[0];
            this.Name_of_educational_institution = Name_of_educational_institution;
        }
        public void Set_ZNO(ZNO[] zno)
        {
            this.zno = new ZNO[zno.Length];
            for (int i = 0; i < zno.Length; i++)
            {
                this.zno[i] = zno[i];
            }
        }
        public void Set_medium_ed(medium_ed[] _medium_ed)
        {
            this._medium_ed = new medium_ed[_medium_ed.Length];
            for (int i = 0; i < _medium_ed.Length; i++)
            {
                this._medium_ed[i] = _medium_ed[i];
            }
        }
        public void Set_Name_of_educational_institution(string Name_of_educational_institution)
        {
            this.Name_of_educational_institution = Name_of_educational_institution;
        }
        public override void Show_Info()
        {
            System.Console.WriteLine("______________Абiтурiєнт_____________");
            System.Console.WriteLine("Iм'я            - " + Get_Name());
            System.Console.WriteLine("Прiзвище        - " + Get_Surname());
            System.Console.WriteLine("Дата народження - " + Get_Birthday());
            System.Console.WriteLine("");
            System.Console.WriteLine("____________Результати ЗНО___________");
            foreach (var item in zno)
            {
                item.Show_ZNO();
            }
            System.Console.WriteLine("__________Середнiй бал Школи_________");
            foreach (var item in _medium_ed)
            {
                item.Show_Ed();
            }
            System.Console.WriteLine("Навчальний заклад - " + Name_of_educational_institution);
            System.Console.WriteLine("_____________________________________");
        }
    }
}