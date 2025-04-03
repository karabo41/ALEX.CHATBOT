using System;
using System.Media;
using System.Threading;

class Program
{
    static void Main()
    {
        // 
        try
        {
            // Play the recorded voice greeting
            SoundPlayer player = new SoundPlayer("welcome.wav");
            player.PlaySync();

            Console.WriteLine("Welcome to ALEX Bot!");
        }
        catch (Exception)
        {
            Console.WriteLine("[!] Unable to play audio.");
        }
        // Display ASCII logo
        string asciiLogo = @"
         /\\    /\\  ______  __  __  
        |  \\  /  |/  ____||  \/  | 
        |   \\/   || |  __  | \  / | 
        | |\__/| || | |_ | | |\/| | 
        |_|    |_|\______||_|  |_| 
        ";
        Console.WriteLine(asciiLogo);

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Nice to meet you, " + userName + "!");

        // BOT RESPONSES 

        while (true)
        {
            Console.Write("Ask me a CYBERSECURITY question: ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "exit")
            {
                Console.WriteLine("Goodbye! Stay safe online.");
                break;
            }
            else if (userInput.Contains("password"))
            {
                Console.WriteLine("Always use strong passwords with a mix of letters, numbers, and symbols.");
            }
            else if (userInput.Contains("phishing"))
            {
                Console.WriteLine("Beware of suspicious emails asking for personal details. Always verify the sender.");
            }
            else
            {
                Console.WriteLine("I can provide cybersecurity tips and answer common questions.");
            }
        }
    }
}
