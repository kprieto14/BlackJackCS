using System;
using System.Linq;
using System.Collections.Generic;

namespace BlackJackCS
{
  class Program
  {
    static string VictorySpeech(double user, double dealer, double split)
    {
      //Major IF statement for the split hand if used 
      if (split > dealer && split <= 21)
      {
        //Gain money
        Console.WriteLine("Looks like the split paid off! Congrats player! \n");
      }
      else if (split < dealer && dealer <= 21 && split > 0)
      {
        //Lose money
        Console.WriteLine("Don't know if splitting your hand helped. Congrats dealer! \n");
      }
      else if (split == dealer && dealer <= 21)
      {
        //In this scenario, nobody wins. You do not lose any money, but you also do not gain any money
        Console.WriteLine("Looks like nobody wins this time, not even your split hand. \n");
      }
      else if (split > 21)
      {
        //Lose money
         Console.WriteLine("Don't know if splitting your hand helped. Congrats dealer! \n");
      }
      else if (split < dealer && dealer > 21 && split > 0)
      {
        //Gain money
        Console.WriteLine("Looks like the split paid off! Congrats player! \n");
      }

      //Major IF statement for the player's main hand
      if (user > dealer && user <= 21)
      {
        //Gain money
        return "Congrats player! \n";
      }
      else if (user < dealer && dealer <= 21)
      {
        //Lose money
        return "Congrats dealer!\n";
      }
      else if (user == dealer && dealer <= 21)
      {
        //In this scenario, nobody wins. You do not lose any money, but you also do not gain any money
        return "Looks like nobody wins this time. Keep your money. \n";
      }
      else if (user > 21)
      {
        //Lose money
         return "Congrats dealer! \n";
      }
      else if (user < dealer && dealer > 21)
      {
        //Gain money
        return "Congrats player! \n";
      }
      else
      {
        return "Something went wrong, please contact Kristy to fix code. \n";
      }
    }
    static void BlackJack()
    {
      //Creates the deck that assigns a Suit, face, value to each 52 cards. 
      var suit = new List<string>() { "Hearts", "Clubs", "Diamonds", "Spades" };
      var face = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
      var value = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

      var index = 0;

      var deck = new List<Card>();

      foreach (var currentSuit in suit)
      {
          foreach (var currentRank in face)
          {
              var newCard = new Card();
              newCard.Name = $"{currentRank} of {currentSuit}";
              newCard.Suit = currentSuit;
              newCard.Face = currentRank;
              newCard.Value = value[index];
              deck.Add(newCard);
              index++;
          }
      }

      //Establishes loop that will shuffle deck
      for(var rightIndex = deck.Count - 1; rightIndex >=1; rightIndex--) 
      {
        //Establishes the 2nd card to be randomly shuffled from the last card in deck
        var randomNumberGenerator = new Random();
        var leftIndex = randomNumberGenerator.Next(rightIndex);
        //Matches the number index from loop and re-assigns the value with the corresponding value from the "deck" list
        var leftCard = deck[leftIndex];
        var rightCard = deck[rightIndex];
        //Switches the left card with the right card to be shuffled until the loop reaches the last card
        deck[rightIndex] = leftCard;
        deck[leftIndex] = rightCard;
      }

      //Creates new lists to add cards into deck for User, Dealer, and split deck
      var playerHand = new List<Card> ();
      var dealerHand = new List<Card> ();
      var splitHand = new List<Card> ();
      bool playSplitHand = false;

      //Take the first two cards from the deck, copy them into playerHand (deleting the first two cards from the deck afterwards)
      for (var count = 0; count < 2; count ++)
      {
        playerHand.Add(deck[0]);
        deck.RemoveAt(0);
      }
      //Repeat process with dealer
      for (var count = 0; count < 2; count ++)
      {
        dealerHand.Add(deck[0]);
        deck.RemoveAt(0);
      }

      var dealerCard = dealerHand[0];
      Console.WriteLine($"Dealer has a {dealerCard.Name} as one of their cards.");

      //New line of code that will prompt the user if they want to split
      var firstCard = deck[0];
      var secondCard = deck[1];
      if(firstCard.Suit == secondCard.Suit)
      {
        Console.WriteLine($"Looks like you have two cards of the same suit! A {firstCard.Name} and a {secondCard.Name}. Would you like to split your hand? (Enter Y or N)");
        var response = Console.ReadLine();

        if (response.ToUpper() == "Y")
        {
          //Adds first card from hand into splitHand and deletes the same card
          splitHand.Add(playerHand[0]);
          playerHand.Remove(playerHand[0]);

          //Now adds a 2nd card to each hand from the deck, deleting the same card right after
          playerHand.Add(deck[0]);
          deck.RemoveAt(0);
          splitHand.Add(deck[0]);
          deck.RemoveAt(0);
          playSplitHand = true;

          Console.WriteLine("You now have two hands and twice the chance to beat the dealer!");
        }
        else
        {
          Console.WriteLine("No worries, lets continue!");
        }
      }

      //Process that starts the split hand scenario if true
      while (playSplitHand == true)
      {
        //Displays all cards in deck and tells you their total value at the end
        Console.WriteLine("Your split hand currently has: ");

        foreach(var card in splitHand)
        {
          Console.Write($" {card.Name} ");
        }
        
        var newPlayerTotal = splitHand.Select(sum => sum.Value).Sum();
        //Code here to turns an Ace into a 1 if it reaches over a total value of 21
        var activeAces = splitHand.Any(ace => ace.Suit == "Ace" && ace.Value == 11);
        if (newPlayerTotal > 21 && activeAces == true)
        {
          //Goes through the list and turns the first Ace into a 1 if value goes over 21, will change the following Aces if the value keeps going up
          var foundAces = splitHand.FirstOrDefault(ace => ace.Suit == "Ace" && ace.Value == 11);
          foundAces.Value = 1;
          newPlayerTotal = splitHand.Select(sum => sum.Value).Sum();
        }
        Console.WriteLine($"Your total value is {newPlayerTotal}. \n");
       
       //Begins prompting the user if they want to hit or stand and adjusts accordingly 
        if (newPlayerTotal < 21)
        {
          Console.WriteLine("Would you like to \n(H)it \n(S)tand?");
          var response = Console.ReadLine();

          if (response.ToUpper() == "H")
          {
            splitHand.Add(deck[0]);
            deck.RemoveAt(0);
            Console.WriteLine($"You drew a {splitHand[splitHand.Count - 1].Name}.");
          }
          else if(response.ToUpper() == "S")
          {
            Console.WriteLine($"Your total value was {newPlayerTotal}! Let's move on to your other hand.");
            Console.WriteLine();
            playSplitHand = false; 
          }
          else
          {
            Console.WriteLine("I'm sorry, I do not understand. Please try again.");
          }
        }
        //Changes output once total reaches 21 or over
        else if (newPlayerTotal == 21)
        {
          Console.WriteLine("Congrats on the perfect 21! Let's see what your other hand has. \n");
          playSplitHand = false; 
        }
        else if(newPlayerTotal > 21)
        {
          Console.Write("💣💣💣 \nUh oh, looks like a bust! Lets hope your other hand has better luck! \n");
          playSplitHand = false; 
        }
        else
        {
          Console.WriteLine("An error has occurred. Please contact Kristy to fix the code.");
        }
      }

      //Process that starts calculating the player total and asking if they would like to HIT or STAND when under 21.
      bool endTurn = false;
      while (endTurn == false)
      {
        //Displays all cards in deck and tells you their total value at the end
        Console.WriteLine("Your hand currently has: ");

        foreach(var card in playerHand)
        {
          Console.WriteLine($" {card.Name} ");
        }
        
        var newPlayerTotal = playerHand.Select(sum => sum.Value).Sum();
        //Code here to turns an Ace into a 1 if it reaches over a total value of 21, only activates if there is an Ace in the deck
        var activeAces = playerHand.Any(ace => ace.Suit == "Ace" && ace.Value == 11);
        if (newPlayerTotal > 21 && activeAces == true)
        {
          //Goes through the list and turns the first Ace into a 1 if value goes over 21, will change the following Aces if the value keeps going up
          var foundAces = playerHand.FirstOrDefault(ace => ace.Suit == "Ace" && ace.Value == 11);
          foundAces.Value = 1;
          newPlayerTotal = playerHand.Select(sum => sum.Value).Sum();
        } 
        Console.WriteLine($"Your total value is {newPlayerTotal}. \n");
       
       //Begins prompting the user if they want to hit or stand and adjusts accordingly 
        if (newPlayerTotal < 21)
        {
          Console.WriteLine("Would you like to \n(H)it \n(S)tand?");
          var response = Console.ReadLine();

          if (response.ToUpper() == "H")
          {
            playerHand.Add(deck[0]);
            deck.RemoveAt(0);

            Console.WriteLine($"You drew a {playerHand[playerHand.Count - 1].Name} ");
          }
          else if(response.ToUpper() == "S")
          {
            Console.WriteLine($"Your total value was {newPlayerTotal}! Let's see what the dealer has. \n");
            endTurn = true; 
          }
          else
          {
            Console.WriteLine("I'm sorry, I do not understand. Please try again.");
          }
        }
        //Changes output once total reaches 21 or over
        else if (newPlayerTotal == 21)
        {
          Console.WriteLine("Congrats on the perfect 21! Let's see what the dealer has. \n");
          endTurn = true; 
        }
        else if(newPlayerTotal > 21)
        {
          Console.Write("💣💣💣 \n Uh oh, looks like a bust! \n");
          endTurn = true; 
        }
        else
        {
          Console.WriteLine("An error has occurred. Please contact Kristy to fix the code.");
        }
      }

      //Process that starts the dealer's turn and calculates their total.
      bool dealerTurn = true;
      while (dealerTurn == true)
      {
        var newDealerTotal = dealerHand.Select(sum => sum.Value).Sum();
        //Code here to turns an Ace into a 1 if it reaches over a total value of 21
       var activeAces = dealerHand.Any(ace => ace.Suit == "Ace" && ace.Value == 11);
        if (newDealerTotal > 21 && activeAces == true)
        {
          //Goes through the list and turns the first Ace into a 1 if value goes over 21, will change the following Aces if the value keeps going up
          var foundAces = dealerHand.FirstOrDefault(ace => ace.Suit == "Ace" && ace.Value == 11);
          foundAces.Value = 1;
          newDealerTotal = dealerHand.Select(sum => sum.Value).Sum();
        }

        //Code to display all of the dealer's current cards
        Console.WriteLine("The dealer's hand currently has: ");
        foreach(var card in dealerHand)
        {
          Console.WriteLine($" {card.Name} ");
        }

        Console.WriteLine($"The dealer currently has a value of {newDealerTotal}. \n");

        //Code that automatically does the dealer's turn based on certain requirements.
        if (newDealerTotal >= 17 && newDealerTotal < 21)
        {
          Console.WriteLine("Dealer chooses to stand. \n");
          dealerTurn = false;
        }
        else if (newDealerTotal == 21)
        {
          Console.WriteLine("What terrible luck for you. \n");
          dealerTurn = false;
        }
        else if (newDealerTotal > 21)
        {
          Console.Write("💣💣💣 \n Uh oh, looks like a bust for the dealer! \n");
          dealerTurn = false;
        }
        else 
        {
          dealerHand.Add(deck[0]);
          deck.RemoveAt(0);
          Console.WriteLine($"Dealer chooses to hit, adding a {dealerHand[dealerHand.Count - 1].Name} to their hand.");
        }
      }

      //The start of the sum of each hand to compare and gives a victory speech at the end according to whoever won.
      var playerTotal = playerHand.Select(sum => sum.Value).Sum();
      var dealerTotal = dealerHand.Select(sum => sum.Value).Sum();
      var splitHandTotal = splitHand.Select(sum => sum.Value).Sum();

      VictorySpeech(playerTotal, dealerTotal, splitHandTotal);

    }
    static void Main(string[] args)
    {
      Console.WriteLine("\nWelcome to the game of Blackjack! I will be your dealer. Lets shuffle the cards and begin! \n");
    
      BlackJack();

      bool playAgain = true;
      while (playAgain == true)
      {
        //Once game finishes, this is block of code that asks user if they would like to replay and adjusts accordingly.
        Console.WriteLine("Would you like to play again? Enter (Y) to restart or (N) to quit.");
        var response = Console.ReadLine();

        if (response.ToUpper() == "Y")
        {
          BlackJack();
        }
        else if (response.ToUpper() == "N")
        {
          Console.Write("It was fun to play with you! Come back anytime! 😃");
          playAgain = false;
        }
        else 
        {
          Console.WriteLine("I'm sorry, I do not understand 😔 Please Try again.");
        }
      }
    }
  }
}
