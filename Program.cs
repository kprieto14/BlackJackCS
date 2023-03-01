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
    static void Main(string[] args)
    {
      Console.WriteLine();
      Console.WriteLine("Welcome to the game of Blackjack! I will be your dealer. Lets shuffle the cards and begin!");
      Console.WriteLine();
    
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

      //Creates new lists to add cards into deck for PlayerOne and PlayerTwo
      var playerHand = new List<Card> ();
      var dealerHand = new List<Card> ();

      //Take the first two cards from the deck, copy them into playerHand (deleting the first two cards from the deck afterwards)
      for (var count = 0; count < 2; count ++)
      {
        playerHand.Add(deck[0]);
        deck.Remove(deck[0]);
      }
      //Repeat process with dealer
       for (var count = 0; count < 2; count ++)
      {
        dealerHand.Add(deck[0]);
        deck.Remove(deck[0]);
      }

      var firstCard = playerHand[0];
      var secondCard = playerHand[1];

      Console.WriteLine($"You have a {firstCard.Suit} of {firstCard.Face} and a {secondCard.Suit} of {secondCard.Face}.");
   
      //Process that starts calculating the player total and asking if they would like to HIT or STAND when under 21.
      bool endTurn = false;
      while (endTurn == false)
      {
        //Console.WriteLine($"You have the current hand of {playerHand.Select(card => card.Face, card.Suit)}"); Fix this code later to display what cards are in player hands
        var newPlayerTotal = playerHand.Select(sum => sum.Value).Sum();
        Console.WriteLine($"Your total value is {newPlayerTotal}.");
        Console.WriteLine();
       
        if (newPlayerTotal < 21)
        {
          Console.WriteLine("Would you like to HIT or STAND?");
          var response = Console.ReadLine();

          if (response.ToUpper() == "HIT")
          {
            playerHand.Add(deck[0]);
            deck.Remove(deck[0]);

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

      var dealerFirstCard = dealerHand[0];
      var dealerSecondCard = dealerHand[1];
    
      Console.WriteLine($"Dealer has a {dealerFirstCard.Suit} of {dealerFirstCard.Face} and a {dealerSecondCard.Suit} of {dealerSecondCard.Face}.");
      
      //Process that starts the dealer's turn and calculates their total.
      bool dealerTurn = true;
      while (dealerTurn == true)
      {
        var newDealerTotal = dealerHand.Select(sum => sum.Value).Sum();

        Console.WriteLine($"The dealer currently has a value of {newDealerTotal}.");
        Console.WriteLine();
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
          deck.Remove(deck[0]);

          var newCard = dealerHand[dealerHand.Count - 1];
          Console.WriteLine($"Dealer chooses to hit, adding a {newCard.Suit} of {newCard.Face} to their hand.");
        }
      }

      //The start of the sum of each hand to compare and gives a victory speech at the end according to whoever won.
      var playerTotal = playerHand.Select(sum => sum.Value).Sum();
      var dealerTotal = dealerHand.Select(sum => sum.Value).Sum();

      if (playerTotal > dealerTotal && playerTotal <= 21)
      {
        Console.WriteLine("Congrats player!");
      }
      else if (playerTotal < dealerTotal && dealerTotal <= 21)
      {
        Console.WriteLine("Congrats dealer!");
      }
      else if (playerTotal == dealerTotal && dealerTotal <= 21)
      {
        Console.WriteLine("Congrats dealer!");
      }
      else if (playerTotal > 21)
      {
         Console.WriteLine("Congrats dealer!");
      }
      else if (playerTotal < dealerTotal && dealerTotal > 21)
      {
        Console.WriteLine("Congrats player!");
      }
      else
      {
        Console.WriteLine("Something went wrong, please contact Kristy to fix code.");
      }

      /*

      */ 

    }
  }
}
