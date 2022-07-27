
Console.WriteLine("\nInteractive Math Menu\n");
gameCicle();

void gameCicle()
{
    Console.WriteLine("\nSelect Math Operation\n\n" + "1. Addition\n" + "2. Subtraction\n" + "3. Multiplication\n" + "4. Division\n" + "5. Exit\n");
    string option = Console.ReadLine() ?? "n";

    if (option == "addition")
    {
       addNumbers();
       gameCicle(); 
    }
    else if (option == "subtraction")
    {
        subNumbers();
        gameCicle();
    }
    else if (option == "multiplication")
    {
        mulNumbers();
        gameCicle();
    }
     else if (option == "division")
    {
        divNumbers();
        gameCicle();
    }
    else
    {
        Console.Write("End of program");
    }
}

void addNumbers ()
{
    Console.Write("Enter the first number:");
    int firstNumber = Int32.Parse (Console.ReadLine() ?? "0");

    Console.Write("Enter the second number:");
    int secondNumber = Int32.Parse (Console.ReadLine() ?? "1000");

    Console.Write("The result is:");
    int addResult = firstNumber + secondNumber;
    Console.Write(addResult + "\n");
}

void subNumbers ()
{
    Console.Write("Enter the first number:");
    int firstNumber = Int32.Parse (Console.ReadLine() ?? "0");

    Console.Write("Enter the second number:");
    int secondNumber = Int32.Parse (Console.ReadLine() ?? "1000");

    Console.Write("The result is:");
    int subResult = firstNumber - secondNumber;
    Console.Write(subResult + "\n");
}

void mulNumbers ()
{
    Console.Write("Enter the first number:");
    int firstNumber = Int32.Parse (Console.ReadLine() ?? "0");

    Console.Write("Enter the second number:");
    int secondNumber = Int32.Parse (Console.ReadLine() ?? "1000");

    Console.Write("The result is:");
    int mulResult = firstNumber * secondNumber;
    Console.Write(mulResult + "\n");
}

void divNumbers ()
{
    Console.Write("Enter the first number:");
    int firstNumber = Int32.Parse (Console.ReadLine() ?? "0");

    Console.Write("Enter the second number:");
    int secondNumber = Int32.Parse (Console.ReadLine() ?? "1000");

    Console.Write("The result is:");
    int divResult = firstNumber / secondNumber;
    Console.Write(divResult + "\n");
}