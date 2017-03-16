using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// 
	/// </summary>
	[Table("spt_fallback_db")]
	public class SptFallbackDb
	{
		#region Model
		[Column("xserver_name")]
		public string XserverName
		{
			set;
			get;
		}

		[Column("xdttm_ins")]
		public DateTime? XdttmIns
		{
			set;
			get;
		}

		[Column("xdttm_last_ins_upd")]
		public DateTime? XdttmLastInsUpd
		{
			set;
			get;
		}

		[Column("xfallback_dbid")]
		public short? XfallbackDbid
		{
			set;
			get;
		}

		[Column("name")]
		public string Name
		{
			set;
			get;
		}

		[Column("dbid")]
		public short? Dbid
		{
			set;
			get;
		}

		[Column("status")]
		public short? Status
		{
			set;
			get;
		}

		[Column("version")]
		public short? Version
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "XserverName=" + XserverName + ",XdttmIns=" + XdttmIns + ",XdttmLastInsUpd=" + XdttmLastInsUpd + ",XfallbackDbid=" + XfallbackDbid + ",Name=" + Name + ",Dbid=" + Dbid + ",Status=" + Status + ",Version=" + Version;
		}
		#endregion Model
	}
}
