using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Relay Log Information
	/// </summary>
	[Table("slave_relay_log_info")]
	public class SlaveRelayLogInfo
	{
		#region Model
		/// <summary>
		/// Number of lines in the file or rows in the table. Used to version table definitions.
		/// </summary>
		[Column("Number_of_lines")]
		public int? NumberOfLines
		{
			set;
			get;
		}

		/// <summary>
		/// The name of the current relay log file.
		/// </summary>
		[Column("Relay_log_name")]
		public string RelayLogName
		{
			set;
			get;
		}

		/// <summary>
		/// The relay log position of the last executed event.
		/// </summary>
		[Column("Relay_log_pos")]
		public long? RelayLogPos
		{
			set;
			get;
		}

		/// <summary>
		/// The name of the master binary log file from which the events in the relay log file were read.
		/// </summary>
		[Column("Master_log_name")]
		public string MasterLogName
		{
			set;
			get;
		}

		/// <summary>
		/// The master log position of the last executed event.
		/// </summary>
		[Column("Master_log_pos")]
		public long? MasterLogPos
		{
			set;
			get;
		}

		/// <summary>
		/// The number of seconds that the slave must lag behind the master.
		/// </summary>
		[Column("Sql_delay")]
		public int? SqlDelay
		{
			set;
			get;
		}

		[Column("Number_of_workers")]
		public int? NumberOfWorkers
		{
			set;
			get;
		}

		/// <summary>
		/// Internal Id that uniquely identifies this record.
		/// </summary>
		[Column("Id")]
		public int? Id
		{
			set;
			get;
		}

		/// <summary>
		/// The channel on which the slave is connected to a source. Used in Multisource Replication
		/// </summary>
		[Key, Column("Channel_name", Order = 0)]
		public string ChannelName
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "NumberOfLines=" + NumberOfLines + ",RelayLogName=" + RelayLogName + ",RelayLogPos=" + RelayLogPos + ",MasterLogName=" + MasterLogName + ",MasterLogPos=" + MasterLogPos + ",SqlDelay=" + SqlDelay + ",NumberOfWorkers=" + NumberOfWorkers + ",Id=" + Id + ",ChannelName=" + ChannelName;
		}
		#endregion Model
	}
}
