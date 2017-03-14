using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// help topics
	/// </summary>
	[Table("help_topic")]
	public class HelpTopic
	{
		#region Model
		[Key, Column("help_topic_id", Order = 0)]
		public int? HelpTopicId
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

		[Column("help_category_id")]
		public short? HelpCategoryId
		{
			set;
			get;
		}

		[Column("description")]
		public string Description
		{
			set;
			get;
		}

		[Column("example")]
		public string Example
		{
			set;
			get;
		}

		[Column("url")]
		public string Url
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "HelpTopicId=" + HelpTopicId + ",Name=" + Name + ",HelpCategoryId=" + HelpCategoryId + ",Description=" + Description + ",Example=" + Example + ",Url=" + Url;
		}
		#endregion Model
	}
}
