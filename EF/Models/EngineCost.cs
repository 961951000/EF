using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	[Table("engine_cost")]
	public class EngineCost
	{
		#region Model
		[Key, Column("engine_name", Order = 0)]
		public string EngineName
		{
			set;
			get;
		}

		[Key, Column("device_type", Order = 1)]
		public int? DeviceType
		{
			set;
			get;
		}

		[Key, Column("cost_name", Order = 2)]
		public string CostName
		{
			set;
			get;
		}

		[Column("cost_value")]
		public string CostValue
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

		[Column("comment")]
		public string Comment
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "EngineName=" + EngineName + ",DeviceType=" + DeviceType + ",CostName=" + CostName + ",CostValue=" + CostValue + ",LastUpdate=" + LastUpdate + ",Comment=" + Comment;
		}
		#endregion Model
	}
}
