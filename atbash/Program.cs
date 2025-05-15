using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace atbash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<char> p = new List<char>() { 'h', 'l', 'o', 'w', ' ', 'b', 'o', 'm', 'b' };
            //Console.WriteLine(DangerousWordSearch(p));
            int DangerousWordSearch(List<char> DecodedList)
            {
                string DecryptedText = "";
                int RiskScore = 0;
                List<string> DangerousWordS = new List<string>() {"bomb", "nukhba", "fighter", "rocket", "secret"};
                foreach (char l in DecodedList)
                {
                    DecryptedText += l;
                }
                string[] DecryptedArr = DecryptedText.Split(' ');
                foreach (string str in DecryptedArr)
                {
                    foreach (string word in DangerousWordS)
                    {
                        if (str.ToLower() == word)
                            RiskScore++;
                    }
                }
                return RiskScore;



            }
        }

    }
}
