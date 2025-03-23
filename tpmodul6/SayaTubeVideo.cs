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
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Judul video tidak boleh kosong");
            }
            if (title.Length > 100)
            {
                throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter");
            }
            this.title = title;
            this.playCount = 0;
            this.id = rand.Next(10000, 99999);
        }

        public void IncreasePlayCount(int angka)
        {
            if (angka > 10000000)
            {
                throw new ArgumentException("Penambahan play count maksimal 10.000.000");
            }
            try
            {
                checked
                {
                    playCount += angka;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow! Play count tidak dapat melebihi batas integer.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
