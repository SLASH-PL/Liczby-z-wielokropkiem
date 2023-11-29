class Program
{
    static void Main()
    {
        string wejscie = Console.ReadLine();
        short[] dane = Array.ConvertAll<string, short>(wejscie.Split(" "), short.Parse);

        short a = dane[0];
        short b = dane[1];
        short h = a;
        Console.Clear();
        if (a > b)
        {
            a = b;
            b = h;
        }
        if (a + 12 <= b)
        {
            Console.WriteLine($"{a + 1}, {a + 2}, {a + 3}, ..., {b - 2}, {b - 1}");
            return;
        }
        if (a == b || a == b - 1 || a - 1 == b)
        {
            Console.WriteLine("empty");
            return;
        }
        while (a < b)
        {
            a++;
            if (a < b - 1)
            {
                Console.Write($"{a}, ");
            }
            else
            {
                Console.Write(a);
                return;
            }

        }
    }
}