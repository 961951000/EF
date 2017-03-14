using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// MySQL Foreign Servers table
	/// </summary>
	[Table("servers")]
	public class Servers
	{
		#region Model
		[Key, Column("Server_name", Order = 0)]
		public string ServerName
		{
			set;
			get;
		}

		[Column("Host")]
		public string Host
		{
			set;
			get;
		}

		[Column("Db")]
		public string Db
		{
			set;
			get;
		}

		[Column("Username")]
		public string Username
		{
			set;
			get;
		}

		[Column("Password")]
		public string Password
		{
			set;
			get;
		}

		[Column("Port")]
		public int? Port
		{
			set;
			get;
		}

		[Column("Socket")]
		public string Socket
		{
			set;
			get;
		}

		[Column("Wrapper")]
		public string Wrapper
		{
			set;
			get;
		}

		[Column("Owner")]
		public string Owner
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "ServerName=" + ServerName + ",Host=" + Host + ",Db=" + Db + ",Username=" + Username + ",Password=" + Password + ",Port=" + Port + ",Socket=" + Socket + ",Wrapper=" + Wrapper + ",Owner=" + Owner;
		}
		#endregion Model
	}
}
