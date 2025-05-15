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
          Console.WriteLine("Risk Score:" + DangerousWordSearch(Encryption("Gsv jfrxp yildm ylny qfhg")));
          
          
            // A function that decodes the compass
            List<char> Encryption(string compass)
            {
                List<char> deciphered = new List<char>();
                Dictionary<char, char> atbash = new Dictionary<char, char> ()
                {
                    {'A', 'Z'}, {'B', 'Y'}, {'C', 'X'}, {'D', 'W'}, {'E', 'V'},
                    {'F', 'U'}, {'G', 'T'}, {'H', 'S'}, {'I', 'R'}, {'J', 'Q'},
                    {'K', 'P'}, {'L', 'O'}, {'M', 'N'}, {'N', 'M'}, {'O', 'L'},
                    {'P', 'K'}, {'Q', 'J'}, {'R', 'I'}, {'S', 'H'}, {'T', 'G'},
                    {'U', 'F'}, {'V', 'E'}, {'W', 'D'}, {'X', 'C'}, {'Y', 'B'}, {'Z', 'A'},

                    {'a', 'z'}, {'b', 'y'}, {'c', 'x'}, {'d', 'w'}, {'e', 'v'},
                    {'f', 'u'}, {'g', 't'}, {'h', 's'}, {'i', 'r'}, {'j', 'q'},
                    {'k', 'p'}, {'l', 'o'}, {'m', 'n'}, {'n', 'm'}, {'o', 'l'},
                    {'p', 'k'}, {'q', 'j'}, {'r', 'i'}, {'s', 'h'}, {'t', 'g'},
                    {'u', 'f'}, {'v', 'e'}, {'w', 'd'}, {'x', 'c'}, {'y', 'b'}, {'z', 'a'}, {' ' , ' ' }
                };
                foreach (char c in compass)
                {
                   deciphered.Add(atbash[c]);
                }
                foreach (char c in deciphered)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                return deciphered;
                }
        
          
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
