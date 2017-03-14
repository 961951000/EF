using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Worker Information
	/// </summary>
	[Table("slave_worker_info")]
	public class SlaveWorkerInfo
	{
		#region Model
		[Key, Column("Id", Order = 0)]
		public int? Id
		{
			set;
			get;
		}

		[Column("Relay_log_name")]
		public string RelayLogName
		{
			set;
			get;
		}

		[Column("Relay_log_pos")]
		public long? RelayLogPos
		{
			set;
			get;
		}

		[Column("Master_log_name")]
		public string MasterLogName
		{
			set;
			get;
		}

		[Column("Master_log_pos")]
		public long? MasterLogPos
		{
			set;
			get;
		}

		[Column("Checkpoint_relay_log_name")]
		public string CheckpointRelayLogName
		{
			set;
			get;
		}

		[Column("Checkpoint_relay_log_pos")]
		public long? CheckpointRelayLogPos
		{
			set;
			get;
		}

		[Column("Checkpoint_master_log_name")]
		public string CheckpointMasterLogName
		{
			set;
			get;
		}

		[Column("Checkpoint_master_log_pos")]
		public long? CheckpointMasterLogPos
		{
			set;
			get;
		}

		[Column("Checkpoint_seqno")]
		public int? CheckpointSeqno
		{
			set;
			get;
		}

		[Column("Checkpoint_group_size")]
		public int? CheckpointGroupSize
		{
			set;
			get;
		}

		[Column("Checkpoint_group_bitmap")]
		public string CheckpointGroupBitmap
		{
			set;
			get;
		}

		/// <summary>
		/// The channel on which the slave is connected to a source. Used in Multisource Replication
		/// </summary>
		[Key, Column("Channel_name", Order = 1)]
		public string ChannelName
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Id=" + Id + ",RelayLogName=" + RelayLogName + ",RelayLogPos=" + RelayLogPos + ",MasterLogName=" + MasterLogName + ",MasterLogPos=" + MasterLogPos + ",CheckpointRelayLogName=" + CheckpointRelayLogName + ",CheckpointRelayLogPos=" + CheckpointRelayLogPos + ",CheckpointMasterLogName=" + CheckpointMasterLogName + ",CheckpointMasterLogPos=" + CheckpointMasterLogPos + ",CheckpointSeqno=" + CheckpointSeqno + ",CheckpointGroupSize=" + CheckpointGroupSize + ",CheckpointGroupBitmap=" + CheckpointGroupBitmap + ",ChannelName=" + ChannelName;
		}
		#endregion Model
	}
}
