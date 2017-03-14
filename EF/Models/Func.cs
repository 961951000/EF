using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// User defined functions
	/// </summary>
	[Table("func")]
	public class Func
	{
		#region Model
		[Key, Column("name", Order = 0)]
		public string Name
		{
			set;
			get;
		}

		[Column("ret")]
		public bool? Ret
		{
			set;
			get;
		}

		[Column("dl")]
		public string Dl
		{
			set;
			get;
		}

		[Column("type")]
		public string Type
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Name=" + Name + ",Ret=" + Ret + ",Dl=" + Dl + ",Type=" + Type;
		}
		#endregion Model
	}
}
