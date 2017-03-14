using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// User proxy privileges
	/// </summary>
	[Table("proxies_priv")]
	public class ProxiesPriv
	{
		#region Model
		[Key, Column("Host", Order = 0)]
		public string Host
		{
			set;
			get;
		}

		[Key, Column("User", Order = 1)]
		public string User
		{
			set;
			get;
		}

		[Key, Column("Proxied_host", Order = 2)]
		public string ProxiedHost
		{
			set;
			get;
		}

		[Key, Column("Proxied_user", Order = 3)]
		public string ProxiedUser
		{
			set;
			get;
		}

		[Column("With_grant")]
		public bool? WithGrant
		{
			set;
			get;
		}

		[Column("Grantor")]
		public string Grantor
		{
			set;
			get;
		}

		[Column("Timestamp")]
		public DateTime? Timestamp
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Host=" + Host + ",User=" + User + ",ProxiedHost=" + ProxiedHost + ",ProxiedUser=" + ProxiedUser + ",WithGrant=" + WithGrant + ",Grantor=" + Grantor + ",Timestamp=" + Timestamp;
		}
		#endregion Model
	}
}
