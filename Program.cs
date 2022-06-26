Console.WriteLine("Hello! Please enter your name:"); // Ask for user information (ex. name) at the beginning of the application, and use it to refer to the user throughout the application.
string nameA = Console.ReadLine();
string repeatInput = "";
Console.WriteLine("Nice to meet you, " + nameA + "!"); // Promp the user to enter an integer between 1 and 10
do
{
    Console.WriteLine("Please enter an integer between 1 and 100:");
    int inputA = int.Parse(Console.ReadLine());
    bool invalidInt = ((inputA < 1) || (inputA > 100));
        // Display the associated result based on the integer range entered
        // Use if/else statements to take different actions depending on user input.
    if (invalidInt)
        {
            Console.WriteLine("I'm sorry, " + nameA + ", that is not a valid selection.");
        }
        else if ((((inputA % 2) != 0) && (inputA < 60))) // If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60."
        {
            Console.WriteLine(nameA + ", the integer you entered, " + inputA + ", is an odd number, and less than 60.");
        }
        else if ((((inputA % 2) == 0) && ((inputA >= 2) && (inputA <= 24))))
        {
            Console.WriteLine(nameA + ", the integer you entered, " + inputA + ", is an even number, and less than 25"); // If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
        }
        else if ((((inputA % 2) == 0) && ((inputA >= 26) && (inputA <= 60))))
        {
            Console.WriteLine(nameA + ", the integer you entered, " + inputA + ", is an even number, and between 26 and 60 inclusive"); // If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
        }
        else if ((((inputA % 2) == 0) && (inputA > 60)))
        {
            Console.WriteLine(nameA + ", the integer you entered, " + inputA + ", is an even number, and is greater than 60."); //  If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
        }
        else if ((((inputA % 2) != 0)) && (inputA > 60)) // If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60."
        {
            Console.WriteLine(nameA + ", the integer you entered, " + inputA + ", is an odd number, and greater than 60."); // If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”
        }
    Console.WriteLine(nameA + ", would you like to try again? Enter y/n:"); // Set up the program to continue running with a prompt at the end to see if they want to stop.
    repeatInput = Console.ReadLine();
} while (repeatInput == "y"); 
Console.WriteLine("Goodbye, " + nameA + "!");

// Add validation to guarantee that a user enters a positive integer between 1 and 100.