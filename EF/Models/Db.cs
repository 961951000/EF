using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Database privileges
	/// </summary>
	[Table("db")]
	public class Db
	{
		#region Model
		[Key, Column("Host", Order = 0)]
		public string Host
		{
			set;
			get;
		}

		[Key, Column("Db", Order = 1)]
		public string _Db
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

		[Column("Select_priv")]
		public string SelectPriv
		{
			set;
			get;
		}

		[Column("Insert_priv")]
		public string InsertPriv
		{
			set;
			get;
		}

		[Column("Update_priv")]
		public string UpdatePriv
		{
			set;
			get;
		}

		[Column("Delete_priv")]
		public string DeletePriv
		{
			set;
			get;
		}

		[Column("Create_priv")]
		public string CreatePriv
		{
			set;
			get;
		}

		[Column("Drop_priv")]
		public string DropPriv
		{
			set;
			get;
		}

		[Column("Grant_priv")]
		public string GrantPriv
		{
			set;
			get;
		}

		[Column("References_priv")]
		public string ReferencesPriv
		{
			set;
			get;
		}

		[Column("Index_priv")]
		public string IndexPriv
		{
			set;
			get;
		}

		[Column("Alter_priv")]
		public string AlterPriv
		{
			set;
			get;
		}

		[Column("Create_tmp_table_priv")]
		public string CreateTmpTablePriv
		{
			set;
			get;
		}

		[Column("Lock_tables_priv")]
		public string LockTablesPriv
		{
			set;
			get;
		}

		[Column("Create_view_priv")]
		public string CreateViewPriv
		{
			set;
			get;
		}

		[Column("Show_view_priv")]
		public string ShowViewPriv
		{
			set;
			get;
		}

		[Column("Create_routine_priv")]
		public string CreateRoutinePriv
		{
			set;
			get;
		}

		[Column("Alter_routine_priv")]
		public string AlterRoutinePriv
		{
			set;
			get;
		}

		[Column("Execute_priv")]
		public string ExecutePriv
		{
			set;
			get;
		}

		[Column("Event_priv")]
		public string EventPriv
		{
			set;
			get;
		}

		[Column("Trigger_priv")]
		public string TriggerPriv
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "Host=" + Host + ",_Db=" + _Db + ",User=" + User + ",SelectPriv=" + SelectPriv + ",InsertPriv=" + InsertPriv + ",UpdatePriv=" + UpdatePriv + ",DeletePriv=" + DeletePriv + ",CreatePriv=" + CreatePriv + ",DropPriv=" + DropPriv + ",GrantPriv=" + GrantPriv + ",ReferencesPriv=" + ReferencesPriv + ",IndexPriv=" + IndexPriv + ",AlterPriv=" + AlterPriv + ",CreateTmpTablePriv=" + CreateTmpTablePriv + ",LockTablesPriv=" + LockTablesPriv + ",CreateViewPriv=" + CreateViewPriv + ",ShowViewPriv=" + ShowViewPriv + ",CreateRoutinePriv=" + CreateRoutinePriv + ",AlterRoutinePriv=" + AlterRoutinePriv + ",ExecutePriv=" + ExecutePriv + ",EventPriv=" + EventPriv + ",TriggerPriv=" + TriggerPriv;
		}
		#endregion Model
	}
}
