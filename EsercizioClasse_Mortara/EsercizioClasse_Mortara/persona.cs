using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioClasse_Mortara
{
    class Persona
    {
        private string _fName;
        public string fName { get; set; }

        private string _lName;
        public string lName { get; set;} 

        private int _age;
        public int age
        {
            set
            {
                if (value <= 0) value = 1;
                _age = value;
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
                return _fCode = fName + lName + age;
            }
            
        }

        public Persona(string fName, string lName, int age)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
            Console.WriteLine(describe());
        }

        public virtual string describe()
        {
            string output = "NOME: " + fName + "\r\n";
                   output += "COGNOME: " + lName + "\r\n";
                   output += "ANNI: " + age + "\r\n";

            return output; 
        }
    }
}
