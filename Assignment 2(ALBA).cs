namespace Assignment_2_ALBA_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int A = 1; A < 101; A++)
            {
                if (A % 15 == 0){
                    Console.WriteLine("Hello Good Bye");                   
                }
                else if (A % 5 == 0){
                    Console.WriteLine("Good Bye");
                }
                else if (A % 3 == 0){
                    Console.WriteLine("Hello");
                }
                else{
                    Console.WriteLine(A);
                }
            }
        }
    }
}
