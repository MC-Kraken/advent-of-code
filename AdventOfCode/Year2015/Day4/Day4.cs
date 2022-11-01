using System.Security.Cryptography;
using System.Text;

namespace Year2015.Day4;

public class Day4
{
    private const string Input = "bgvyzdsv";

    public static void AdventCoinMining()
    {
        var number = 0;
        var flag = true;
        var md5 = MD5.Create();

        while (flag)
        {
            var byteArray = Encoding.UTF8.GetBytes(Input + number);
            var hash = md5.ComputeHash(byteArray);
            var convertedHash = Convert.ToHexString(hash);

            Console.WriteLine("checking hash with " + number);
            Console.WriteLine("first five: " + convertedHash[0] + convertedHash[1] + convertedHash[2] + convertedHash[3] +
                              convertedHash[4]);
            
            if (convertedHash.StartsWith("00000"))
            {
                
                flag = false;
                Console.WriteLine("you did it!!! Here's the answer: " + number);
            }
            else
            {
                number++;
            }
        }

        
        Console.WriteLine(number);
    }
}