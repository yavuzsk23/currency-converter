namespace converter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("write tl");
            double tl = double.Parse(Console.ReadLine());
            double euroRate = 55.0;
            double dollarRate = 50.0;
            double euro = tl / euroRate;
            double dollar = tl / dollarRate;
            Console.WriteLine("y" + euro);
            Console.WriteLine("as" + dollar);
        }
    }

}
