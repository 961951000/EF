using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	[Table("server_cost")]
	public class ServerCost
	{
		#region Model
		[Key, Column("cost_name", Order = 0)]
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
			return "CostName=" + CostName + ",CostValue=" + CostValue + ",LastUpdate=" + LastUpdate + ",Comment=" + Comment;
		}
		#endregion Model
	}
}
