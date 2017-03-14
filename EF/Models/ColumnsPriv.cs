using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Column privileges
	/// </summary>
	[Table("columns_priv")]
	public class ColumnsPriv
	{
		#region Model
		[Key, Column("Host", Order = 0)]
		public string Host
		{
			set;
			get;
		}

		[Key, Column("Db", Order = 1)]
		public string Db
		{
			set;
			get;
		}

		[Key, Column("User", Order = 2)]
		public string User
		{
			set;
			get;
		}

		[Key, Column("Table_name", Order = 3)]
		public string TableName
		{
			set;
			get;
		}

		[Key, Column("Column_name", Order = 4)]
		public string ColumnName
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

		[Column("Column_priv")]
		public string ColumnPriv
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Host=" + Host + ",Db=" + Db + ",User=" + User + ",TableName=" + TableName + ",ColumnName=" + ColumnName + ",Timestamp=" + Timestamp + ",ColumnPriv=" + ColumnPriv;
		}
		#endregion Model
	}
}
