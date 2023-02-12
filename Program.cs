static void GetFull()
{
    Random rnd = new Random();
    int numberOfRows = rnd.Next(3, 9);
    for (int i = 1; i < numberOfRows; i++) // assignment; comparison; increment/decrement
    {// controles how many rows we make 
        for (int j = 0; j < i; j++)
        { // controles how many stones we print
            Console.Write("O "); // prints stone 
        }
        Console.WriteLine(); // prints new line for next row in triangle
    }
}
static void GetPartial()
{
    Random rnd = new Random();
    int numberOfRows = rnd.Next(3, 9);
    for (int i = 1; i < numberOfRows; i++)
    {
        for (int j = 0; j < i; j++)
        {
            int showDecision = rnd.Next(2); // generates 0 or 1 randomly
            if (showDecision == 0)
            { /// test if 0 was generated
                Console.Write("O ");// prints if true
            }
            else
            {
                Console.Write("  ");// prints if false 
            }

        }
        Console.WriteLine(); // prints new line for next row in triangle
    }
}
string userInput = ""; // assigns variable to empty string
while (userInput != "3") //  exit loop if variable string is 3
{
    Console.WriteLine("1) triangle 2) partial triangle, 3) Exit");// user help
    userInput = Console.ReadLine();//take user input
    if (userInput == "1")// if user input needs to create triangle 
    {

        GetFull();// calls full function 
    }
    else if (userInput == "2")//if user input needs to create partial triangle 
    { // begin else if where user input is 2 
        GetPartial();// calls partial function 
    }// end else if where user input is 2 
}
