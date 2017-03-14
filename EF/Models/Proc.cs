using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Stored Procedures
	/// </summary>
	[Table("proc")]
	public class Proc
	{
		#region Model
		[Key, Column("db", Order = 0)]
		public string Db
		{
			set;
			get;
		}

		[Key, Column("name", Order = 1)]
		public string Name
		{
			set;
			get;
		}

		[Key, Column("type", Order = 2)]
		public string Type
		{
			set;
			get;
		}

		[Column("specific_name")]
		public string SpecificName
		{
			set;
			get;
		}

		[Column("language")]
		public string Language
		{
			set;
			get;
		}

		[Column("sql_data_access")]
		public string SqlDataAccess
		{
			set;
			get;
		}

		[Column("is_deterministic")]
		public string IsDeterministic
		{
			set;
			get;
		}

		[Column("security_type")]
		public string SecurityType
		{
			set;
			get;
		}

		[Column("param_list")]
		public string ParamList
		{
			set;
			get;
		}

		[Column("returns")]
		public string Returns
		{
			set;
			get;
		}

		[Column("body")]
		public string Body
		{
			set;
			get;
		}

		[Column("definer")]
		public string Definer
		{
			set;
			get;
		}

		[Column("created")]
		public DateTime? Created
		{
			set;
			get;
		}

		[Column("modified")]
		public DateTime? Modified
		{
			set;
			get;
		}

		[Column("sql_mode")]
		public string SqlMode
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

		[Column("character_set_client")]
		public string CharacterSetClient
		{
			set;
			get;
		}

		[Column("collation_connection")]
		public string CollationConnection
		{
			set;
			get;
		}

		[Column("db_collation")]
		public string DbCollation
		{
			set;
			get;
		}

		[Column("body_utf8")]
		public string BodyUtf8
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Db=" + Db + ",Name=" + Name + ",Type=" + Type + ",SpecificName=" + SpecificName + ",Language=" + Language + ",SqlDataAccess=" + SqlDataAccess + ",IsDeterministic=" + IsDeterministic + ",SecurityType=" + SecurityType + ",ParamList=" + ParamList + ",Returns=" + Returns + ",Body=" + Body + ",Definer=" + Definer + ",Created=" + Created + ",Modified=" + Modified + ",SqlMode=" + SqlMode + ",Comment=" + Comment + ",CharacterSetClient=" + CharacterSetClient + ",CollationConnection=" + CollationConnection + ",DbCollation=" + DbCollation + ",BodyUtf8=" + BodyUtf8;
		}
		#endregion Model
	}
}
