﻿using System;
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
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        //checks if player got blackJack
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            //player wins and then ends round
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    Console.WriteLine("Dealer has a BlackJack! Everyone loses!");
                    foreach (KeyValuePair<Player, int> entry in Bets)
                    {
                        Dealer.Balance += entry.Value;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in Player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.isBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                        {
                            player.isActivlyPlaying = true;
                        }
                        else
                        {
                            player.isActivlyPlaying = false;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
            Dealer.stay = TwentyOneRules

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
