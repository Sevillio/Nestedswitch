// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using System.Threading.Channels;

Console.WriteLine("Hello, Player!");
Console.WriteLine("What is your name");
string Userinput = Console.ReadLine();
Console.WriteLine($"Hello {Userinput}");

Console.WriteLine("Do you want to play the game");
Console.WriteLine("\ty Yes");
Console.WriteLine("\tn No ");

Console.Write("Your choice ");

int score = 0;

switch(Console.ReadLine())
{
    case "y":
        Console.WriteLine("The Game will start");
        Console.WriteLine($"You ready {Userinput}");
        Console.ReadKey();
        Console.WriteLine("Welcome to the world of math");
        Console.WriteLine("The game is simple if you can get the answer right. You win");

        Console.WriteLine("Selct a Stage");
        Console.WriteLine("\tblue Blue- Easy");
        Console.WriteLine("\tred Red-Medium");
        Console.WriteLine("\tgreen Green- Hard");

        Console.Write("Your choice ");

        switch(Console.ReadLine())
        {
            case "blue":
                Console.WriteLine("2 + 2 = ?");
                string Playerinputn= Console.ReadLine();
                string Correctanswer = "4";
                if(Correctanswer == Playerinputn)
                {
                    Console.WriteLine("Correct");
                    if(Correctanswer == Playerinputn)
                    {
                        score++;
                    }

                    Console.WriteLine($"current score: {score}");
                }
                else
                {
                    Console.WriteLine("Answer is not correct");
                    Console.WriteLine($"current score: {score}");
                }
                break;
            case "red":
                Console.WriteLine("2 * 5 = ?");
                string playerinputk = Console.ReadLine();
                string Correctanswerkn = "10";
                if(Correctanswerkn == playerinputk)
                {
                    Console.WriteLine("Correct");
                    if(Correctanswerkn == playerinputk)
                    {
                        score++;
                    }

                    Console.WriteLine($"current score: {score}");
                }
                else
                {
                    Console.WriteLine("Answer is not correct");
                    Console.WriteLine($"current score: {score}");
                }
                break;
            case "green":
                Console.WriteLine("5 * 5 / 2 * 5 + 2 = ?");
                string playerinputg = Console.ReadLine();
                string correctanswerg = "64.5";
                if(correctanswerg == playerinputg)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Answer is not correct");
                }
                break;
        }
        break;

    case "n":
        Console.WriteLine("Till next Time");
        break;
}

Console.WriteLine($"Final score: {score}");
Console.WriteLine("Press Enter to End");
Console.ReadKey();

