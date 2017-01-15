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

        public Studente(string fName, string lName, int years , string sez): base(fName, lName, years)
        {
            _sezione = sez;
            Console.WriteLine(describe(fName, lName, years, _sezione));
        }

        public override string describe(string fName, string lName, int years, string sez)
        {
            base.describe(fName, lName, years);

            string output = "SEZIONE: " + sez + "\r\n";

            return output;
        }

    }
}
