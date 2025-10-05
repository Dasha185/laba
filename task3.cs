namespace fuctorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            bool flag = fact(ref a);
            Console.WriteLine(Convert.ToString(flag) + " " + Convert.ToString(a));
        }
        static bool fact(ref int num)
        {
            int c = num;
            num = 1;
            for (int i = 1; i <= c; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch { return false; }
            return true;
        }
    }
}