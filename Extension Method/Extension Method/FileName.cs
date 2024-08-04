using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Extension_Method
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("아이디를 입력하세요 : ");
            string id = Console.ReadLine();

            if (id.IsAllowedID())
            {
                Console.WriteLine("ID가 유효합니다.");
            }
            else
            {
                Console.WriteLine("ID에 허용되지 않는 특수문자가 있습니다.");
            }
        }

    }
    static class IsAllowed
    {

        public static bool IsAllowedID(this string id)
        {
            
            char[] special = new char[] { '!', '@', '#', '$', '%', '^', '&', '*' };
            for (int i = 0; i < id.Length; i++)
            {
                for (int j = 0; j < special.Length; j++)
                    if (id[i] == special[j])
                    {
                        return false;
                    }
            }
            return true;
        }

    }
}

    


