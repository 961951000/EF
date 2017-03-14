using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Time zone transitions
	/// </summary>
	[Table("time_zone_transition")]
	public class TimeZoneTransition
	{
		#region Model
		[Key, Column("Time_zone_id", Order = 0)]
		public int? TimeZoneId
		{
			set;
			get;
		}

		[Key, Column("Transition_time", Order = 1)]
		public long? TransitionTime
		{
			set;
			get;
		}

		[Column("Transition_type_id")]
		public int? TransitionTypeId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "TimeZoneId=" + TimeZoneId + ",TransitionTime=" + TransitionTime + ",TransitionTypeId=" + TransitionTypeId;
		}
		#endregion Model
	}
}
