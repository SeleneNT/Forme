using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_Demo.Classi;

namespace Week1_Demo
{
    public enum State
    {
        New,
        Open,
        OnHold,
        Closed
    }

    class Funzionalita
    {
        public static void EsercizioTipo()
        {
            //Metodo specifico della classe: static

            //Value Type vs Reference Type
            bool x = true;
            bool y = false;

            bool z = !x;
            //accedo direttamente il valore di questa variabile
            Console.WriteLine($"Valore x: {x}");
            Console.WriteLine($"Valore z: {z}");

            string s = "a";
            string b = "r";
            Console.WriteLine($"Valore b: {b}");
            b = s;
            Console.WriteLine($"Valore s: {s}");
            Console.WriteLine($"Valore b: {b}");


            float flo = 1f / 3f;
            double doubl = 1d / 3d;
            decimal dec = 1m / 3m;
            Console.WriteLine($"Valore float: {flo}");
            Console.WriteLine($"Valore double: {doubl}");
            Console.WriteLine($"Valore decimal: {dec}");
            Console.WriteLine($"Range float: {float.MinValue}- {float.MaxValue} ");
            Console.WriteLine($"Range double: {double.MinValue}- {double.MaxValue} ");
            Console.WriteLine($"Range decimal: {decimal.MinValue}- {decimal.MaxValue} ");

            //enum
            State myState = State.Open;
            if (myState == State.New)
                Console.WriteLine("La mia var contiene New");
            else
                Console.WriteLine("La mia var contiene Open");

            //Reference Type: STRING. La stringa 
            string nome = "Thomas";
            nome = "JinWoo";
            //In realtà è stata creato un oggetto aggiuntivo e poi eliminato. E' un reference Type 

            Console.Clear();

            //Class
            Persona p = new Persona("Jin-Woo", "Sung", new DateTime(2003, 3, 2) );
            Console.WriteLine(p.ToString());

            Manager m = new Manager("Jhon", "Silver", new DateTime(1984, 03, 04), 1);
            Persona m2= new Manager("Toby", "Stephens", new DateTime(1984, 03, 04), 2);
            Console.WriteLine(m.ToString());
            Console.WriteLine($"Il manager con id: {m.ID} ha stipendio: {m.Stipendio}");

            // Console.WriteLine($"Il manager con id: {m2.ID} ha stipendio: {m2.Stipendio}");
            // Da errore qui perchè non posso richiamre le proprietà di manager di m2 ma solo le propr comuni a persona

            Console.WriteLine($"Prospetto manager con id {m.ID} : {m.ToString()}");

            //Interfaccia
            m.CalcolaCodiceFiscale();
            m2.CalcolaCodiceFiscale();

            IEntita m3 = new Manager("ABC", "BCD", new DateTime(2000, 4, 7), 3);
            //Può rispondere solo alla chiamata del metodo dell'interfaccia
            //m3.Stipendio  ->Errore!
            m3.CalcolaCodiceFiscale();
            //Ma posso calcolare il CF
        }
    }
}
