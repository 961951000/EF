using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// keyword-topic relation
	/// </summary>
	[Table("help_relation")]
	public class HelpRelation
	{
		#region Model
		[Key, Column("help_topic_id", Order = 0)]
		public int? HelpTopicId
		{
			set;
			get;
		}

		[Key, Column("help_keyword_id", Order = 1)]
		public int? HelpKeywordId
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "HelpTopicId=" + HelpTopicId + ",HelpKeywordId=" + HelpKeywordId;
		}
		#endregion Model
	}
}
