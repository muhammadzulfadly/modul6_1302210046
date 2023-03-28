using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210046
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeUser> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            Contract.Requires(Username != null && Username.Length <= 100);
            Contract.Requires(uploadedVideos != null);
            this.Username = username;
            this.uploadedVideos= new List<SayaTubeUser>();
        }

        public int GetTotalVideosPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + Username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Review Film " + uploadedVideos[i]
                    + " oleh " + Username);
            }
        }
    }
}
