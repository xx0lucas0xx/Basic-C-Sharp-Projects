using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                //giving players fresh hand
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            //giving dealer fresh hand
            Dealer.Hand = new List<Card>();
            Dealer.stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                //passing in the amount they bet
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                //adds player to Bets dictionary
                Bets[player] = bet;
            }


        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
