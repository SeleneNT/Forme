using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Forme_Geometrice2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FormaGeometrica> Figure = new List<FormaGeometrica>();
            
            Cerchio c = new Cerchio("ACerchio", 13, 12, 14.2);
            Triangolo t = new Triangolo("ATriangolo", 13, 17);
            Rettangolo r = new Rettangolo("ARettangolo", 11, 19);
            Cerchio c1 = new Cerchio("Cerchio", 3, 2, 4.2);
            Triangolo t1 = new Triangolo("Triangolo", 3, 7);
            Rettangolo r1 = new Rettangolo("AARettangolo", 1, 9);
            Cerchio c2 = new Cerchio("Cerchio", 3, 2, 11.2);
            Triangolo t2 = new Triangolo("Triangolo", 1, 17);
            Rettangolo r2 = new Rettangolo("Rettangolo", 11, 9);
            Cerchio c3 = new Cerchio("Cerchio", 31, 12, 14.2);

            Figure.Add(c);
            Figure.Add(t);
            Figure.Add(r);
            Figure.Add(c1);
            Figure.Add(t1);
            Figure.Add(r1);
            Figure.Add(c2);
            Figure.Add(t2);
            Figure.Add(r2);
            Figure.Add(c3);

            //Query LINQ TUTTE le Figure A>=20
            //Lambda
            var Area20 = Figure.Where(area => area.Area >= 20);

            Console.WriteLine("Area20 con lambda");
            foreach (FormaGeometrica f in Area20)
            {
                Console.WriteLine($"La figura {f.Nome} ha area {f.Area}");
            }


            Console.WriteLine("------------------------");

            //FA
            var Area20FA =
                from aree in Figure
                where aree.Area >= 20
                select aree;

            Console.WriteLine("Area20 con fluent API");
            foreach (FormaGeometrica f in Area20FA)
            {
                Console.WriteLine($"La figura {f.Nome} ha area {f.Area}");
            }
            Console.WriteLine("------------------------");

            //Query LINQ TUTTE le Figure Nome inizia per A
            //Lambda
            var A_Shape = Figure.Where(nomi => nomi.Nome.StartsWith("A"));

            Console.WriteLine("A_Shape con lambda");
            foreach (FormaGeometrica f in A_Shape)
            {
                Console.WriteLine($"La figura {f.Nome} inizia per A");
            }

            Console.WriteLine("------------------------");

            //FA
            var A_ShapeFA =
                from nomi in Figure
                where nomi.Nome.StartsWith("A")
                select nomi;

            Console.WriteLine("A_Shape con fluent API");
            foreach (FormaGeometrica f in A_ShapeFA)
            {
                Console.WriteLine($"La figura {f.Nome} inizia per A");
            }

            Console.WriteLine("------------------------");
            
            //Query LINQ TUTTI i nomi delle Figure 
            //Lambda
            var ShapeName = Figure.Select(nomi => new { nomi.Nome });

            Console.WriteLine("ShapeName con lambda");
            foreach (var f in ShapeName)
            {
                Console.WriteLine($"I nomi delle figure sono: {f.Nome}");
            }

            Console.WriteLine("------------------------");

            //FA
            var ShapeNameFA =
                from nomi in Figure
                select new { nomi.Nome };

            Console.WriteLine("ShapeName con fluent API");
            foreach (var f in ShapeNameFA)
            {
                Console.WriteLine($"I nomi delle figure sono: {f.Nome}");
            }

            Console.WriteLine("------------------------");

            //Query LINQ TUTTI i nomi delle Figure in ordine Alfabetico e poi A descendind
            //Lambda
            var selezione = Figure
                .OrderBy(s=>s.Nome)
                .ThenByDescending(s => s.Area);

            Console.WriteLine("selezione con lambda");
            foreach (var f in selezione)
            {
                Console.WriteLine($"Nome: {f.Nome} - Area: {f.Area}");
            }

            Console.WriteLine("------------------------");

            //FA
            var selezioneFA =
                from s in Figure
                orderby s.Nome
                orderby s.Area descending
                select s;

            Console.WriteLine("selezione con fluent API");
            foreach (var f in selezioneFA)
            {
                Console.WriteLine($"Nome: {f.Nome} - Area: {f.Area}");
            }

            Console.WriteLine("------------------------");

            











            /*  
        //SALVATAGGII
            c.SaveToFile(c.Nome + ".txt");
            //LETTURA
            Cerchio cLoaded = new Cerchio();
            cLoaded.LoadFromFile("Cerchio.txt");

            t.SaveToFile(t.Nome + ".txt");
            Triangolo tLoaded = new Triangolo();
            tLoaded.LoadFromFile("Triangolo.txt");

            r.SaveToFile(r.Nome + ".txt");
            Rettangolo rLoaded = new Rettangolo();
            rLoaded.LoadFromFile("Rettangolo.txt");

            foreach (FormaGeometrica f in Figure)
            {
                Console.WriteLine($"L'area del {f.Nome} è: {f.CalcolaArea()}");
                Console.WriteLine(f.Disegna());
            }

            IFileSerializable cInterface = new Cerchio("Cerchio", 3, 2, 4);
            IFileSerializable rInterface = new Rettangolo("Rettangolo", 1, 9);
            IFileSerializable tInterface = new Triangolo("Triangolo", 3, 7);
            */
            //cInterface.SaveToFile("cerchio.txt");
            //cInterface.LoadFromFile("salvataggio.txt");

            //tInterface.SaveToFile("triangolo.txt");
            //tInterface.LoadFromFile("salvataggio.txt");

            //rInterface.SaveToFile("rettangolo.txt");
            //rInterface.LoadFromFile("salvataggio.txt");

            Console.ReadLine();
        }
    }
}
