using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser stu = new SayaTubeUser("Zulfadly");
            SayaTubeVideo stv = new SayaTubeVideo("Video");

            stu.PrintAllVideoPlayCount();
        }
    }
}
