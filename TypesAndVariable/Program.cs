using System.Data.SqlTypes;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Xml.Schema;
using static System.Convert;

public class Person {
    public string? firstname;
}
internal class Program
{
    private static void Main(string[] args)
    {
        void print(string temp)
        {
            WriteLine(temp);
        }

        //---------------------------String literals---------------//
        // string var1 = "is da best!";
        // Console.WriteLine("\tKhanhLe\n");
        // Console.WriteLine(@"\t/KhanhLe//" + var1); // can ignore \t \n ... 
        // Console.WriteLine($"\\tKhanhLe//{var1}");


        //----------------------------Numbers---------------------//
        // Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in range {int.MinValue:N0} to {int.MaxValue:N0}");
        // Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in range {double.MinValue:N0} to {double.MaxValue:N0}");
        // Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

        // Double value is stored as floating number which is represented as 1010.101010..... in binary: ex: 0.1 = 0.000110011001100... => never use double type for equality comparison

        // Use decimal instead because decimal value is stored as a whole number with a note how to shift the decimal point. Ex: 12.12 => stored as 1212 and shift 2 points to the left. 

        // print("Using double:");
        // double a = 0.1;
        // double b = 0.2;
        // if (a + b == 0.3){
        //     print($"{a} + {b} equals 0.3");
        // }else
        // {
        //     print($"{a} + {b} does not equal 0.3"); // This runs!!!
        // }

        // print("Using decimal:");
        // decimal c = 0.1M;   // M suffix means a decimal literal value
        // decimal d = 0.2M;
        // if (c + d == 0.3M){
        //     print($"{c} + {d} equals 0.3"); // This runs!!!
        // }else
        // {
        //     print($"{c} + {d} does not equal 0.3"); 
        // }
        // L, UL, M, D, F => 100L / 123M / 12D


        ///----------------------Dynamic---------------------------------///
        // dynamic something = "Khanh";
        // //something = 15;
        // something = new[] { 3, 7, 5 };
        // Console.WriteLine(something.Length);
        // Person khanh = new Person();
        // khanh.firstname = "Khanh Le";
        // Person tho = new();
        // tho.firstname = "Tho Nguyen";
        // Person ethan = new() { firstname = "Ethan Christensen" };
        // print(khanh.firstname);
        // print(tho.firstname);
        // print(ethan.firstname);

        //----------------------------Default---------------------//
        // print($"Default value of int: {default(int)}");
        // print($"Default value of boolean: {default(bool)}");
        // print($"Default value of DateTime: {default(DateTime)}");
        // print($"Default value of string: {default(string)}"); // string is a reference type
        // int num = 13;
        // print(num.ToString());
        // // num = default;
        // // print(num.ToString());
        // print($"Total price: {num:C}");  // :C == currency
        // string temp = "Total price" + num;
        // print(temp);

        //----------------------------Input------------------------//
        // print("Please input yourname: ");
        // string firstname = Console.ReadLine()!;
        // print("Please input your age: ");
        // string age = Console.ReadLine()!;
        // print($"Hello {firstname}, you look good for {age}");

        //----------------------------args------------------------//
        // WriteLine($"There are {args.Length} arguments");
        // if (args.Length < 3)
        // {
        //     WriteLine("You must specify two colors and cursor size, e.g.");
        //     WriteLine("dotnet run red yellow 50");
        //     return; // stop running
        // }
        // ForegroundColor = (ConsoleColor)Enum.Parse(
        //     enumType: typeof(ConsoleColor),
        //     value: args[0],
        //     ignoreCase: true);

        // BackgroundColor = (ConsoleColor)Enum.Parse(
        //     enumType: typeof(ConsoleColor),
        //     value: args[1],
        //     ignoreCase: true);

        // CursorSize = int.Parse(args[2]);

        // print($"Size of double: {sizeof(double)}");
        // print($"Size of float: {sizeof(float)}");

        //----------------------------Rounding------------------------//
        double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
        foreach (double n in doubles)
        {
            WriteLine($"ToInt32({n}) is {ToInt32(n)}");
        }
        // => 10.5 = 10 => Banker's rounding, and it is preferred because it redices bias by alternating when it rounds up or down. When the midpoint is .5, it rounds up if the non-decimal is odd, rounds down otherwise.

        foreach (double n in doubles)
        {
            WriteLine(format:
            "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
            arg0: n,
            arg1: Math.Round(value: n, digits: 0,
            mode: MidpointRounding.AwayFromZero));
        }
    }
}