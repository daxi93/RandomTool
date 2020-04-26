using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTool
{
    public class RandomStringUtil
    {
        private readonly static string num = "0123456789";
        private readonly static string lowercase = "abcdefghijklmnopqrstuvwxyz";
        private readonly static string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly static string alphabet = lowercase + uppercase;
        private readonly static string alphNum = lowercase + uppercase + num;
        private static Random rd = new Random(Guid.NewGuid().GetHashCode());

        public static string next()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append(0).Append(rd.Next(5)).Append(3).Append(randomAlphabet(1)).Append(randomAlphabetNum(28));
            //return sb.ToString();
            return randomAlphabetNum(32);
        }

        public static string randomNum(int lenght)
        {
            StringBuilder sb = new StringBuilder();
            for (int i =0;i<lenght;i++)
            {
                var index = rd.Next(num.Length);
                sb.Append(num[index]);
            }
            return sb.ToString();
        }

        public static string randomAlphabet(int lenght)
        {
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lenght; i++)
            {
                var index = rd.Next(alphabet.Length);
                sb.Append(alphabet[index]);
            }
            return sb.ToString();
        }

        public static string randomAlphabetNum(int lenght)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lenght; i++)
            {
                var index = rd.Next(alphNum.Length);
                sb.Append(alphNum[index]);
            }
            return sb.ToString();
        }
    }
}
