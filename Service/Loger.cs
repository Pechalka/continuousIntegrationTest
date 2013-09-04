using System;
using System.IO;

namespace Service
{
    public class Loger
    {
        const string Path = @"c:\Work\integration\MegaProject\Service\test.txt";
            
        public static void AddLog(string message)
        {
            using (StreamWriter sw = File.AppendText(Path))
            {
                var now = DateTime.Now.ToString("dd/MM/yyyy");
                sw.WriteLine(string.Format("{0} : {1}", now, message));
            }
        }
    }
}
