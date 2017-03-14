using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Slow log
	/// </summary>
	[Table("slow_log")]
	public class SlowLog
	{
		#region Model
		[Column("start_time")]
		public DateTime? StartTime
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

		[Column("query_time")]
		public string QueryTime
		{
			set;
			get;
		}

		[Column("lock_time")]
		public string LockTime
		{
			set;
			get;
		}

		[Column("rows_sent")]
		public int? RowsSent
		{
			set;
			get;
		}

		[Column("rows_examined")]
		public int? RowsExamined
		{
			set;
			get;
		}

		[Column("db")]
		public string Db
		{
			set;
			get;
		}

		[Column("last_insert_id")]
		public int? LastInsertId
		{
			set;
			get;
		}

		[Column("insert_id")]
		public int? InsertId
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

		[Column("sql_text")]
		public string SqlText
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

		public override string ToString()
		{
			return "StartTime=" + StartTime + ",UserHost=" + UserHost + ",QueryTime=" + QueryTime + ",LockTime=" + LockTime + ",RowsSent=" + RowsSent + ",RowsExamined=" + RowsExamined + ",Db=" + Db + ",LastInsertId=" + LastInsertId + ",InsertId=" + InsertId + ",ServerId=" + ServerId + ",SqlText=" + SqlText + ",ThreadId=" + ThreadId;
		}
		#endregion Model
	}
}
