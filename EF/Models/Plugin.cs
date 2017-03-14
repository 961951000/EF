using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// MySQL plugins
	/// </summary>
	[Table("plugin")]
	public class Plugin
	{
		#region Model
		[Key, Column("name", Order = 0)]
		public string Name
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

		public override string ToString()
		{
			return "Name=" + Name + ",Dl=" + Dl;
		}
		#endregion Model
	}
}
