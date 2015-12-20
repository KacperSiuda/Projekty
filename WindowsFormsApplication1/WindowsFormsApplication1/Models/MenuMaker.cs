using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class MenuMaker
    {
        public Random Radomizer;

        public string[] Meats = { "Pieczona wołowina ", "Szynka ", " Salami ", "Indyk ", "Karkówka " };
        public string[] Condiments =
        {
            "żółta musztarda ","brązowa musztarda ","musztarda miodowa ",
            "majonez ","przyprawa ","sos francuski "

        };

        public string[] Breads =
        {
            "chleb ryżowy ","chleb biały ", "chleb zbożowy ",
            "pumpernikiel ","chleb włoski ","bułka "
        };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Radomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Radomizer.Next(Condiments.Length)];
            string randomBread = Breads[Radomizer.Next(Breads.Length)];

            return randomMeat+"," + randomCondiments+"," + randomBread;
        }
    }
}
