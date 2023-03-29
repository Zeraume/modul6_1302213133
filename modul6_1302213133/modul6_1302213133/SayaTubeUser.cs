using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213133
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            Debug.Assert(username != null && username.Length <= 100, "Username tidak boleh melebihi 100 huruf");
            this.username = username;
            var random = new Random();
            this.id = random.Next(0,10);
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
           return uploadedVideos.Count;
        }

        public void AddVideo(SayaTubeVideo videoBaru)
        {
            Debug.Assert(videoBaru.playCount <= 25000000 && videoBaru != null, "Video tidak boleh melebihi play count");
            uploadedVideos.Add(videoBaru);
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine("Username: " + username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + "judul: " + uploadedVideos[i].title);
            }
        }

    }
}
