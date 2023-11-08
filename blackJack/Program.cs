/*
"jdu hrat jackblack" - 23/11/7

ACEs are worth 1 or 11 (player's choice), FACEs 10 and other CARDs normal

1-6 players
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

int deckAmount = 1, playerAmount = 3; // default: 1/1. min/max decks 1/8, min/max players 1/6
string userString;
string[] playerName = { "player 1", "player 2", "player 3" };
Random rnd = new Random();

void colorDefault()
{
    Console.ForegroundColor = ConsoleColor.Gray;
}
void colorWrong()
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void colorTitle()
{
    Console.ForegroundColor = ConsoleColor.Green;
}
void inputInvalid()
{
    colorWrong();
    Console.WriteLine("> invalid input!");
    colorDefault();
}


/* 
colorTitle();
Console.WriteLine("-----=====-----=====-----\n- welcome to blackjack -\n-----=====-----=====-----");
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
inputInvalid();
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
Console.Write(". ");
colorDefault();
Console.WriteLine("please enter a whole value between 1 and 8:");
goto getDeckAmount;
}
Console.WriteLine($"> there will now be {deckAmount} deck/s and {playerAmount} player/s in the game");
break;
case "player":
Console.WriteLine("> please enter the new value for the amount of players who will be playing the game (min 1, max 6) (excluding the dealer):");
getPlayerAmount:
if (!int.TryParse(Console.ReadLine().ToLower(), out playerAmount)) // if user entered nonsense
{
inputInvalid();
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
goto namePlayers;
default:
inputInvalid();
goto settings;
}
goto settings;
case "done":
break;
default:
inputInvalid();
goto start;
}

namePlayers:
colorTitle();
Console.WriteLine("name the players");
colorDefault();
// get all player names
for (int i = 1; i <= playerAmount; i++)
{
namePlayer:
    Console.WriteLine($"please enter the name for player {i}/{playerAmount}:");
    Array.Resize(ref playerName, i);
    userString = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userString)) // name cannot be empty
    {
        inputInvalid();
        Console.WriteLine("player name cannot be empty!");
        goto namePlayer;
    }
    else if (playerName.Contains(userString)) // duplicate name
    {
        inputInvalid();
        Console.WriteLine($"another player is already named \"{userString}\"!");
        goto namePlayer;
    }
    playerName[i - 1] = userString;
}
*/

Console.WriteLine("debug");

string randomLoadMsg = "someihtng went worng (defalut mesasge)";
void randomDelayLong()
{
    Thread.Sleep(rnd.Next(1000, 5000));
}
void randomDelayMedium()
{
    Thread.Sleep(rnd.Next(500, 2500));
}

randomDelayMedium();
Console.WriteLine("counting players...");
randomDelayMedium();
Console.WriteLine("counting decks...");
randomDelayMedium();
Console.WriteLine("shuffling cards...");
randomDelayMedium();
Console.WriteLine($"{randomLoadMsg}...");
randomDelayMedium();
Console.WriteLine("calculating values...");
randomDelayLong();
colorTitle();
Console.WriteLine("done. let's begin!");
colorDefault();

// all PLAYERs TAKE a CARD FACE-UP
// DEALER TAKES a CARD FACE-UP
// all PLAYERs TAKE a CARD FACE-UP
// DEALER TAKES a CARD FACE-DOWN
Console.WriteLine("all players will now get a card face-up. it will be shown to all other players.");

for (int i = 1; i <= playerAmount; i++)
{

}


// TO DO:
// add random loading message generator > at game start