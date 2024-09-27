
using System;
using System.Net.Security;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Yb        dP 88 8888P    db    88\"\"Yb 8888b.   .o. .dP\"Y8            \r\n Yb  db  dP  88   dP    dPYb   88__dP  8I  Yb ,dP' `Ybo.\"            \r\n  YbdPYbdP   88  dP    dP__Yb  88\"Yb   8I  dY      o.`Y8b            \r\n   YP  YP    88 d8888 dP\"\"\"\"Yb 88  Yb 8888Y\"       8bodP'            \r\n   db    88\"\"Yb 88\"\"Yb 88\"\"Yb 888888 88b 88 888888 88  dP\"\"b8 888888 \r\n  dPYb   88__dP 88__dP 88__dP 88__   88Yb88   88   88 dP   `\" 88__   \r\n dP__Yb  88\"\"\"  88\"\"\"  88\"Yb  88\"\"   88 Y88   88   88 Yb      88\"\"   \r\ndP\"\"\"\"Yb 88     88     88  Yb 888888 88  Y8   88   88  YboodP 888888 ");
Console.WriteLine("In the game options for progression are marker with two question marks (i.e. ?Example?). \nWriting these words in the console will progress the game depending on your choice of words.");

//setiing bools
bool isAlc = false;
bool isDiv = false;
bool isEnc = false;

//introduction
Console.WriteLine();
Console.WriteLine("You are a Wizards Apprentis");

//requesting player input for name
Console.WriteLine("What is your name?");
String PlayerName = Console.ReadLine();

//asking for player proffession and list proffession options
Console.WriteLine("hello, " + PlayerName);
Console.WriteLine("are you a...");
Console.WriteLine("?Alchemist? (s) apprentis \n?Diviner? (s) apprentis \n?Enchanter? (s) apprentis");
string Proffession = Console.ReadLine();
Proffession = Proffession.ToLower();

//input results

if (Proffession == "alchemist")
{
    isAlc = true;

}
else if (Proffession == "diviner")
{
    isDiv = true;

}
else if (Proffession == "enchanter")
{
    isEnc = true;
}
else
{
    Console.WriteLine("you esplode");
}


if (isAlc == true)
{
    Console.WriteLine("u r alch");
}
else if (isDiv == true)
{
    Console.WriteLine("ur div");
}
else if (isEnc == true)
{
    Console.WriteLine("ur ench");
}


//break after the text
Console.WriteLine();
//setting using player information
Console.WriteLine(PlayerName + " is running late to their apprentiship...");
Console.WriteLine(PlayerName + " should get going... \n?leave? apartment");

//request player input to progress
string userInput = Console.ReadLine();
userInput = userInput.ToLower();


{
    if (userInput == "leave")
    {
        Console.WriteLine(PlayerName + "aprouches their apartments front door. On the wood of the door a magical glyph is written. The glyph says...");
        Console.WriteLine("...");
        Console.WriteLine("Im two faces; both a buigining and an end.");
        Console.WriteLine("When one closes the other one opens. Though i am no map, I sometimes need a key.");
        Console.WriteLine("The more of me you open the more you will be free.");
        Console.WriteLine("...");
        Console.WriteLine("What am i?");
    }
    else if solution == "door"
    {
        ;
    }
    else
    {
        Console.WriteLine("you esplode");
    }
}
string solution  = Console.ReadLine();
solution = solution.ToLower();