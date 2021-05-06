using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme_Geometrice2
{
    class Rettangolo : FormaGeometrica
    {
        public double Larghezza { get; set; }
        public double Altezza { get; set; }

        public Rettangolo(string nome, double larghezza, double altezza)
          : base(nome)
        {
            Larghezza = larghezza;
            Altezza = altezza;
        }
        public Rettangolo() { }

        public override double Area
        {
            get
            {
                return Altezza * Larghezza;
            }
        }

        public override string Disegna()
        {
            //return base.Disegna() + $" con altezza: {Altezza} e larghezza: {Larghezza}";
            return base.Disegna() + $"{Nome};{Altezza};{Larghezza}";
        }


        public override void LoadFromFile(string fileName)
        {
            try
            {
                using StreamReader reader = File.OpenText(@"C:\Users\Selene\Desktop\Pagina Web\Watcher\" + fileName);
                {
                    Console.WriteLine($"---Lettura di {fileName}--- ");
                    string istanceData = reader.ReadLine().Split(":")[1];
                    string[] values = istanceData.Split(";");

                    Nome = values[0];

                    double.TryParse(values[1], out double h);
                    Altezza = h;

                    double.TryParse(values[2], out double l);
                    Larghezza = l;

                    reader.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.WriteLine("Lettura del File:");
            Console.WriteLine($"Nome figura: {Nome}");
            Console.WriteLine($"Altezza: {Altezza}");
            Console.WriteLine($"Larghezza: {Larghezza}");
            Console.ReadLine();

        }

    }
}
