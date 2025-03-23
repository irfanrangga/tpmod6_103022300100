using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random rand = new Random();

        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.playCount = 0;
            this.id = rand.Next(10000, 99999);
        }

        public void IncreasePlayCount(int angka)
        {
            playCount += angka;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
