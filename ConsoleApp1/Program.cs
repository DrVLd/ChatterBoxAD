using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatDataBase;
using Core;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = DBUtils.Login("anar", "parol");

            Console.WriteLine("===============0");
            Console.WriteLine(user);
            Console.WriteLine("============");
            DBUtils.Registration("ppp", "1111");
            Console.ReadKey(true);
        }
    }
}
