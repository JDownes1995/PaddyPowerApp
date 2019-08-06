using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddyPowerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            FootballMatchEvent footballmatch = new FootballMatchEvent();
            
            
            string cs = footballmatch.correctscore;
            double csCustWinnings = 0;
            double csCustLosses = 0;
            string footballresult = footballmatch.matchresult;
            double footballresultCustWinnings = 0;
            double footballresultCustLosses = 0;

            TennisEvent tennismatch = new TennisEvent();
            string tennisOutrightResult = tennismatch.outrightWinner;
            double tennisOutrightCustWinnings = 0;
            double tennisOutrightCustLosses = 0;
            string tennisGameResult = tennismatch.outrightWinner;
            double tennisGameCustWinnings = 0;
            double tennisGameCustLosses = 0;

            tennisOutrightBets(tennisOutrightResult, ref tennisOutrightCustWinnings, ref tennisOutrightCustLosses);
            tennisGameBets(tennisGameResult, ref tennisGameCustWinnings, ref tennisGameCustLosses);

            footballmatch.GetResult();
            Correctscorebets(cs, ref csCustWinnings, ref csCustLosses);
            Footballresultbets(footballresult, ref footballresultCustWinnings, ref footballresultCustLosses);
            Console.WriteLine("Customer winnings on correct score bets: " + csCustWinnings);
            Console.WriteLine("Customer losses on correct score bets: " + csCustLosses);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Customer winnings on outright Football Result bets: " + footballresultCustWinnings);
            Console.WriteLine("Customer losses on outright Football Result bets: " + footballresultCustLosses);
            Console.WriteLine();
            Console.WriteLine();
            


            


            Console.WriteLine("Customer winnings on outright Tennis Result bets: " + tennisOutrightCustWinnings);
            Console.WriteLine("Customer losses on outright Tennis Result bets: " + tennisOutrightCustLosses);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Customer winnings on Tennis game Result bets: " + tennisGameCustWinnings);
            Console.WriteLine("Customer losses on Tennis game Result bets: " + tennisGameCustLosses);

            double totalcustwinnings = csCustWinnings + footballresultCustWinnings + tennisOutrightCustWinnings + tennisGameCustWinnings;
            double totalcustlosses = csCustLosses + footballresultCustLosses + tennisOutrightCustLosses + tennisGameCustLosses;
            double paddypowerprofits = totalcustlosses = totalcustwinnings;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PaddyPower's Profits: " + paddypowerprofits);

            Console.ReadLine();

            

        }

        private static void Correctscorebets(string cs, ref double csCustWinnings, ref double csCustLosses)
        {
            IList<double> myStakes = new List<double>();
            IList<string> bet = new List<string>();
            //odds changed to decimal format
            IList<double> odds = new List<double>();

            myStakes.Add(2);
            bet.Add("3-1");
            odds.Add(255.00);
            myStakes.Add(1);
            bet.Add("0-1");
            odds.Add(12.00);
            myStakes.Add(2);
            bet.Add("3-1");
            odds.Add(255.00);
            myStakes.Add(1);
            bet.Add("1-2");
            odds.Add(17.00);
            myStakes.Add(10);
            bet.Add("2-0");
            odds.Add(5.50);
            myStakes.Add(2);
            bet.Add("2-0");
            odds.Add(5.50);
            myStakes.Add(11);
            bet.Add("0-1");
            odds.Add(12.00);


            for (int i = 0; i < myStakes.Count; i++)
            {

                
                if (bet[i] == cs)
                {
                    csCustWinnings += (myStakes[i] * odds[i]);
                }
                else
                {
                    csCustLosses += myStakes[i];
                }
                
            }

        }

        private static void Footballresultbets(string footballresult, ref double footballresultCustWinnings, ref double footballresultCustLosses)
        {
            IList<double> myStakes = new List<double>();
            IList<string> bet = new List<string>();
            //odds changed to decimal format
            IList<double> odds = new List<double>();

            
            //Clonskeagh are the selected home side for this tie so that means Tallaght are away.
            myStakes.Add(4);
            bet.Add("Home");
            odds.Add(2.75);
            myStakes.Add(4);
            bet.Add("Draw");
            odds.Add(0.67);
            myStakes.Add(2);
            bet.Add("Home");
            odds.Add(2.75);
            myStakes.Add(1);
            bet.Add("Away");
            odds.Add(2.6);
            myStakes.Add(1);
            bet.Add("Away");
            odds.Add(2.6);

            for (int i = 0; i < myStakes.Count; i++)
            {

                if (bet[i] == footballresult)
                {
                    footballresultCustWinnings += (myStakes[i] * odds[i]);
                }
                else
                {
                    footballresultCustLosses += myStakes[i];
                }
            }

        }

        private static void tennisOutrightBets(string tennisOutrightResult, ref double tennisOutrightCustWinnings, ref double tennisOutrightCustLosses)
        {
            IList<double> myStakes = new List<double>();
            IList<string> bet = new List<string>();
            //odds changed to decimal format
            IList<double> odds = new List<double>();


            //Clonskeagh are the selected home side for this tie so that means Tallaght are away.
            myStakes.Add(5);
            bet.Add("C Ryan");
            odds.Add(0.3);
            myStakes.Add(6);
            bet.Add("C Ryan");
            odds.Add(0.3);
            myStakes.Add(0.5);
            bet.Add("L Brady");
            odds.Add(2.25);

            for (int i = 0; i < myStakes.Count; i++)
            {

                if (bet[i] == tennisOutrightResult)
                {
                    tennisOutrightCustWinnings += (myStakes[i] * odds[i]);
                }
                else
                {
                    tennisOutrightCustLosses += myStakes[i];
                }
            }

        }

        private static void tennisGameBets(string tennisGameResult, ref double tennisGameCustWinnings, ref double tennisGameCustLosses)
        {
            IList<double> myStakes = new List<double>();
            IList<string> bet = new List<string>();
            //odds changed to decimal format
            IList<double> odds = new List<double>();
            
            myStakes.Add(5);
            bet.Add("C Ryan");
            odds.Add(1.25);
            myStakes.Add(5);
            bet.Add("L Brady");
            odds.Add(0.5714);
            myStakes.Add(1);
            bet.Add("L Brady");
            odds.Add(0.5714);

            for (int i = 0; i < myStakes.Count; i++)
            {

                if (bet[i] == tennisGameResult)
                {
                    tennisGameCustWinnings += (myStakes[i] * odds[i]);
                }
                else
                {
                    tennisGameCustLosses += myStakes[i];
                }
            }

        }


    }
}
