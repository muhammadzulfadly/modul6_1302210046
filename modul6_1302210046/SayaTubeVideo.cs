using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210046
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null && title.Length <= 200);
            Contract.Requires(playCount <= 25000000);
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException check)
            {
                Console.WriteLine(check.Message);
            }
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
