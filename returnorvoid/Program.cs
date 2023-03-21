namespace returnorvoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.Meth(5, 7));
            Console.WriteLine(class1.Meth1(5, 7));
        }
    }
}