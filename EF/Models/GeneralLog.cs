using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// General log
	/// </summary>
	[Table("general_log")]
	public class GeneralLog
	{
		#region Model
		[Column("event_time")]
		public DateTime? EventTime
		{
			set;
			get;
		}

		[Column("user_host")]
		public string UserHost
		{
			set;
			get;
		}

		[Column("thread_id")]
		public long? ThreadId
		{
			set;
			get;
		}

		[Column("server_id")]
		public int? ServerId
		{
			set;
			get;
		}

		[Column("command_type")]
		public string CommandType
		{
			set;
			get;
		}

		[Column("argument")]
		public string Argument
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "EventTime=" + EventTime + ",UserHost=" + UserHost + ",ThreadId=" + ThreadId + ",ServerId=" + ServerId + ",CommandType=" + CommandType + ",Argument=" + Argument;
		}
		#endregion Model
	}
}
