using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
            try
            {
                switch (ConfigurationManager.AppSettings["config"])
                {
                    case "0":
                        {
                            var connectionString = ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
                            var db = new OracleConnection(connectionString);
                            var query = db.Query<ALERT_QT>("select MSGID,Q_NAME,EXPIRATION from ALERT_QT");
                            foreach (var item in query)
                            {
                                Console.WriteLine($"MsgId={item.MSGID[0]};Qname={item.Q_NAME};Expiration={item.EXPIRATION}");
                            }
                        }
                        break;
                    case "1":
                        {
                            var db = new OracleContext();
                            var query = db.AlertQt;
                            foreach (var item in query)
                            {
                                Console.WriteLine($"MsgId={item.MsgId[0]};Qname={item.Qname};Expiration={item.Expiration}");
                            }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("default...");
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("EF");
            Console.ReadLine();
        }
    }
}
