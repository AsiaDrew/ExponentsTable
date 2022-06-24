//Intro
Console.WriteLine("EXPONENTS / POWERS TABLE");
Console.WriteLine();



PrintAll();



//methods

//holds all of my methods and my program
static void PrintAll()
{
    bool isRunning = true;

    while (isRunning)
    {
        int userNumber = GetUserInfo();
        Console.WriteLine();
        PrintTable(userNumber);
        isRunning = GoAgain();
    }
}

//get a integer from the user, validation for 1-1291
static int GetUserInfo()
{
    bool isValidInput = false;
    int userNumber = 0;
    while (!isValidInput)
    {

        Console.Write("Please enter a number greater than zero and less than 1291: ");
        userNumber = int.Parse(Console.ReadLine());


        if (userNumber >= 1 && userNumber <= 1291)
        {
            isValidInput = true;
        }
        else 
        {
            Console.WriteLine("Wrong, try again!");
        }
        
    }
    return userNumber;
}

//prints my table
static void PrintTable(int userNumber)
{
    Console.WriteLine(String.Format("{0,7} {1,12} {2,10} ", "Number", "Squared", "Cubed"));
    Console.WriteLine(String.Format("{0,7} {1,12} {2,10} ", "======", "======", "======"));

    for (int i = 1; i <= userNumber; i++)
    {
        Console.WriteLine(String.Format("{0,7} {1,12} {2,10} ", i, Math.Pow(i, 2), Math.Pow(i, 3)));
    }
}

//ask user to go again and ends program
static bool GoAgain()
{
    Console.WriteLine();
    Console.Write("Do u want to go again? Enter y/n: ");
    string choice = Console.ReadLine().ToLower();
    Console.WriteLine();
    if (choice == "y")
    {
        return true;
    }
    else if (choice == "n")
    {
        Console.WriteLine("Bye!");
        return false;
    }
    else
    {
        Console.WriteLine("Sorry, try again. ");
        return GoAgain();
    }
}


