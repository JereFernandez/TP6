using System;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            SuiteTests test = new SuiteTests();

            test.Pruebasignout();

            test.Dispose();
        }
    }
}
