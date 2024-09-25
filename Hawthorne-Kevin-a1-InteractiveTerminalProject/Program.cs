
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

//input results

if (Proffession == "Alchemist")
{
    Console.WriteLine("u r alc");
    isAlc = true;

}
else if (Proffession == "Diviner")
{
    Console.WriteLine("u r div");
    isDiv = true;

}
else if (Proffession == "Enchanter")
{
    Console.WriteLine("u r ench");
    isEnc = true;
}
else
{
    Console.WriteLine("you esplode");
}

/*/setting using player information
Console.Write(PlayerName);
Console.Write(" is a ");
Console.Write(Proffession);
Console.Write("'s apprentis. ");
Console.Write(PlayerName);
Console.Write(" is running late to their apprentiship. ");
Console.Write(PlayerName);
Console.WriteLine(" should get going... \n?leave? apartment");
*/
//request player input to progress
Console.ReadLine();
{
    if (Console.ReadLine() == "leave")
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
