// See https://aka.ms/new-console-template for more information

bool numAn = true;

while (numAn)
{


    Console.WriteLine("Greetings! What is your name?");
    Console.ReadLine();
    Console.WriteLine("Geoff, was it?");
    Console.ReadLine();
    bool afterName = true;
    while (afterName)
    {

        Console.WriteLine("Okay Geoff, please enter a whole number between 1 and 100.");

        int input = int.Parse(Console.ReadLine());

        if (input >= 1 && input <= 100)
        {
            Console.WriteLine("You entered " + input);

            if (input % 2 != 0 && input < 60)
            {
                Console.WriteLine("Your number is odd and less than 60! \n");
            }
            else if (input % 2 == 0 && input <= 24)
            {
                Console.WriteLine("Your number is even and less than 25! \n");
            }
            else if (input % 2 == 0 && input >= 26 && input <= 60)
            {
                Console.WriteLine("Your number is even and between 26 and 60! \n");
            }
            else if (input % 2 == 0 && input > 60)
            {
                Console.WriteLine("Your number is even and greater than 60! \n");
            }
            else
            {
                Console.WriteLine("Your number is odd and greater than 60! \n");
            }

            bool askAgain = true;
            while (askAgain)
            {
                Console.WriteLine("Would you like to play again Geoff? Y/N");
                string input2 = Console.ReadLine().ToLower();

                if (input2 == "y")
                {
                    numAn = true;
                    askAgain = false;
                }
                else if (input2 == "n")
                {
                    numAn = false;
                    askAgain = false;
                    afterName = false;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand that. Let's try that again. \n");
                    askAgain = true;
                }
            }
        }
        else
        {
            Console.WriteLine("That number is not between 1 and 100 Geoff, please try again. \n");
            afterName = true;
        }
    }
}