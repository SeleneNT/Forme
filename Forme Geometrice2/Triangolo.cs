using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme_Geometrice2
{
    class Triangolo : FormaGeometrica
    {

        public double Base { get; set; }
        public double Altezza { get; set; }

        public Triangolo(string nome, double b, double altezza)
        : base(nome)
        {
            Base = b;
            Altezza = altezza;
        }
        public Triangolo() { }

        public override double Area
        {
            get
            {
                return (Base * Altezza) / 2;
            }
        }

        public override string Disegna()
        {
            //return base.Disegna() + $" con altezza: {Altezza} e base: {Base}";
            return base.Disegna() + $"{Nome};{Altezza};{Base}";
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
                    Base = l;

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
            Console.WriteLine($"Base: {Base}");
            Console.ReadLine();

        }



    }
}
