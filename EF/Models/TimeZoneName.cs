using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Time zone names
	/// </summary>
	[Table("time_zone_name")]
	public class TimeZoneName
	{
		#region Model
		[Key, Column("Name", Order = 0)]
		public string Name
		{
			set;
			get;
		}

		[Column("Time_zone_id")]
		public int? TimeZoneId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Name=" + Name + ",TimeZoneId=" + TimeZoneId;
		}
		#endregion Model
	}
}
