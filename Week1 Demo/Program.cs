using System;
using System.Collections;
using Week1_Demo.Classi;

namespace Week1_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funzionalita.EsercizioTipo();
            
            Persona p = new Persona("Mario", "Rossi", new DateTime(2000, 11, 1));
            Console.WriteLine(p.CalcolaCodiceFiscale());
            Console.ReadLine();
        }
    }
}
