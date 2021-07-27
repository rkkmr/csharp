using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LoggerResult loggerResult= new LoggerResult();
            loggerResult.GetUniqueError();
        }
    }
}
