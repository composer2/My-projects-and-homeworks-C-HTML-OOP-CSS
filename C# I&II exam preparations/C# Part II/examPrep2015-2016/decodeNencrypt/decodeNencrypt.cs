using System;
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
            var rawMessage = Console.ReadLine();
            var cypherLenght = "";
            for (int i = rawMessage.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(rawMessage[i]))
                {
                    cypherLenght = rawMessage[i] + cypherLenght;
                }
                else
                {
                    break;
                }
            }
            int cypherAsNum = int.Parse(cypherLenght);
            var messageAndCypher = new StringBuilder();

            for (int i = 0; i < rawMessage.Length - cypherLenght.Length; i++)
            {
                messageAndCypher.Append(rawMessage[i]);
            }

            var encryptedMessageAndCypher = new StringBuilder();
            var numLetters = 0;
            for (int i = 0; i < messageAndCypher.Length; i++)
            {
                if (char.IsDigit(messageAndCypher[i]))
                {
                    numLetters *= 10;
                    numLetters += int.Parse(messageAndCypher[i].ToString());
                }
                else
                {
                    if (numLetters == 0)
                    {
                        encryptedMessageAndCypher.Append(messageAndCypher[i]);
                    }
                    else
                    {
                        encryptedMessageAndCypher.Append(messageAndCypher[i], numLetters);
                        numLetters = 0;
                    }
                }
            }
            var message = new StringBuilder();
            var cypher = new StringBuilder();
            for (int i = 0; i < encryptedMessageAndCypher.Length; i++)
            {
                if (i < encryptedMessageAndCypher.Length - cypherAsNum)
                {
                    message.Append(encryptedMessageAndCypher[i]);
                }
                else
                {
                    cypher.Append(encryptedMessageAndCypher[i]);
                }
            }
            var result = Encrypt(message.ToString().ToUpper(), cypher.ToString().ToUpper());
            Console.WriteLine(result);
        }

        private static string Encrypt(string message, string cypher)
        {
            var result = new StringBuilder();
            var result2 = new StringBuilder(message);

            if (message.Length >= cypher.Length)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    char messageSymbol = message[i];
                    char cypherSymbol = cypher[i % cypher.Length];
                    result.Append((char)(((messageSymbol - 'A') ^ (cypherSymbol - 'A')) + 'A'));
                }
            }
            else if (cypher.Length > message.Length)
            {
                for (int i = 0; i < cypher.Length; i++)
                {
                    var messageSymbol = result2[i % message.Length];
                    char cypherSymbol = cypher[i];
                    char XOR = (char)(((messageSymbol - 'A') ^ (cypherSymbol - 'A')) + 'A');
                    result2[i % message.Length] = XOR;
                }
                return result2.ToString();
            }
            return result.ToString();
        }
    }
}