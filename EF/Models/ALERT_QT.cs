using System;

namespace EF.Models
{
    public class ALERT_QT
    {
        public string Q_NAME { get; set; }
        public byte[] MSGID { get; set; }
        public string CORRID { get; set; }
        public decimal PRIORITY { get; set; }
        public decimal STATE { get; set; }
        public DateTime? DELAY { get; set; }
        public decimal EXPIRATION { get; set; }
        public DateTime? TIME_MANAGER_INFO { get; set; }
        public decimal LOCAL_ORDER_NO { get; set; }
        public decimal CHAIN_NO { get; set; }
        public decimal CSCN { get; set; }
        public decimal DSCN { get; set; }
        public string ENQ_TIME { get; set; }
        public string ENQ_UID { get; set; }
        public string ENQ_TID { get; set; }
        public DateTime? DEQ_TIME { get; set; }
        public string DEQ_UID { get; set; }
        public string DEQ_TID { get; set; }
        public decimal RETRY_COUNT { get; set; }
        public string EXCEPTION_QSCHEMA { get; set; }
        public string EXCEPTION_QUEUE { get; set; }
        public decimal STEP_NO { get; set; }
        public decimal RECIPIENT_KEY { get; set; }
        public byte[] DEQUEUE_MSGID { get; set; }
        public string SENDER_NAME { get; set; }
        public string SENDER_ADDRESS { get; set; }
        public decimal SENDER_PROTOCOL { get; set; }
    }
}
