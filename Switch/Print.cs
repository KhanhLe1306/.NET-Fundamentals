using System.Net;

partial class Program{
    /// <summary>
    /// Print just like Python
    /// </summary>
    /// <param name="message">message as a string that will be printed</param>
    static void print(string message){
        WriteLine(message);
    }
    static void print(int num){
        WriteLine(num);
    }
}