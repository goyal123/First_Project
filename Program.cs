namespace Basic_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,reverse_number;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter a Number");
            num = Convert.ToInt32(Console.ReadLine());
            reverse_number=Reverse_Number.Reverse(num);
            Console.WriteLine("Reversed Number = {0} ",reverse_number);


        }
    }
}