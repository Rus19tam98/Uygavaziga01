namespace uygavazifa01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" son kiriting => ");
            int a = int.Parse(Console.ReadLine());
            string str = "";
            while (a >= 1)
            {
                str = (a % 2) + str;
                a = a / 2;
            }
            Console.Write($"natija => {str}");
            Console.WriteLine();
        }
    }
}