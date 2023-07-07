class Program
{
    static int count = 0;
    static decimal sum = 0;

    private static void ReadUserInputAndWaitForEnterKey()
    {
        Console.Write("\nEnter some number and press Enter: ");
        var userInput = Console.ReadLine(); // get user input
        if (userInput != null)
        {
            try
            {
                decimal userInputValue=decimal.Parse(userInput); // convert user input to decimal
                count++; // add 1 with count
                sum += userInputValue; // add user iput with previus sum
                //print results
                Console.WriteLine("\nSum :"+sum.ToString());
                Console.WriteLine("Number of input values :" +count);
                Console.WriteLine("Continuous mean value:"+ (sum / Convert.ToDecimal(count)).ToString()+"\n--Follow instructions--");
                Console.WriteLine("Press 'R' to restart OR \npress 'X' to exit and calculate the final results OR \npress any key to continue");
            }
            catch {
                Console.WriteLine("Error :Invalid input, Please enter a valid number");// Error - user input cannot convert to decimal
                ReadUserInputAndWaitForEnterKey(); // get input from user agin
            }
        }
        else
        {
            Console.WriteLine("Error :Null input, Please enter a valid number"); // Error - user input is null
            ReadUserInputAndWaitForEnterKey(); // get input from user agin
        }
        
    }



    static void Main(string[] args)
    {
        ConsoleKey finalKey; // init a variable to find the user's final input
        ConsoleKey userInputKey;
        do
        {
            Console.WriteLine("\n********CONTINUOUS MEAN VALUE CALCULATION********"); // title

            do
            {
                //Prompts user to enter text and waits for Enter key press to continue
                ReadUserInputAndWaitForEnterKey();
                userInputKey = Console.ReadKey(true).Key;
                // if user press R, reset the count and sum, and continue the program 
                if (userInputKey == ConsoleKey.R)
                {
                    count = 0;
                    sum = Convert.ToDecimal(0);
                    Console.WriteLine("\n********CONTINUOUS MEAN VALUE CALCULATION********\nProgram resetted");
                }
            } while ( userInputKey!= ConsoleKey.X); // if user press x key break the loop and continue to balance code

            //print the final results
            Console.WriteLine("\nYOUR FINAL RESULTS\nSum :" + sum.ToString());
            Console.WriteLine("Number of input values :" + count);
            Console.WriteLine("Continuous mean value:" + (sum / Convert.ToDecimal(count)).ToString() + "\n");
            Console.WriteLine("--Thank you-- \nPress 'R' to restart or \nPress 'C' to continue with the previous results or \nPress any other key to exit");

            finalKey = Console.ReadKey(true).Key;// read the key

            // if user press R, reset the count and sum, and continue the program from the start
            if (finalKey == ConsoleKey.R)
            {
                count = 0;
                sum = Convert.ToDecimal(0);
            }
        }while(finalKey== ConsoleKey.R || finalKey == ConsoleKey.C); // if user press R or C, restart the program
                                                                     // Note - if user press C without reset the count and sum,
                                                                     // continue the program from the start
    }
}