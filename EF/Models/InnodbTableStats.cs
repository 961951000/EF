using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	[Table("innodb_table_stats")]
	public class InnodbTableStats
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

		[Column("last_update")]
		public DateTime? LastUpdate
		{
			set;
			get;
		}

		[Column("n_rows")]
		public long? NRows
		{
			set;
			get;
		}

		[Column("clustered_index_size")]
		public long? ClusteredIndexSize
		{
			set;
			get;
		}

		[Column("sum_of_other_index_sizes")]
		public long? SumOfOtherIndexSizes
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "DatabaseName=" + DatabaseName + ",TableName=" + TableName + ",LastUpdate=" + LastUpdate + ",NRows=" + NRows + ",ClusteredIndexSize=" + ClusteredIndexSize + ",SumOfOtherIndexSizes=" + SumOfOtherIndexSizes;
		}
		#endregion Model
	}
}
