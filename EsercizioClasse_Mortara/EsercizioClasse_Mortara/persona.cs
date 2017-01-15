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
        }

        private string _fCode;
        public string fCode
        {
            get
            {
                return _fCode = name + surname + age;
            }
            
        }

        public Persona(string fName, string lName, int years)
        {
            _name = fName;
            _surname = lName;
            _age = years;
            Console.WriteLine(describe(_name, _surname, _age));
        }

        public virtual string describe( string fName , string lName, int years)
        {
            string output = "NOME: " + fName + "\r\n";
                   output += "COGNOME: " + lName + "\r\n";
                   output += "ANNI: " + years + "\r\n";

            return output; 
        }
    }
}
