using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Leap seconds information for time zones
	/// </summary>
	[Table("time_zone_leap_second")]
	public class TimeZoneLeapSecond
	{
		#region Model
		[Key, Column("Transition_time", Order = 0)]
		public long? TransitionTime
		{
			set;
			get;
		}

		[Column("Correction")]
		public int? Correction
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "TransitionTime=" + TransitionTime + ",Correction=" + Correction;
		}
		#endregion Model
	}
}
