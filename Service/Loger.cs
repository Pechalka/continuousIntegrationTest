using System;
using System.IO;
using System.Reflection;

namespace Service
{
    public class Loger
    {
        private static readonly string Path = Assembly.GetAssembly(typeof (Loger)).Location.Replace("Service.exe", "log.txt");
            
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
