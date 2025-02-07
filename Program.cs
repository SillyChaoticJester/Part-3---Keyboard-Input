namespace Part_3___Keyboard_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response;
            int number;
            Console.WriteLine("Say hello!");
            response = Console.ReadLine();
            Console.WriteLine($"You said: {response}");
            Console.WriteLine("Now say a number, please");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You said: {number}");
        }
    }
}
