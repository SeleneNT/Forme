using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forme_Geometrice2;

namespace Week1_Demo.Classi
{   
    public abstract class AbstractShape
    {
        public abstract double Area();
        //non ho un'implementazione. Così non posso istanziarla! 
    }

    public class Persona: IEntita
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public Persona(string nome, string cognome, DateTime dataNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
        }

        public override string ToString()
        {
            return ($" Nome: {Nome}  Cognome: {Cognome} Data di Nascita: {DataNascita.ToShortDateString()} Età: {Eta}");
        }
        
        //metodo
        private int CalcolaEta()
        {
            return DateTime.Today.Year - DataNascita.Year;
        }

        //proprietà
        public int Eta { 
            get
            {
                return DateTime.Today.Year - DataNascita.Year;
            } 
        }

       public static void EsercizioFormeGeometriche()
        {
            FormaGeometrica forma = new FormaGeometrica("forma");
            List<FormaGeometrica> listaForme = new List<FormaGeometrica>()
            {
                //new Triangolo(),
                //new Cerchio(),
                //new Rettangolo()
            };
        }

        public string CalcolaCodiceFiscale()
        {
            return Nome.Substring(0, 3) + Cognome.Substring(0, 3) + DataNascita.Year;
        }
    }
}
