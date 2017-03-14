using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Procedure privileges
	/// </summary>
	[Table("procs_priv")]
	public class ProcsPriv
	{
		#region Model
		[Key, Column("Host", Order = 0)]
		public string Host
		{
			set;
			get;
		}

		[Key, Column("Db", Order = 1)]
		public string Db
		{
			set;
			get;
		}

		[Key, Column("User", Order = 2)]
		public string User
		{
			set;
			get;
		}

		[Key, Column("Routine_name", Order = 3)]
		public string RoutineName
		{
			set;
			get;
		}

		[Key, Column("Routine_type", Order = 4)]
		public string RoutineType
		{
			set;
			get;
		}

		[Column("Grantor")]
		public string Grantor
		{
			set;
			get;
		}

		[Column("Proc_priv")]
		public string ProcPriv
		{
			set;
			get;
		}

		[Column("Timestamp")]
		public DateTime? Timestamp
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Host=" + Host + ",Db=" + Db + ",User=" + User + ",RoutineName=" + RoutineName + ",RoutineType=" + RoutineType + ",Grantor=" + Grantor + ",ProcPriv=" + ProcPriv + ",Timestamp=" + Timestamp;
		}
		#endregion Model
	}
}
