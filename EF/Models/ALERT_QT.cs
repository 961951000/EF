using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
    public class ALERT_QT
    {
        public string Q_NAME { get; set; }
        public byte[] MSGID { get; set; }
        public string EXPIRATION { get; set; }
    }
}
