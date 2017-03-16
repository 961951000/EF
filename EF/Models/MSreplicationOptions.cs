using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Table("MSreplication_options")]
    public class MSreplicationOptions
    {
        #region Model
        [Column("optname")]
        public string Optname
        {
            set;
            get;
        }

        [Column("value")]
        public bool Value
        {
            set;
            get;
        }

        [Column("major_version")]
        public int? MajorVersion
        {
            set;
            get;
        }

        [Column("minor_version")]
        public int? MinorVersion
        {
            set;
            get;
        }

        [Column("revision")]
        public int? Revision
        {
            set;
            get;
        }

        [Column("install_failures")]
        public int? InstallFailures
        {
            set;
            get;
        }

        public override string ToString()
        {
            return "Optname=" + Optname + ",Value=" + Value + ",MajorVersion=" + MajorVersion + ",MinorVersion=" + MinorVersion + ",Revision=" + Revision + ",InstallFailures=" + InstallFailures;
        }
        #endregion Model
    }
}
