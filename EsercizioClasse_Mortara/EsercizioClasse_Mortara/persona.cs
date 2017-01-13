using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioClasse_Mortara
{
    class Persona
    {
        private string _name;
        public string name { get; set; }

        private string _surname;
        public string surname { get; set;} 

        private int _age;
        public int age
        {
            set
            {
                if (_age <= 0) _age = 1;
            }
            get
            {
                return _age;
            }

        private string _fCode;
        public string fCode
        {
            set
            {
                _fCode += "NOME: " + name;
                _fCode += "COGNOME: " + surname;
                _fCode += "ANNI: " + age;
            }
            
        }



        public void Persona()
    }
}
