using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Reflection;
using System.Net;

//Не разобрался в рефлексии
namespace Test
{
    class Program
    {
        static void DoSecondTask(Type type)
        {
            char[] consonants = "qwrtpsdfghjklzxcvbnm".ToArray();
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo e in methods)
            {
                int count = 0;
                foreach (char c in e.Name.ToLower())
                {
                    if (consonants.Contains(c)) count++;
                }
                if (count % 2 == 0) Console.WriteLine(e.Name);
            }

        }

        static void DoFirstTask()
        {
            string url = "https://jsonplaceholder.typicode.com/photos";
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, AppDomain.CurrentDomain.BaseDirectory + "test.jpg");
            }
            ;
        }
    }
}
