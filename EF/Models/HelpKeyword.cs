using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// help keywords
	/// </summary>
	[Table("help_keyword")]
	public class HelpKeyword
	{
		#region Model
		[Key, Column("help_keyword_id", Order = 0)]
		public int? HelpKeywordId
		{
			set;
			get;
		}

		[Column("name")]
		public string Name
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "HelpKeywordId=" + HelpKeywordId + ",Name=" + Name;
		}
		#endregion Model
	}
}
