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
            this.title = title;
            var random = new Random();
            id = random.Next(0,100);
            this.playCount= id;
        }

        public void increasePlayCount(int playCount)
        {
            playCount++;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("playCount: " + playCount);
        }
    }
}
