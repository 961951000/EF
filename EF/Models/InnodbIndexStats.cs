using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	[Table("innodb_index_stats")]
	public class InnodbIndexStats
	{
		#region Model
		[Key, Column("database_name", Order = 0)]
		public string DatabaseName
		{
			set;
			get;
		}

		[Key, Column("table_name", Order = 1)]
		public string TableName
		{
			set;
			get;
		}

		[Key, Column("index_name", Order = 2)]
		public string IndexName
		{
			set;
			get;
		}

		[Column("last_update")]
		public DateTime? LastUpdate
		{
			set;
			get;
		}

		[Key, Column("stat_name", Order = 3)]
		public string StatName
		{
			set;
			get;
		}

		[Column("stat_value")]
		public long? StatValue
		{
			set;
			get;
		}

		[Column("sample_size")]
		public long? SampleSize
		{
			set;
			get;
		}

		[Column("stat_description")]
		public string StatDescription
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "DatabaseName=" + DatabaseName + ",TableName=" + TableName + ",IndexName=" + IndexName + ",LastUpdate=" + LastUpdate + ",StatName=" + StatName + ",StatValue=" + StatValue + ",SampleSize=" + SampleSize + ",StatDescription=" + StatDescription;
		}
		#endregion Model
	}
}
