using System;
using System.ComponentModel;

namespace MVVM
{
    public class Model
    {
        public Model()
        {
        }

        public string Name()
        {
            //Console.WriteLine("are you ready ? \n");
            //Console.WriteLine("spin the drum or press Enter");
            //Console.ReadLine();
            //var name = Rand();
            return "Guru";
        }

        public int Age()
        {
            //Console.WriteLine("are you ready ? \n");
            //Console.WriteLine("spin the drum or press Enter");
            //Console.ReadLine();
            //var name = Rand();
            return 111;
        }

        //public int Rand()
        //{
        //    Random random = new Random();
        //    return random.Next(0, 10);
        //}
    }
}
