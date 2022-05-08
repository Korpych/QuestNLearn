using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Construction[] workers = new Construction[4];

            Tiler tiler = new Tiler();
            tiler.Name = "Maksim";

            BrickLayer bricklayer = new BrickLayer();
            bricklayer.Name = "Andrey";

            Plumber plumber = new Plumber();
            plumber.Name = "Sanya";

            Heaver heaver = new Heaver();
            heaver.Name = "Kirill";

            workers[0] = tiler;
            workers[1] = bricklayer;
            workers[2] = plumber;
            workers[3] = heaver;

            for(int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine("Worker {0} does:", workers[i].Name);
                workers[i].GetAction();
            }

            Console.ReadKey();
        }
    }

    class Construction
    {
        public string Name { get; set; }

        public virtual void GetAction() //Спецификатор virtual, который даёт возможность                                       //распределить реализацию метода в наследуемых классах
        {                               //переопределить реализацию метода в дочерних классах
            Console.WriteLine("null");
        }
    }

    class Tiler : Construction
    {
        public override void GetAction() //override - переопределение реалиализации метода
        {
            Console.WriteLine("Lays a tile");
        }
    }

    class BrickLayer : Construction
    {
        public override void GetAction()
        {
            Console.WriteLine("Lays a brick");
        }
    }

    class Plumber : Construction
    {
        public override void GetAction()
        {
            Console.WriteLine("Conducts pipes");
        }
    }

    class Heaver : Construction
    {
        public override void GetAction()
        {
            Console.WriteLine("Unloads material");
        }
    }
}
