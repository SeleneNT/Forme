using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Demo.Classi
{
    class Manager: Persona
    {
        public int ID { get; }

        public Manager(string nome, string cognome, DateTime dataNascita, int id)
            :base(nome, cognome, dataNascita)
        {
            ID= id;
        }


        public double Stipendio
        {
            get
            {
                return Eta * DataNascita.Year;
            }
        }

        public override string ToString() {
            return base.ToString() + $" Stipendio: {Stipendio}";
        }


    }
}
