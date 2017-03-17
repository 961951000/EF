using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    [Table("ALERT_QT")]
    public class AlertQt
    {
        [Column("Q_NAME")]
        public string Qname { get; set; }
        [Key, Column("MSGID")]
        public byte[] MsgId { get; set; }
        [Column("CORRID")]
        public string CORRID { get; set; }
        [Column("PRIORITY")]
        public decimal PRIORITY { get; set; }
        [Column("STATE")]
        public decimal STATE { get; set; }
        [Column("DELAY")]
        public DateTime? DELAY { get; set; }
        [Column("EXPIRATION")]
        public decimal Expiration { get; set; }
        [Column("TIME_MANAGER_INFO")]
        public DateTime? TimeManagerInfo { get; set; }
        [Column("LOCAL_ORDER_NO")]
        public decimal LocalOrderNo { get; set; }
        [Column("CHAIN_NO")]
        public decimal ChainNo { get; set; }
        [Column("CSCN")]
        public decimal Cscn { get; set; }
        [Column("DSCN")]
        public decimal Dscn { get; set; }
        [Column("ENQ_TIME")]
        public DateTime? EnqTime { get; set; }
        [Column("ENQ_UID")]
        public string EnqUid { get; set; }
        [Column("ENQ_TID")]
        public string EnqTid { get; set; }
        [Column("DEQ_TIME")]
        public DateTime? DeqTime { get; set; }
        [Column("DEQ_UID")]
        public string DeqUid { get; set; }
        [Column("DEQ_TID")]
        public string DeqTid { get; set; }
        [Column("RETRY_COUNT")]
        public decimal RetryCount { get; set; }
        [Column("EXCEPTION_QSCHEMA")]
        public string ExceptionQschema { get; set; }
        [Column("EXCEPTION_QUEUE")]
        public string ExceptionQuery { get; set; }
        [Column("STEP_NO")]
        public decimal StepNo { get; set; }
        [Column("RECIPIENT_KEY")]
        public decimal RecipientKey { get; set; }
        [Column("DEQUEUE_MSGID")]
        public byte[] DequeueMsgid { get; set; }
        [Column("SENDER_NAME")]
        public string SenderName { get; set; }
        [Column("SENDER_ADDRESS")]
        public string SenderAddress { get; set; }
        [Column("SENDER_PROTOCOL")]
        public decimal SenderProtocol { get; set; }
    }
}
