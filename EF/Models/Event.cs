using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Events
	/// </summary>
	[Table("event")]
	public class Event
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

		[Column("execute_at")]
		public DateTime? ExecuteAt
		{
			set;
			get;
		}

		[Column("interval_value")]
		public int? IntervalValue
		{
			set;
			get;
		}

		[Column("interval_field")]
		public string IntervalField
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

		[Column("last_executed")]
		public DateTime? LastExecuted
		{
			set;
			get;
		}

		[Column("starts")]
		public DateTime? Starts
		{
			set;
			get;
		}

		[Column("ends")]
		public DateTime? Ends
		{
			set;
			get;
		}

		[Column("status")]
		public string Status
		{
			set;
			get;
		}

		[Column("on_completion")]
		public string OnCompletion
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

		[Column("originator")]
		public int? Originator
		{
			set;
			get;
		}

		[Column("time_zone")]
		public string TimeZone
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
			return "Db=" + Db + ",Name=" + Name + ",Body=" + Body + ",Definer=" + Definer + ",ExecuteAt=" + ExecuteAt + ",IntervalValue=" + IntervalValue + ",IntervalField=" + IntervalField + ",Created=" + Created + ",Modified=" + Modified + ",LastExecuted=" + LastExecuted + ",Starts=" + Starts + ",Ends=" + Ends + ",Status=" + Status + ",OnCompletion=" + OnCompletion + ",SqlMode=" + SqlMode + ",Comment=" + Comment + ",Originator=" + Originator + ",TimeZone=" + TimeZone + ",CharacterSetClient=" + CharacterSetClient + ",CollationConnection=" + CollationConnection + ",DbCollation=" + DbCollation + ",BodyUtf8=" + BodyUtf8;
		}
		#endregion Model
	}
}
