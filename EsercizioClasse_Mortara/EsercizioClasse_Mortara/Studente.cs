using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioClasse_Mortara
{
    class Studente: Persona
    {
        private string _sezione;
        public string sezione { get; set; }

        public Studente(string fName, string lName, int years , string sezione): base(fName, lName, years)
        {
            _sezione = sezione;
            Console.WriteLine(describe());
        }

        public override string describe()
        {
            return base.describe() + ("SEZIONE: " + sezione + "\r\n"); 
        }

    }
}
