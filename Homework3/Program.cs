// See https://aka.ms/new-console-template for more information


namespace Homework3

{
    class Program
    {
        static int DEBUG = 3;

        static void Main()
        {
            if (DEBUG == 1)
            {
                Class1 test = new Class1();
                test.input();
                test.output();
            }
            else if (DEBUG == 2)
            {
                Class2 test = new Class2();
                test.input();
                test.output();

            }
            else if (DEBUG == 3)
            {
                Class3 test = new Class3();
                test.input();
                test.output();

            }

        }
    }
}
