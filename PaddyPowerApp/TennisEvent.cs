using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddyPowerApp
{
    class TennisEvent
    {
        // instance variables
        public string details;
        public string dateofevent;
        public string hometeam;
        public string awayteam;
        public string outrightWinner;
        public string gamewinner;

        //match result will either be "Home, Away or Draw
        public string matchresult;

        //for correct score, home team goals will be on the left.
        public string correctscore;

        public TennisEvent()
        {
            details = "PP group D match 6";
            dateofevent = "17/03/2018 15:15";
            hometeam = "L Brady";
            awayteam = "C Ryan";
            outrightWinner = "C Ryan";
            gamewinner = "L Brady";


        }
        public void GetResult()
        {
            Console.WriteLine("PP group D match 6 winner: {0}", outrightWinner);
            Console.WriteLine("Set 2 Game 1 winner", gamewinner);
        }
    }
}
