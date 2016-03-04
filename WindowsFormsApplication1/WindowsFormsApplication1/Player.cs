using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Game
    {
        public static Boolean firstLvl = true,
                              umiUsed = false;
        public static string name, 
            rang = "Abiturient";
        public static int lvl = 0, 
            xp = 0, 
            intel = 0, 
            str = 0, 
            agil = 0, 
            shpori = 5, 
            charge = 100, 
            ap = 0, 
            rage = 0, 
            stats = 0;
        public Game(string name1)
        {
            name = name1;
        }
    }
}
