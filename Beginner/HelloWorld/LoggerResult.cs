using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class LoggerResult
{
    public void GetUniqueError()
    {
            //string fileDir=@"C:\Users\Rakesh\Documents\CIGNA\2ndJuly\h18612\";
            var AllDir= Directory.GetDirectories(@"C:\Users\Rakesh\Documents\CIGNA\2ndJuly\");


            foreach(string s in AllDir)
            {
            DirectoryInfo di = new DirectoryInfo(s);
            string name=di.Name;

           switch(name)
           {
               case "c82423":
               Console.WriteLine(" c8423 has experienced sluggishness and uncontrollable mouse");
               break;
               case "h13789":
               Console.WriteLine("h13789 has not reported any issues since day 1");
               break;
                case "h18612":
               Console.WriteLine("h18612 has experienced issues with sluggishness and erratic move behaviors since day 1");
               break;
               
           }


            Console.WriteLine("*************"+name+"*****************");
            var listerrorFileList1=di.GetFiles("listener*");
            var auterrorFileList1=di.GetFiles("automation*");
            var watcherrorFileList1=di.GetFiles("watchdog*");
            List<string> userAllError= new List<string>();
            foreach(var file in watcherrorFileList1)
            {
                string[]  allLines = File.ReadAllLines(file.ToString());
                var errors=Array.FindAll(allLines,x=>x.Contains("error")).ToList();
                userAllError.AddRange(errors);
            }
            var listErrorList=userAllError.Select(s=>s.Substring(27));
            Console.WriteLine("TOTAL ERROR:"+listErrorList.Count());
            Console.WriteLine("DISTINCT ERROR:"+listErrorList.Distinct().Count());
            var userErrorGorup=listErrorList.GroupBy(i=>i).Select(group=>new{group.Key,Count=group.Count()}).ToList();
            userErrorGorup.ForEach(s=>{
                Console.WriteLine(s.Key+"-"+s.Count);
                });
            }
    }
}