using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Time zone transition types
	/// </summary>
	[Table("time_zone_transition_type")]
	public class TimeZoneTransitionType
	{
		#region Model
		[Key, Column("Time_zone_id", Order = 0)]
		public int? TimeZoneId
		{
			set;
			get;
		}

		[Key, Column("Transition_type_id", Order = 1)]
		public int? TransitionTypeId
		{
			set;
			get;
		}

		[Column("Offset")]
		public int? Offset
		{
			set;
			get;
		}

		[Column("Is_DST")]
		public bool? IsDST
		{
			set;
			get;
		}

		[Column("Abbreviation")]
		public string Abbreviation
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "TimeZoneId=" + TimeZoneId + ",TransitionTypeId=" + TransitionTypeId + ",Offset=" + Offset + ",IsDST=" + IsDST + ",Abbreviation=" + Abbreviation;
		}
		#endregion Model
	}
}
