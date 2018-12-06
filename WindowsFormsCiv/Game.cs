using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCiv
{
    class Game
    {
        public int Year { get; set; }
        public int Territory { get; set; }
        public int Population { get; set; }
        public int Army { get; set; }
        public int Education { get; set; }
        public int Religion { get; set; }
        public int HappinessLvl { get; set; }
        public int Gold { get; set; }
        public int Corn { get; set; }
        public int Stone { get; set; }
        public int MinCountArmy { get; set; }
        public int MaxCountArmy { get; set; }
        public int MinCountWarrios { get; set; }
        public int MaxCountWarrios { get; set; }
        public int School { get; set; }
        public int Church { get; set; }
        public int Bar { get; set; }
        public int CapturedTerritories { get; set; }
        public int MaxCaptured { get; set; }
        public int MinCaptured { get; set; }
        public int MoveCount { get; set; }


        public Game()
        {
            Year = 1000;
            Territory = 100;
            Population = 500000;
            Army = 10000;
            Education = 0;
            Religion = 0;
            HappinessLvl = 50;
            Gold = 1000;
            Corn = 5000;
            Stone = 6000;
            MinCountArmy = 0;
            MaxCountArmy = 500;
            MinCountWarrios = 100;
            MaxCountWarrios = Army;
            School = 0;
            Church = 0;
            Bar = 0;
            CapturedTerritories = 0;
            MinCaptured = 100;
            MaxCaptured = Territory - 100;
            MoveCount = 0;
        }
    }
}
