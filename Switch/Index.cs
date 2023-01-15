partial class Program
{
    static string CardinalToOrdinal(int number)
    {
    int lastTwoDigits = number % 100;
    switch (lastTwoDigits)
        {
        case 11: // special cases for 11th to 13th
        case 12:
        case 13:
        return $"{number:N0}th";
        default:
        int lastDigit = number % 10;
        string suffix = lastDigit switch
            {
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ => "th"
            };
        return $"{number:N0}{suffix}";
        }
    }

    static int FibFunctional(int term) => term switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term - 2)
    };
}