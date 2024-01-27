// See https://aka.ms/new-console-template for more information

Console.WriteLine( "enter num 1:");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter num 2:");
int num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("CHoose an operation:");
Console.WriteLine("1) Addition");
Console.WriteLine("2) Subtraction");
Console.WriteLine("3) Multiplication");
Console.WriteLine("4) Division");
Console.WriteLine("5) Exit");
Console.WriteLine("\r\nSelected option:");

double numans;

switch (Console.ReadLine())
{
    case "1":
        numans = num1 + num2;
        Console.WriteLine("The sum is " + numans);
    break;

    case "2":
        numans = num1 - num2;
        Console.WriteLine("The difference is " + numans);
    break;

    case "4":
        numans = num1/num2;
        Console.WriteLine("The result of the division is: " + numans);
     break;

        case "3":

        numans = num1 * num2;
        Console.WriteLine("The result of multiplying the two numbers is:" + numans);
        break;

}


  
