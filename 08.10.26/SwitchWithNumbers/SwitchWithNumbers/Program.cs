namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta number");

            int number  = int.Parse(Console.ReadLine());
            //teie töö on teha switch rakendus
            //kus on kolm case

            switch (number)
            {
                case 1:
                    Console.Beep();
                    Console.WriteLine("Sisestasid 1");
                    break;
                case 2:
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Console.WriteLine("Sisestasid 2");
                    break;
                case 3:
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Console.WriteLine("Sisestasid 3");
                    break;
                default:
                    Console.WriteLine("Sisestasid mõnda muu numbri");
                    break;
            }
        }
    }
}
