using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Time zones
	/// </summary>
	[Table("time_zone")]
	public class TimeZone
	{
		#region Model
		[Key, Column("Time_zone_id", Order = 0)]
		public int? TimeZoneId
		{
			set;
			get;
		}

		[Column("Use_leap_seconds")]
		public string UseLeapSeconds
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "TimeZoneId=" + TimeZoneId + ",UseLeapSeconds=" + UseLeapSeconds;
		}
		#endregion Model
	}
}
