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
