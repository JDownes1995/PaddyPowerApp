using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddyPowerApp
{
    public class FootballMatchEvent
    {

        // instance variables
        public string details;
        public string dateofevent;
        public string hometeam;
        public string awayteam;
        public int homegoals;
        public int awaygoals;

        //match result will either be "Home, Away or Draw
        public string matchresult;

        //for correct score, home team goals will be on the left.
        public string correctscore;

        public FootballMatchEvent()
        {
            details = "Paddy Power Cup 2019";
            dateofevent = "01/06/2020 14:00";
            hometeam = "Clonskeagh";
            awayteam = "Tallaght";
            homegoals = 2;
            awaygoals = 1;
            correctscore = (homegoals + "-" + awaygoals);

            if (homegoals > awaygoals)
            {
                matchresult = "Home";
            }
            else if (homegoals == awaygoals)
            {
                matchresult = "Draw";
            }
            else if (homegoals < awaygoals)
            {
                matchresult = "Away";
            }

        }

        public void GetResult()
        {
            Console.WriteLine("Result of Football Match : {0}", matchresult);
            Console.WriteLine("Correct Score : {0} {1} {2}", hometeam, correctscore, awayteam);
        }
}
}
