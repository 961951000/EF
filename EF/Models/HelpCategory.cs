using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// help categories
	/// </summary>
	[Table("help_category")]
	public class HelpCategory
	{
		#region Model
		[Key, Column("help_category_id", Order = 0)]
		public short? HelpCategoryId
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

		[Column("parent_category_id")]
		public short? ParentCategoryId
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
			return "HelpCategoryId=" + HelpCategoryId + ",Name=" + Name + ",ParentCategoryId=" + ParentCategoryId + ",Url=" + Url;
		}
		#endregion Model
	}
}
