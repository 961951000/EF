using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EF.DatabaseContext;
using Dapper;
using EF.Models;
using Oracle.ManagedDataAccess.Client;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
            var db = new OracleConnection(connectionString);
            //var db =new OracleContext();
            try
            {
                var list = db.Query<AlertQt>("select * from ALERT_QT");
                //var list = db.AlertQt.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine($"MsgId={item.MsgId};Qname={item.Qname};Expiration={item.Expiration}");
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
