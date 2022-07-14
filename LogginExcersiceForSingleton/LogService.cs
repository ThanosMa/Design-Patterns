using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogginExcersiceForSingleton
{
    public class LogService
    {
        public void WriteToLog(string message)
        {
            string path = "calendar.txt";
            var date = DateTime.Now.ToString("d");
            var finalMessage = $"Date: {date} - {message}";
            string[] messages = { finalMessage };

            File.AppendAllLines(path, messages);
        }

        public void ReadFromLog()
        {
            string path = "calendar.txt";
            foreach (var item in File.ReadAllLines(path))
            {
                Console.WriteLine(item);
            }
        }

        //Singleton Architecture
        private static object lockObject = new Object();
        private static volatile LogService instance;   //Backfield
        public static LogService CreateLog
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                            instance = new LogService();
                    }
                }
                return instance;
            }
        }
        private LogService() { }
    }
}
