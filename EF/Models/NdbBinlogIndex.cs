using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	[Table("ndb_binlog_index")]
	public class NdbBinlogIndex
	{
		#region Model
		[Column("Position")]
		public long? Position
		{
			set;
			get;
		}

		[Column("File")]
		public string File
		{
			set;
			get;
		}

		[Key, Column("epoch", Order = 0)]
		public long? Epoch
		{
			set;
			get;
		}

		[Column("inserts")]
		public int? Inserts
		{
			set;
			get;
		}

		[Column("updates")]
		public int? Updates
		{
			set;
			get;
		}

		[Column("deletes")]
		public int? Deletes
		{
			set;
			get;
		}

		[Column("schemaops")]
		public int? Schemaops
		{
			set;
			get;
		}

		[Key, Column("orig_server_id", Order = 1)]
		public int? OrigServerId
		{
			set;
			get;
		}

		[Key, Column("orig_epoch", Order = 2)]
		public long? OrigEpoch
		{
			set;
			get;
		}

		[Column("gci")]
		public int? Gci
		{
			set;
			get;
		}

		[Column("next_position")]
		public long? NextPosition
		{
			set;
			get;
		}

		[Column("next_file")]
		public string NextFile
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Position=" + Position + ",File=" + File + ",Epoch=" + Epoch + ",Inserts=" + Inserts + ",Updates=" + Updates + ",Deletes=" + Deletes + ",Schemaops=" + Schemaops + ",OrigServerId=" + OrigServerId + ",OrigEpoch=" + OrigEpoch + ",Gci=" + Gci + ",NextPosition=" + NextPosition + ",NextFile=" + NextFile;
		}
		#endregion Model
	}
}
