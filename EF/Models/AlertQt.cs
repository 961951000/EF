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
        public string MsgId { get; set; }
        [Key, Column("EXPIRATION")]
        public long? Expiration { get; set; }
    }
}
