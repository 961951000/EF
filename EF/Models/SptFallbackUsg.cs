using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// 
	/// </summary>
	[Table("spt_fallback_usg")]
	public class SptFallbackUsg
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

		[Column("xfallback_vstart")]
		public int? XfallbackVstart
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

		[Column("segmap")]
		public int? Segmap
		{
			set;
			get;
		}

		[Column("lstart")]
		public int? Lstart
		{
			set;
			get;
		}

		[Column("sizepg")]
		public int? Sizepg
		{
			set;
			get;
		}

		[Column("vstart")]
		public int? Vstart
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "XserverName=" + XserverName + ",XdttmIns=" + XdttmIns + ",XdttmLastInsUpd=" + XdttmLastInsUpd + ",XfallbackVstart=" + XfallbackVstart + ",Dbid=" + Dbid + ",Segmap=" + Segmap + ",Lstart=" + Lstart + ",Sizepg=" + Sizepg + ",Vstart=" + Vstart;
		}
		#endregion Model
	}
}
