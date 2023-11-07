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
bool success;
string[] playerName = { };

Console.WriteLine($"> welcome to blackjack.\n> the current settings are: {deckAmount} deck/s, {playerAmount} player/s.\n> if you wish to keep these settings for this round, press enter. otherwise, type \"change\".");
userString = Console.ReadLine().ToLower();
if (userString == "change")
{
    Console.WriteLine("> please select which parameter you want to change (type \"deck\" or \"player\"). if you no longer wish to edit these values, type \"done\".");
    userString = Console.ReadLine().ToLower();
    switch (userString)
    {
        case "deck":
            Console.WriteLine("please enter the new value for the amount of decks in the game (min 1, max 8):");
            success = int.TryParse(Console.ReadLine().ToLower(), out deckAmount);



            do
            {

            } while (!success);


            if (deckAmount < 1 && deckAmount > 8)
            {
                Console.WriteLine("invalid number. please enter a whole value between 1 and 8:");
            }




            break;
        case "player":
            break;
        case "done":
            break;
        default:
            Console.WriteLine("invalid input! \"deck\", \"player\" or \"done\" expected.");
            break;
    }
    Console.WriteLine($"> the current settings are: {deckAmount} deck/s, {playerAmount} player/s. if you wish to edit these values again, type \"\"");
}
