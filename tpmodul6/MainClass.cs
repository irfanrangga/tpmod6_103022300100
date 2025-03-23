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
            try
            {
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Irfan");
                video.PrintVideoDetails();

                try
                {
                    SayaTubeVideo videoError = new SayaTubeVideo(new string('A', 101));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception tertangkap: " + ex.Message);
                }

                try
                {
                    SayaTubeVideo videoNull = new SayaTubeVideo(null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception tertangkap: " + ex.Message);
                }

                try
                {
                    Console.WriteLine("\n--- Menguji Overflow Play Count ---");
                    for (int i = 0; i < 25; i++)
                    {
                        video.IncreasePlayCount(10000000);
                        video.PrintVideoDetails();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception tertangkap saat menambah play count: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error dalam program utama: " + ex.Message);
            }
        }
    }
}
