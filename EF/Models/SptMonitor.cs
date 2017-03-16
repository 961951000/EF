using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// 
	/// </summary>
	[Table("spt_monitor")]
	public class SptMonitor
	{
		#region Model
		[Column("lastrun")]
		public DateTime? Lastrun
		{
			set;
			get;
		}

		[Column("cpu_busy")]
		public int? CpuBusy
		{
			set;
			get;
		}

		[Column("io_busy")]
		public int? IoBusy
		{
			set;
			get;
		}

		[Column("idle")]
		public int? Idle
		{
			set;
			get;
		}

		[Column("pack_received")]
		public int? PackReceived
		{
			set;
			get;
		}

		[Column("pack_sent")]
		public int? PackSent
		{
			set;
			get;
		}

		[Column("connections")]
		public int? Connections
		{
			set;
			get;
		}

		[Column("pack_errors")]
		public int? PackErrors
		{
			set;
			get;
		}

		[Column("total_read")]
		public int? TotalRead
		{
			set;
			get;
		}

		[Column("total_write")]
		public int? TotalWrite
		{
			set;
			get;
		}

		[Column("total_errors")]
		public int? TotalErrors
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Lastrun=" + Lastrun + ",CpuBusy=" + CpuBusy + ",IoBusy=" + IoBusy + ",Idle=" + Idle + ",PackReceived=" + PackReceived + ",PackSent=" + PackSent + ",Connections=" + Connections + ",PackErrors=" + PackErrors + ",TotalRead=" + TotalRead + ",TotalWrite=" + TotalWrite + ",TotalErrors=" + TotalErrors;
		}
		#endregion Model
	}
}
