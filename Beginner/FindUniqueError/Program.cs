using System;
using System.IO;

namespace FindUniqueError
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string fileDir=@"C:\Users\Rakesh\Documents\CIGNA\2ndJuly\h18612";
            var errorFileList=Directory.GetFiles(fileDir,".*listener.*");
            foreach(var file in errorFileList)
            {
                Console.WriteLine(file);

            }
        }
    }
}
