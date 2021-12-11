class Program
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string b = a.Replace(" ", "");
        Console.WriteLine($"{b}");
        bool opred = true;
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] == b[b.Length - 1 - i])
            {
                opred = true;
            }
            else
            {
                opred = false;
            }
            if (!opred)
            {
                Console.WriteLine("Это не полиндром");
                break;
            }
        }
        if (opred)
        {
            Console.WriteLine("Это полиндром");
        }
    }
}