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
            if (Int32.TryParse(Console.ReadLine(), out number))
            {

                Console.WriteLine($"You said: {number}, good job!");

            }
            else
            {

                Console.WriteLine("Oops, you've said an invalid number!");

            }
            
        }
    }
}
