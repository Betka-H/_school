/*
"jdu hrat jackblack" - 23/11/7

ACEs are worth 1 or 11 (player's choice), FACEs 10 and other CARDs normal

1-8 standard DECKs shuffled

all PLAYERs place their BETs in CHIPs
all PLAYERs get a CARD FACE-UP
DEALER gets a CARD FACE-UP
all PLAYERs get a CARD FACE-UP
DEALER gets a CARD FACE-DOWN

if the PLAYER's cards are both the same, they can split them up into 2 HANDS. they must then place a second bet of the same amount on the other hand. if they are both ACEs, the PLAYER gets 2 CARDs and cannot DRAW again. if they get a TEN-CARD, the PAYOFF is equal to the BET
if the DEALER's FACE-UP CARD is an ACE or a TEN-CARD, they check their FACE-DOWN CARD if they have a BLACKJACK, otherwise continues as normal

if the PLAYER's CARD is an ACE and a TEN-CARD, its a BLACKJACK
if any PLAYER has a BLACKJACK and the DEALER does not, the PLAYERs get 1.5x their BET (PAYOFF)
if the DEALER has a BLACKJACK, they COLLECT all PLAYER's BETs, except for those who also had a BLACKJACK
if both the DEALER and a PLAYER have BLACKJACKs, the player takes back his CHIPs

on their TURN, a PLAYER can
STAND (do not DRAW)
HIT (DRAW)
go BUST (have over 21 POINTS) (the PLAYER LOSES and the DEALER COLLECTs their BET)





ACEs are worth 1 or 11 (player's choice), FACEs 10 and other CARDs normal

1-8 standard DECKs shuffled

all PLAYERs TAKE a CARD FACE-UP
DEALER TAKES a CARD FACE-UP
all PLAYERs TAKE a CARD FACE-UP
DEALER TAKES a CARD FACE-DOWN

if the DEALER's FACE-UP CARD is an ACE or a TEN-CARD, they CHECK their FACE-DOWN CARD if they have a BLACKJACK -> all PLAYERs LOSE, otherwise continues as normal

if the PLAYER's CARD is an ACE and a TEN-CARD, its a BLACKJACK
if any PLAYER has a BLACKJACK and the DEALER does not -> PLAYER WINs
if the DEALER has a BLACKJACK -> all PLAYERs LOSE, except for those who also had a BLACKJACK
if both the DEALER and a PLAYER have BLACKJACKs -> its a DRAW for the PLAYER

on their TURN, a PLAYER can
STAND (do not TAKE)
HIT (TAKE)
go BUST (have over 21 POINTS) -> PLAYER LOSEs

cards (per deck): 1x4, 2x4, 3x4, 4x4, 5x4, 6x4, 7x4, 8x4, 9x4, face 10x5, ace 1 or 11x4
actors: player, dealer
actions: take, stand, hit, bust, check (only for dealer)
states: lose, win, ultrawin (with blackjack), faceup, facedown
other: points, blackjack
*/

int deckAmount = 1, playerAmount = 1;
string userString;
string[] playerName = { };

void colorDefault()
{
    Console.ForegroundColor = ConsoleColor.Gray;
}
void colorWrong()
{
    Console.ForegroundColor = ConsoleColor.Red;
}

Console.ForegroundColor = ConsoleColor.Green; // default initial color
Console.WriteLine("-----=====-----=====-----=====-----\n> welcome to blackjack.");
colorDefault();
start:
Console.WriteLine($"> the current game settings are: {deckAmount} deck/s, {playerAmount} player/s.\n> if you wish to change these settings for this round, type \"change\". otherwise, type \"done\".");
switch (userString = Console.ReadLine().ToLower())
{
    case "change":
    settings:
        Console.WriteLine("> please select which parameter you want to change; type \"deck\" or \"player\". if you no longer wish to edit these values, type \"done\".");
        switch (userString = Console.ReadLine().ToLower())
        {
            case "deck":
                Console.WriteLine("> please enter the new value for the amount of decks used in the game (min 1, max 8):");
            getDeckAmount:
                if (!int.TryParse(Console.ReadLine().ToLower(), out deckAmount)) // if user entered nonsense
                {
                    colorWrong();
                    Console.Write("> invalid input. ");
                    colorDefault();
                    Console.WriteLine("please input a whole number between 1 and 8:");
                    goto getDeckAmount;
                }
                if (deckAmount < 1 || deckAmount > 8) // if the requested value is out of legal bounds
                {
                    colorWrong();
                    Console.Write("> that number is too ");
                    switch (deckAmount)
                    {
                        case < 1:
                            Console.Write("small");
                            break;
                        case > 8:
                            Console.Write("large");
                            break;
                    }
                    colorDefault();
                    Console.WriteLine(". please enter a whole value between 1 and 8:");
                    goto getDeckAmount;
                }
                Console.WriteLine($"> there will now be {deckAmount} deck/s and {playerAmount} player/s in the game");
                break;
            case "player":
                Console.WriteLine("> please enter the new value for the amount of players who will be playing the game (min 1, max 6) (excluding the dealer):");
            getPlayerAmount:
                if (!int.TryParse(Console.ReadLine().ToLower(), out playerAmount)) // if user entered nonsense
                {
                    colorWrong();
                    Console.Write("> invalid input. ");
                    colorDefault();
                    Console.WriteLine("please input a whole number between 1 and 6:");
                    goto getPlayerAmount;
                }
                if (playerAmount < 1 || playerAmount > 6) // if the requested value is out of legal bounds
                {
                    colorWrong();
                    Console.Write("> that number is too ");
                    switch (playerAmount)
                    {
                        case < 1:
                            Console.Write("small");
                            break;
                        case > 6:
                            Console.Write("large");
                            break;
                    }
                    colorDefault();
                    Console.WriteLine(". please enter a whole value between 1 and 6:");
                    goto getPlayerAmount;
                }
                Console.WriteLine($"> there will now be {playerAmount} player/s and {deckAmount} deck/s in the game");
                break;
            case "done":
                goto game;
            default:
                colorWrong();
                Console.WriteLine("> invalid input!");
                colorDefault();
                goto settings;
        }
        goto settings;
    case "done":
        break;
    default:
        colorWrong();
        Console.WriteLine("> invalid input!");
        colorDefault();
        goto start;
}

game:
Console.WriteLine("\\\\next");