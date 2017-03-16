using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// 
	/// </summary>
	[Table("spt_fallback_dev")]
	public class SptFallbackDev
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

		[Column("xfallback_low")]
		public int? XfallbackLow
		{
			set;
			get;
		}

		[Column("xfallback_drive")]
		public string XfallbackDrive
		{
			set;
			get;
		}

		[Column("low")]
		public int? Low
		{
			set;
			get;
		}

		[Column("high")]
		public int? High
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

		[Column("name")]
		public string Name
		{
			set;
			get;
		}

		[Column("phyname")]
		public string Phyname
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "XserverName=" + XserverName + ",XdttmIns=" + XdttmIns + ",XdttmLastInsUpd=" + XdttmLastInsUpd + ",XfallbackLow=" + XfallbackLow + ",XfallbackDrive=" + XfallbackDrive + ",Low=" + Low + ",High=" + High + ",Status=" + Status + ",Name=" + Name + ",Phyname=" + Phyname;
		}
		#endregion Model
	}
}
