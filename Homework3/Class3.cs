namespace Homework3
{
    internal class Class3
    {
        int num;
        int res;
        public void input()
        {
            Console.WriteLine("Input number between 100-999: ");
            num = int.Parse(Console.ReadLine());
            if (num < 100 || num > 999)
            {
                Console.WriteLine("Input number between 100-999: ");
                return;
            }
            while (num != 0)
            {
                int digit = num % 10;
                res = res * 10 + digit;
                num /= 10;
            }

        }
        public void output()
        {

            Console.WriteLine("This is the sum of Digit: {0}", res);

        }



    }
}
