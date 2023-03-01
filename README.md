# BlackJackCS
P

Will create a program that replicates a 2-player game of Blackjack (aka 21) using one deck of 52 cards. After shuffling the deck, 
2 cards will be given (from the shuffled deck) to the player and 2 cards (from the same deck) to the "dealer". The player will be able to see their hand, but not be able to see the dealers hand until the end.
Each card will have its own value, which will be added for a total value in each hand. The hand with the highest number without going over 21 is considered to win (a tie makes the dealer win). The player and dealer take turns on whether they want to hit (take another card from the deck) or stand (keep their current hand).
The player will go first in deciding if they want to "hit" or "stand". If player chooses to "hit" and they are still below the value of 21, they may chose to "hit" again or "stand". This process repeats until the player either chooses to stand or receives a card that brings their total over 21, which automatically makes the player lose. 
Whether the player choses to stand or or loses, the dealer's turn begins and reveals their cards. If the dealer has a value under 17, they keep "hit" until their value goes over 17 (unless they go over 21, in which case they lose)
If both the player and dealer tie, the dealer wins. 
The player will be given the option to play again, and if they choose yes then the cards are taken from each hand and re-shuffled to start another round.

E

1. If player one has a 6 of hearts and a 8 of clubs, then hits with a 2 of spades, then stands for a total value of 16. AND if dealer has a 4 of spades and jack of diamonds, 
    then hits with a Queen of Hearts for a total value of 24. the dealer busts and the player wins.
2. If player has a Jack of clubs and a Ace of diamonds, then stands for a total value of 21 (perfect score). AND if dealer has a 6 of clubs and 5 of spades, 
    then hits for a 9 of clubs, then stands for a total value of 20. Then the player wins for having 21. 
3. If player draws a 3 of hearts and 10 of hearts, then draws a 3 of diamonds, then draws a 4 of hearts, then stands for a total value of 20. AND the dealer draws a Queen of diamonds
    and a 6 of clubs and a 5 of spades, then stands for a total value of 21. Then the dealer wins for having 21.
4. If player draws a 4 of diamonds and a Jack of hearts, then hits for a Ace of clubs, then the player automatically busts and the dealer goes. If the dealer draws a 3 of clubs,
    a 5 of diamonds, 4 of spades, and a Jack of diamonds for a total value of 22. Then the dealer also busts but since its a tie then the dealer wins.
5. If the player draws a 6 of clubs and a 5 of spades, then hits for a 9 of clubs and then stands for a total value of 20. AND the dealer draws a 10 of clubs and a 7 of diamonds
    then stands for a total value of 17. The player wins for having a higher value that was not over 21. 
6. If the player draws a Ace of spades and a 7 of Hearts, then stands for a total value of 18. AND the dealer draws a 5 of Diamonds and a 9 of clubs, then draws a 5 of spades
    and stands for a value of 19. Then the dealer wins for having a higher value under 21.

D

Will have classes
    1 class of cards which will have 3 properties
        suit
        face
        value
    1 list/ class which will be deck
    1 list/ class for playerHand
    1 list/ class for dealerHand

Use looping to shuffle deck
Using while statement (endTurn = false)
    { Calculate total of hand
        If value of card is under 21, hit or stand
        if hit, draw card and go back to step one to calculate total and adjust accordingly
        
        If value is over 21, automatically end turn and insert explosive emoji.

        If player stands, end turn and repeat with dealerHand (can turn this into a method where it sends the hand information with values and returns a total value for comparison later?)
    }
While statement to ask player if they would like to play again and loop accordingly (playAgain = true)
Variables to accept player's responses throughout the game
    var response = Console.ReadLine(toUpper(Y or N)); (perhaps can use this method to call an prompt from main method and return the value of response)
Variables to calculate the totals and compare them with IF statements
    double totalPlayerHand
    double totalDealerHand
Switch statement at the end which compares values and returns a dialogue that matches who won based on values.

A

Greeting!

Shuffle deck using looping
    Assign 4 different suits
    Assign 13 ranks to each suit
    Give value to each ranks
        Jacks/ Queens/ Kings = 10
        Aces = 11
        All other numbers will correspond accordingly (ie 2=2, 3=3, 4=4, etc...)

Take the first two cards from the deck, copy them into playerHand (deleting the first two cards from the deck afterwards)
    Repeat process with dealer

while statements (endTurn = false) with playerHand
    { Calculate total of hand
        If value of card is under 21, hit or stand

        If card is automatically 21, end loop

        If hit, draw card from deck (removing the card from the deck) and add into hand go back to step one to calculate total and adjust accordingly
        
        If the value is over 21, automatically end turn and insert explosive emoji.

        If player stands, end turn (can turn this into a method where it sends the hand information with values and returns a total value for comparison later?)
    
        else repeat prompt
    }

while statements (endTurn = false) with dealerHand
    { Calculate total of hand
        If value of card is under 17, hit

        If card is automatically 21, end loop

        If hit, draw card from deck (removing the card from the deck) and add into hand go back to step one to calculate total and adjust accordingly
        
        If the value is over 21, automatically end turn and insert explosive emoji.

        When value is greater than or equal to 17, the dealer stands, ends (can turn this into a method where it sends the hand information with values and returns a total value for comparison later?)
    }

switch statement for different scenarios (dealer really has the upper hand huh)
    A: totalPlayerHand > totalDealerHand && totalPlayerHand <= 21
        Console.WriteLine(Congrats player!);
    B: totalPlayerHand < totalDealerHand && totalDealerHand <= 21 
        Console.WriteLine(Congrats dealer!);
    C: totalPlayerHand == totalDealerHand && totalDealerHand <= 21
        Console.WriteLine(Congrats dealer!);
    D: totalPlayerHand > 21
        Console.WriteLine(Congrats dealer!);
    E: totalPlayerHand < totalDealerHand && totalDealerHand > 21
        Console.WriteLine(Congrats player!);

clear playerHand and dealerHand

While statement (playAgain == true)
{
    Console.Write(Would you like to play again? Y or N)
    if Y, restart code, starting from shuffle deck

    if N, end code

    else repeat prompt 
}
C