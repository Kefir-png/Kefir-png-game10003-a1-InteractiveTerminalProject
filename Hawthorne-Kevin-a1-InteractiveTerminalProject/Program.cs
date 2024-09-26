
using System;
using System.Net.Security;

//setiing bools
bool isAlc = false;
bool isDiv = false;
bool isEnc = false;

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

Console.WriteLine();
//setting using player information
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
    else
    {
        Console.WriteLine("you esplode");
    }
}
//inproper input 

//proper input progresses to riddle

//proper input

//inproper riddle input consequnses 
