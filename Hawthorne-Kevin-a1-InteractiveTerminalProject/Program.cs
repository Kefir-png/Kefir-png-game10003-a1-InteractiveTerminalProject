
using System;
using System.ComponentModel.Design;
using System.Net.Security;

//Begining includes a text introduction on how the console input works for the player and a ascii banner.

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Yb        dP 88 8888P    db    88\"\"Yb 8888b.   .o. .dP\"Y8            \r\n Yb  db  dP  88   dP    dPYb   88__dP  8I  Yb ,dP' `Ybo.\"            \r\n  YbdPYbdP   88  dP    dP__Yb  88\"Yb   8I  dY      o.`Y8b            \r\n   YP  YP    88 d8888 dP\"\"\"\"Yb 88  Yb 8888Y\"       8bodP'            \r\n   db    88\"\"Yb 88\"\"Yb 88\"\"Yb 888888 88b 88 888888 88  dP\"\"b8 888888 \r\n  dPYb   88__dP 88__dP 88__dP 88__   88Yb88   88   88 dP   `\" 88__   \r\n dP__Yb  88\"\"\"  88\"\"\"  88\"Yb  88\"\"   88 Y88   88   88 Yb      88\"\"   \r\ndP\"\"\"\"Yb 88     88     88  Yb 888888 88  Y8   88   88  YboodP 888888 ");
Console.WriteLine("In the game options for progression are marker with two question marks (i.e. ?Example?). \nWriting these words in the console will progress the game depending on your choice of words.");

//setting bools thatll be used later

bool isAlc = false;
bool isDiv = false;
bool isEnc = false;
bool isDead = false;
bool onTime = false;

//introduction

Console.WriteLine();
Console.WriteLine("You are a Wizards Apprentis");

//requesting player input for name, reading input and applying it to a variable "playerName".

Console.WriteLine("What is your name?");
Console.WriteLine();
String playerName = Console.ReadLine();

/*/using player name then asking for player proffession and list proffession options. 
setting proffession variable and applying user input to the variable then setting all 
user input to lowercase to help with spelling misshaps.
*/

Console.WriteLine();
Console.WriteLine("hello, " + playerName);
Console.WriteLine("are you a...");
Console.WriteLine("?Alchemist? (s) apprentis \n?Diviner? (s) apprentis \n?Enchanter? (s) apprentis");
Console.WriteLine();
string proffession = Console.ReadLine();
proffession = proffession.ToLower();

//input results in changes to bool status. this will be important for the endings.

if (proffession == "alchemist")
{
    isAlc = true;

}
else if (proffession == "diviner")
{
    isDiv = true;

}
else if (proffession == "enchanter")
{
    isEnc = true;
}
else
{
    Console.WriteLine();
    Console.WriteLine("you esplode");
    isDead = true;
}

/*/if user iput is invalid they explode and a game over screen pops up. 
Im having issues stopping the program after a game over screen without using more complex functions.
*/

if (isDead == true)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine();
    Console.WriteLine("Game Over");
}

//based on which bool is set to true the player will get a diffrent statement.

if (isAlc == true)
{
    Console.WriteLine();
    Console.WriteLine("u r alch");
}
else if (isDiv == true)
{
    Console.WriteLine();
    Console.WriteLine("ur div");
}
else if (isEnc == true)
{
    Console.WriteLine();
    Console.WriteLine("ur ench");
}


//break after the text...

Console.WriteLine();

//setting using player information requesting user input

Console.WriteLine(playerName + " is running late to their apprentiship...");
Console.WriteLine(playerName + " should get going... \n?leave? apartment");

//read player input set all to lowercase 

Console.WriteLine();
string userInput = Console.ReadLine();
userInput = userInput.ToLower();

//if user types "leave" program will explain a riddle and if invalid input was placed player will be late and trigger game over screen.

if (userInput == "leave")
{
    Console.WriteLine();
    Console.WriteLine(playerName + " aprouches their apartments front door. On the wood of the door a magical glyph is written. The glyph says...");
    Console.WriteLine("...");
    Console.WriteLine("Im two faces; both a buigining and an end.");
    Console.WriteLine("When one closes the other one opens. Though i am no map, I sometimes need a key.");
    Console.WriteLine("The more of me you open the more you will be free.");
    Console.WriteLine("...");
    Console.WriteLine("What am i?");
}
else
{
    Console.WriteLine();
    Console.WriteLine("We dont have time for that right now... \nYou are late...");
    isDead = true;
}

//game over screen code repeated, i cannot use loops so i had to copy it.

if (isDead == true)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine();
    Console.WriteLine("Game Over");
}

//setting variable for riddle solution and setting to lowcase

string solution = Console.ReadLine();
solution = solution.ToLower();

//check is player input is correct it will check wich bool is set to true and give unique interaction else if input invalid player explodes.

if (solution == "door")
{
    if (isAlc == true)
    {
        Console.WriteLine();
        Console.WriteLine("");
        onTime = true;
    }
    else if (isDiv == true)
    {
        Console.WriteLine();
        Console.WriteLine("");
        onTime = true;
    }
    else if (isEnc == true)
    {
        Console.WriteLine();
        Console.WriteLine("");
        onTime = true;
    }
}
else
{
    Console.WriteLine();
    Console.WriteLine("you esplode");
    isDead = true;
}

//bools onTime and isDead are check for and if one is true it triggers either the good ending "being on time" or bad game over.

if (onTime == true)
{
    Console.WriteLine();
    Console.WriteLine("You exit your apartment. \nYou ran as fast as possible to your apprentiship. \nYou got there on time :)");
}

if (isDead == true)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine();
    Console.WriteLine("Game Over");
}
    
