using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SayaTubeVideo stb = new SayaTubeVideo("Tutorial Design by Contract - Irfan");
            stb.IncreasePlayCount(9);
            stb.PrintVideoDetails();
        }
    }
}
