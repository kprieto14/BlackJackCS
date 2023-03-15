using System;
using System.Linq;
using System.Collections.Generic;

namespace BlackJackCS
{
  class Card 
    {
      public string Face {get; set;}
      public string Suit {get; set;}
      public int Value {get; set;}
    }
  class Program
  {
    static string VictorySpeech(double user, double dealer, double split)
    {
      var playerTotal = user;
      var dealerTotal = dealer;
      var splitTotal = split;

      //Major IF statement for the split hand if used 
      if (splitTotal > dealerTotal && splitTotal <= 21)
      {
        //Gain money
        Console.WriteLine("Looks like the split paid off! Congrats player!");
        Console.WriteLine();
      }
      else if (splitTotal < dealerTotal && dealerTotal <= 21 && splitTotal > 0)
      {
        //Lose money
        Console.WriteLine("Don't know if splitting your hand helped. Congrats dealer!");
        Console.WriteLine();
      }
      else if (splitTotal == dealerTotal && dealerTotal <= 21)
      {
        //In this scenario, nobody wins. You do not lose any money, but you also do not gain any money
        Console.WriteLine("Looks like nobody wins this time, not even your split hand.");
        Console.WriteLine();
      }
      else if (splitTotal > 21)
      {
        //Lose money
         Console.WriteLine("Don't know if splitting your hand helped. Congrats dealer!");
         Console.WriteLine();
      }
      else if (splitTotal < dealerTotal && dealerTotal > 21 && splitTotal > 0)
      {
        //Gain money
        Console.WriteLine("Looks like the split paid off! Congrats player!");
        Console.WriteLine();
      }

      //Major IF statement for the player's main hand
      if (playerTotal > dealerTotal && playerTotal <= 21)
      {
        //Gain money
        Console.WriteLine("Congrats player!");
        Console.WriteLine();
        return null;
      }
      else if (playerTotal < dealerTotal && dealerTotal <= 21)
      {
        //Lose money
        Console.WriteLine("Congrats dealer!");
        Console.WriteLine();
        return null;
      }
      else if (playerTotal == dealerTotal && dealerTotal <= 21)
      {
        //In this scenario, nobody wins. You do not lose any money, but you also do not gain any money
        Console.WriteLine("Looks like nobody wins this time. Keep your money.");
        Console.WriteLine();
        return null;
      }
      else if (playerTotal > 21)
      {
        //Lose money
         Console.WriteLine("Congrats dealer!");
         Console.WriteLine();
         return null;
      }
      else if (playerTotal < dealerTotal && dealerTotal > 21)
      {
        //Gain money
        Console.WriteLine("Congrats player!");
        Console.WriteLine();
        return null;
      }
      else
      {
        Console.WriteLine("Something went wrong, please contact Kristy to fix code.");
        Console.WriteLine();
        return null;
      }
    }
    static void BlackJack()
    {
      //Creates the deck that assigns a Suit, face, value to each 52 cards. 
      var deck = new List<Card>()
      {
        new Card()
          {
            Face = "Clubs",
            Suit = "Ace",
            Value = 11
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "2",
            Value = 2
          }, 

        new Card()
         {
           Face = "Clubs",
            Suit = "3",
            Value = 3
          },

        new Card()
         {
           Face = "Clubs",
           Suit = "4",
           Value = 4
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "5",
            Value = 5
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "6",
            Value = 6
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "7",
            Value = 7
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "8",
            Value = 8
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "9",
            Value = 9
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "10",
            Value = 10
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "Jack",
            Value = 10
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "Queen",
            Value = 10
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "King",
            Value = 10
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "Ace",
            Value = 11
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "2",
            Value = 2
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "3",
            Value = 3
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "4",
            Value = 4
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "5",
            Value = 5
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "6",
            Value = 6
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "7",
            Value = 7
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "8",
            Value = 8
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "9",
            Value = 9
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "10",
            Value = 10
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "Jack",
            Value = 10
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "Queen",
            Value = 10
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "King",
            Value = 10
          },

        new Card()
          {
            Face = "Hearts",
            Suit = "Ace",
            Value = 11
          },

        new Card()
          {
            Face = "Hearts",
            Suit = "2",
            Value = 2
          },

        new Card()
          {
            Face = "Hearts",
            Suit = "3",
            Value = 3
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "4",
            Value = 4
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "5",
            Value = 5
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "6",
            Value = 6
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "7",
            Value = 7
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "8",
            Value = 8
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "9",
            Value = 9
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "10",
            Value = 10
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "Jack",
            Value = 10
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "Queen",
            Value = 10
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "King",
            Value =10
          },
        
        new Card()
          {
            Face = "Spades",
            Suit = "Ace",
            Value = 11
          },

        new Card()
          {
            Face = "Spades",
            Suit = "2",
            Value = 2
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "3",
            Value = 3
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "4",
            Value = 4
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "5",
            Value = 5
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "6",
            Value = 6
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "7",
            Value = 7
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "8",
            Value = 8
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "9",
            Value = 9
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "10",
            Value = 10
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "Jack",
            Value = 10
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "Queen",
            Value = 10
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "King",
            Value = 10
          }, 
         
                            
      };

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
      Console.WriteLine($"Dealer has a {dealerCard.Suit} of {dealerCard.Face} as one of their cards.");

      //New line of code that will prompt the user if they want to split
      var firstCard = deck[0];
      var secondCard = deck[1];
      if(firstCard.Suit == secondCard.Suit)
      {
        Console.WriteLine($"Looks like you have two cards of the same suit! A {firstCard.Suit} of {firstCard.Face} and a {secondCard.Suit} of {secondCard.Face}. Would you like to split your hand? (Enter YES or NO)");
        var response = Console.ReadLine();

        if (response.ToUpper() == "YES")
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
        Console.Write("Your split hand currently has the");
        for(var count = 0; count <= splitHand.Count() - 1; count ++)
        {
          var currentHand = splitHand[count];

          //LOOK INTO JOIN FUNCTION ON STRINGS
          if (count < splitHand.Count() -1)
          {
          Console.Write($" {currentHand.Suit} of {currentHand.Face},");
          }
          else if (count == splitHand.Count() -1)
          {
            Console.Write($" and {currentHand.Suit} of {currentHand.Face}");
          }
        }
        Console.WriteLine(" in your hand.");
        
        var newPlayerTotal = splitHand.Select(sum => sum.Value).Sum();
        //Code here to turns an Ace into a 1 if it reaches over a total value of 21
       var activeAces = splitHand.Any(ace => ace.Suit == "Ace");
        if (newPlayerTotal > 21 && activeAces == true)
        {
          //Goes through the list and turns the first Ace into a 1 if value goes over 21, will change the following Aces if the value keeps going up
          var foundAces = splitHand.FirstOrDefault(ace => ace.Suit == "Ace" && ace.Value == 11);
          foundAces.Value = 1;
          newPlayerTotal = splitHand.Select(sum => sum.Value).Sum();
        }
        Console.WriteLine($"Your total value is {newPlayerTotal}.");
        Console.WriteLine();
       
       //Begins prompting the user if they want to hit or stand and adjusts accordingly 
        if (newPlayerTotal < 21)
        {
          Console.WriteLine("Would you like to HIT or STAND?");
          var response = Console.ReadLine();

          if (response.ToUpper() == "HIT")
          {
            splitHand.Add(deck[0]);
            deck.RemoveAt(0);

            var newCard = splitHand[splitHand.Count - 1];
            Console.WriteLine($"You drew a {newCard.Face} of {newCard.Suit}.");
          }
          else if(response.ToUpper() == "STAND")
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
          Console.WriteLine("Congrats on the perfect 21! Let's see what your other hand has.");
          Console.WriteLine();
          playSplitHand = false; 
        }
        else if(newPlayerTotal > 21)
        {
          Console.Write("💣💣💣");
          Console.WriteLine(" Uh oh, looks like a bust! Lets hope your other hand has better luck!");
          Console.WriteLine();
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
        Console.Write("You currently have the");
        for(var count = 0; count <= playerHand.Count() - 1; count ++)
        {
          var currentHand = playerHand[count];

          if (count < playerHand.Count() -1)
          {
          Console.Write($" {currentHand.Suit} of {currentHand.Face},");
          }
          else if (count == playerHand.Count() -1)
          {
            Console.Write($" and {currentHand.Suit} of {currentHand.Face}");
          }
        }
        Console.WriteLine(" in your hand.");
        
        var newPlayerTotal = playerHand.Select(sum => sum.Value).Sum();
        //Code here to turns an Ace into a 1 if it reaches over a total value of 21, only activates if there is an Ace in the deck
        var activeAces = playerHand.Any(ace => ace.Suit == "Ace");
        if (newPlayerTotal > 21 && activeAces == true)
        {
          //Goes through the list and turns the first Ace into a 1 if value goes over 21, will change the following Aces if the value keeps going up
          var foundAces = playerHand.FirstOrDefault(ace => ace.Suit == "Ace" && ace.Value == 11);
          foundAces.Value = 1;
          newPlayerTotal = playerHand.Select(sum => sum.Value).Sum();
        } 
        Console.WriteLine($"Your total value is {newPlayerTotal}.");
        Console.WriteLine();
       
       //Begins prompting the user if they want to hit or stand and adjusts accordingly 
        if (newPlayerTotal < 21)
        {
          Console.WriteLine("Would you like to HIT or STAND?");
          var response = Console.ReadLine();

          if (response.ToUpper() == "HIT")
          {
            playerHand.Add(deck[0]);
            deck.RemoveAt(0);

            var newCard = playerHand[playerHand.Count - 1];
            Console.WriteLine($"You drew a {newCard.Face} of {newCard.Suit}.");
          }
          else if(response.ToUpper() == "STAND")
          {
            Console.WriteLine($"Your total value was {newPlayerTotal}! Let's see what the dealer has.");
            Console.WriteLine();
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
          Console.WriteLine("Congrats on the perfect 21! Let's see what the dealer has.");
          Console.WriteLine();
          endTurn = true; 
        }
        else if(newPlayerTotal > 21)
        {
          Console.Write("💣💣💣");
          Console.WriteLine(" Uh oh, looks like a bust!");
          Console.WriteLine();
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

        //Code to display all of the dealer's current cards
        Console.Write("The dealer currently has the");
        for(var count = 0; count <= dealerHand.Count() - 1; count ++)
        {
          var currentHand = dealerHand[count];

          if (count < dealerHand.Count() -1)
          {
          Console.Write($" {currentHand.Suit} of {currentHand.Face},");
          }
          else if (count == dealerHand.Count() -1)
          {
            Console.Write($" and {currentHand.Suit} of {currentHand.Face}");
          }
        }
        Console.WriteLine(" in their hand.");

        Console.WriteLine($"The dealer currently has a value of {newDealerTotal}.");
        Console.WriteLine();

        //Code that automatically does the dealer's turn based on certain requirements.
        if (newDealerTotal >= 17 && newDealerTotal < 21)
        {
          Console.WriteLine("Dealer chooses to stand.");
          Console.WriteLine();
          dealerTurn = false;
        }
        else if (newDealerTotal == 21)
        {
          Console.WriteLine("What terrible luck for you.");
          Console.WriteLine();
          dealerTurn = false;
        }
        else if (newDealerTotal > 21)
        {
          Console.Write("💣💣💣");
          Console.WriteLine(" Uh oh, looks like a bust for the dealer!");
          Console.WriteLine();
          dealerTurn = false;
        }
        else 
        {
          dealerHand.Add(deck[0]);
          deck.RemoveAt(0);

          var newCard = dealerHand[dealerHand.Count - 1];
          Console.WriteLine($"Dealer chooses to hit, adding a {newCard.Suit} of {newCard.Face} to their hand.");
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
      Console.WriteLine();
      Console.WriteLine("Welcome to the game of Blackjack! I will be your dealer. Lets shuffle the cards and begin!");
      Console.WriteLine();
    
      BlackJack();

      bool playAgain = true;
      while (playAgain == true)
      {
        //Once game finishes, this is block of code that asks user if they would like to replay and adjusts accordingly.
        Console.WriteLine("Would you like to play again? Enter YES to restart or NO to quit.");
        var response = Console.ReadLine();

        if (response.ToUpper() == "YES")
        {
          BlackJack();
        }
        else if (response.ToUpper() == "NO")
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
