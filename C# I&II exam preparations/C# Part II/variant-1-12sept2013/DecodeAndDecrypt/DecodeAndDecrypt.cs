﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDecrypt
{
    class DecodeAndDecrypt
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var digits = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(input[i]))
                {
                    //digits.Add(int.Parse(input[i].ToString()));
                    digits.Add(input[i] - '0');
                }
                else
                {
                    break;
                }
            }
            digits.Reverse();
            int lengthOfCypher = 0;
            foreach (var digit in digits)
            {
                lengthOfCypher *= 10;
                lengthOfCypher += digit;
            }

            var encodedMessage = input.Substring(0, input.Length - digits.Count);
            var decodedMessage = Decode(encodedMessage);

            var encryptedMessage = decodedMessage.Substring(0, decodedMessage.Length-lengthOfCypher);
            var cypher = decodedMessage.Substring(decodedMessage.Length-lengthOfCypher,lengthOfCypher);

            var result = Encrypt(encryptedMessage, cypher);
            Console.WriteLine(result);
        }

        public static string Encrypt(string encryptedMessage, string cypher)
        {
            var result = new StringBuilder(encryptedMessage);
            var steps = Math.Max(encryptedMessage.Length, cypher.Length);
            for (int step = 0; step < steps; step++)
            {
                var encryptedMessageIndex = step % encryptedMessage.Length;
                var cypherIndex = step % cypher.Length;
            result[encryptedMessageIndex]= (char)(((result[encryptedMessageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
            }
            return result.ToString();
        }

        public static string Decode(string encodedMessage)
        {
            var result = new StringBuilder();
            var count = 0;
            foreach (var ch in encodedMessage)
            {
                if (char.IsDigit(ch))
                {
                    count *= 10;
                    count += int.Parse(ch.ToString());
                }
                else
                {
                    if (count==0)
                    {
                        result.Append(ch);
                    }
                    else
                    {
                        result.Append(ch, count);
                        count = 0;
                    }
                }
            }

            return result.ToString();
        }
    }
}
