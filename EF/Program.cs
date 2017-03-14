using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EF.DatabaseContext;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MySqlContext();
            try
            {
                var list = db.ProxiesPriv.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine($"Host={item.Host}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Console.WriteLine("EF");
            Console.ReadLine();
        }
    }
}
