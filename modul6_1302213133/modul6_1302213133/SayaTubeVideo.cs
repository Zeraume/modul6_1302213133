using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213133
{
    internal class SayaTubeVideo
    {
        public int id;
        public string title;
        public int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 200, "Judul video tidak boleh melebihi 200 huruf");
            this.title = title;
            var random = new Random();
            id = random.Next(0,100);
            this.playCount= id;
        }

        public void increasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000, "Input penambahan play count maksimal 25000000");
            try
            {
                this.playCount = checked(this.playCount + playCount);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow Exception" + ex.Message);
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("playCount: " + playCount);
        }
    }
}
