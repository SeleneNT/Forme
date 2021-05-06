using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme_Geometrice2
{
    public class FormaGeometrica : IFileSerializable
    {
        public string Nome { get; set; }

        public FormaGeometrica(string nome)
        {
            Nome = nome;
        }

        public FormaGeometrica() { }
        
        public virtual double Area
        {
            get
            {
                return 0;
            }
        }

        public virtual string Disegna()
        {
            return $"Valori: ";
        }


        public virtual void SaveToFile(string fileName)
        {
            using StreamWriter writer = File.CreateText(@"C:\Users\Selene\Desktop\Pagina Web\Watcher\" + fileName);
            {
                writer.WriteLine(Disegna());
                writer.Close();
            }

            Console.WriteLine($"Salvataggio di {Nome} completato su file: {fileName}");
            Console.ReadLine();
        }

        public virtual void LoadFromFile(string fileName)
        {
            Console.WriteLine($"Caricamento di {Nome} completato da file: {fileName}");
        }
    }
}
