using System;
using System.Collections.Generic;
using System.Text;

namespace WpfLMI
{
    public class Teacher : Human
    {
        private string posada;
        private string cathedra;
        private string institution_of_higher_education;

        public Teacher(string posada = "", string cathedra = "", string institution_of_higher_education = "")
        {
            this.posada = posada;
            this.cathedra = cathedra;
            this.institution_of_higher_education = institution_of_higher_education;
        }

        public string Posada
        {
            get { return posada; }
            set
            {
                posada = value;
                OnPropertyChanged("Posada");
            }
        }
        public string Cathedra
        {
            get { return cathedra; }
            set
            {
                cathedra = value;
                OnPropertyChanged("Cathedra");
            }
        }
        public string Institution_of_higher_education
        {
            get { return institution_of_higher_education; }
            set
            {
                institution_of_higher_education = value;
                OnPropertyChanged("Institution_of_higher_education");
            }
        }
    }
 
}
