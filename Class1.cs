using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    public static class ConsoleAndFile
    {
        public static string path = @"C:\\Users\\Umschueler\\source\\repos\\Konsole\\Konsole\\log.txt";

        public static void WriteLine(string text)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(text);
            }

            Console.WriteLine(text);
        }
        public static string ReadLine(string prefix = "")
        {
            string question = $"{prefix} ";

            Console.Write(question);
            string answer = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write(question + answer);
            }

            return answer;
        }

    }
}
