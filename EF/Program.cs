using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using EF.DatabaseContext;
using Dapper;
using EF.Models;
using Oracle.ManagedDataAccess.Client;
using System.Reflection;

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
                            var query = db.Query<ALERT_QT>("SELECT Q_NAME,MSGID,CORRID,PRIORITY,STATE,DELAY,EXPIRATION,TIME_MANAGER_INFO,LOCAL_ORDER_NO,CHAIN_NO,CSCN,DSCN,ENQ_TIME,ENQ_UID,ENQ_TID,DEQ_TIME,DEQ_UID,DEQ_TID,RETRY_COUNT,EXCEPTION_QSCHEMA,EXCEPTION_QUEUE,STEP_NO,RECIPIENT_KEY,DEQUEUE_MSGID,SENDER_NAME,SENDER_ADDRESS,SENDER_PROTOCOL FROM ALERT_QT").ToList();
                            var type = typeof(ALERT_QT);
                            foreach (var item in query)
                            {
                                foreach (var finfos in type.GetProperties())
                                {
                                    Console.WriteLine($"{finfos.Name}={type.GetProperty(finfos.Name).GetValue(item, null)}");
                                }
                                Console.WriteLine("-------------------华丽的分隔符-------------------");
                            }
                        }
                        break;
                    case "1":
                        {
                            var db = new OracleContext();
                            var query = db.AlertQt.ToList();
                            var type = typeof(AlertQt);
                            foreach (var item in query)
                            {
                                foreach (var finfos in type.GetProperties())
                                {
                                    Console.WriteLine($"{finfos.Name}={type.GetProperty(finfos.Name).GetValue(item, null)}");
                                }
                                Console.WriteLine("-------------------华丽的分隔符-------------------");
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
