using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	[Table("gtid_executed")]
	public class GtidExecuted
	{
		#region Model
		/// <summary>
		/// uuid of the source where the transaction was originally executed.
		/// </summary>
		[Key, Column("source_uuid", Order = 0)]
		public string SourceUuid
		{
			set;
			get;
		}

		/// <summary>
		/// First number of interval.
		/// </summary>
		[Key, Column("interval_start", Order = 1)]
		public long? IntervalStart
		{
			set;
			get;
		}

		/// <summary>
		/// Last number of interval.
		/// </summary>
		[Column("interval_end")]
		public long? IntervalEnd
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "SourceUuid=" + SourceUuid + ",IntervalStart=" + IntervalStart + ",IntervalEnd=" + IntervalEnd;
		}
		#endregion Model
	}
}
