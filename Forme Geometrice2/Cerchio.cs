using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme_Geometrice2
{
    class Cerchio : FormaGeometrica
    {
        public int xCentro { get; set; }
        public int yCentro { get; set; }
        public double Raggio { get; set; }
        public Cerchio()
        {

        }
        public Cerchio(string nome, int xcentro, int ycentro, double raggio)
            : base(nome)
        {
            xCentro = xcentro;
            yCentro = ycentro;
            Raggio = raggio;
        }

        public override double Area
        {
            get { 
            return Raggio * Math.PI * 2;
            }
        }

        public override string Disegna()
        {
            //return base.Disegna() + $" con coordinate: {xCentro}, {yCentro} e raggio: {Raggio}";
            return base.Disegna() + $"{Nome};{xCentro};{yCentro};{Raggio}";
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

                    bool resultOk = int.TryParse(values[1], out int x);
                    if (resultOk)
                    {
                        xCentro = x;
                    }

                    int.TryParse(values[2], out int y);
                    yCentro = y;

                    double.TryParse(values[3], out double r);
                    Raggio = r;

                    reader.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.WriteLine("Lettura del File:");
            Console.WriteLine($"Nome figura: {Nome}");
            Console.WriteLine($"Coordinata x: {xCentro}");
            Console.WriteLine($"Coordinata y: {yCentro}");
            Console.WriteLine($"Valore raggio: {Raggio}");
            Console.ReadLine();

        }
    }
}
