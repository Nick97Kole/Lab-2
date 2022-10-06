// See https://aka.ms/new-console-template for more information

void loopOne()
{

    do
    {
        Console.WriteLine("Hello WOorld");

        Console.WriteLine("Would you like to continue y/n");
        string answer = Console.ReadLine();

        if (answer == "y")
        {

            continue;
        }

        else
        {
            break;
        }
    } while (true);
}


void loopTwo()
{

    do
    {

        Console.WriteLine("Guess a number");
        int p = Convert.ToInt32(Console.ReadLine());
        for (int i = p; i >= 0; i--)
        {
            Console.WriteLine(i);

        }
        for (int i = 0; i <= p; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Would you like to play again?");
        string answer = Console.ReadLine();

        if (answer == "y")
        {
            continue;
        }

        else
        {
            break;
        }
    } while (true); */
}


void loopThree()
{


    while (true)
    {
        Console.WriteLine("Enter the code");
        int code = Convert.ToInt32(Console.ReadLine());

        if (code != 13579)
        {
            Console.WriteLine("try again");
            int guess = 0;
            guess++;

            if (guess == 1)
            {
                Console.WriteLine("No Soup for you!!");
                break;
            }
        }

        else if (code == 13579)
        {
            Console.WriteLine("Welcome!!");
            break;
        }

    } 
}


void loopFour()
{

    int guess = 0;
    while (true)
    {
        Console.WriteLine("Enter the code");
        int code = Convert.ToInt32(Console.ReadLine());
        guess++;

        if (code != 13579)
        {
            Console.WriteLine("try again");

        }

        if (guess == 5)
        {
            Console.WriteLine("No Soup For you!");
            break;
        }

        else if (code == 13579)
        {
            Console.WriteLine("Welcome!!");
            break;
        }

    }
}




void loopFive()
{


    int guess = 0;
    do
    {

        Console.WriteLine("Enter the code");
        int code = Convert.ToInt32(Console.ReadLine());
        guess++;

        if (code != 13579)
        {
            Console.WriteLine("try again");

        }

        if (guess == 5)
        {
            Console.WriteLine("No Soup For you!");
            break;
        }

        else if (code == 13579)
        {
            Console.WriteLine("Welcome!!");
            break;
        }
    } while (true);
}