using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210046
{
    internal class SayaTubeVideo
    {
        private int id;
        public string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id + "\nTitle: " +
                title + "\nplayCount: " + playCount);
        }
    }
}
