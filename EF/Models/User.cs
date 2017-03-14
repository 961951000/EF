using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
    /// <summary>
    /// Users and global privileges
    /// </summary>
    [Table("user")]
    public class User
    {
        #region Model
        [Key, Column("Host", Order = 0)]
        public string Host
        {
            set;
            get;
        }

        [Key, Column("User", Order = 1)]
        public string _User
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

        [Column("Reload_priv")]
        public string ReloadPriv
        {
            set;
            get;
        }

        [Column("Shutdown_priv")]
        public string ShutdownPriv
        {
            set;
            get;
        }

        [Column("Process_priv")]
        public string ProcessPriv
        {
            set;
            get;
        }

        [Column("File_priv")]
        public string FilePriv
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

        [Column("Show_db_priv")]
        public string ShowDbPriv
        {
            set;
            get;
        }

        [Column("Super_priv")]
        public string SuperPriv
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

        [Column("Execute_priv")]
        public string ExecutePriv
        {
            set;
            get;
        }

        [Column("Repl_slave_priv")]
        public string ReplSlavePriv
        {
            set;
            get;
        }

        [Column("Repl_client_priv")]
        public string ReplClientPriv
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

        [Column("Create_user_priv")]
        public string CreateUserPriv
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

        [Column("Create_tablespace_priv")]
        public string CreateTablespacePriv
        {
            set;
            get;
        }

        [Column("ssl_type")]
        public string SslType
        {
            set;
            get;
        }

        [Column("ssl_cipher")]
        public string SslCipher
        {
            set;
            get;
        }

        [Column("x509_issuer")]
        public string X509Issuer
        {
            set;
            get;
        }

        [Column("x509_subject")]
        public string X509Subject
        {
            set;
            get;
        }

        [Column("max_questions")]
        public int? MaxQuestions
        {
            set;
            get;
        }

        [Column("max_updates")]
        public int? MaxUpdates
        {
            set;
            get;
        }

        [Column("max_connections")]
        public int? MaxConnections
        {
            set;
            get;
        }

        [Column("max_user_connections")]
        public int? MaxUserConnections
        {
            set;
            get;
        }

        [Column("plugin")]
        public string Plugin
        {
            set;
            get;
        }

        [Column("authentication_string")]
        public string AuthenticationString
        {
            set;
            get;
        }

        [Column("password_expired")]
        public string PasswordExpired
        {
            set;
            get;
        }

        [Column("password_last_changed")]
        public DateTime? PasswordLastChanged
        {
            set;
            get;
        }

        [Column("password_lifetime")]
        public short? PasswordLifetime
        {
            set;
            get;
        }

        [Column("account_locked")]
        public string AccountLocked
        {
            set;
            get;
        }

        public override string ToString()
        {
            return "Host=" + Host + ",_User=" + _User + ",SelectPriv=" + SelectPriv + ",InsertPriv=" + InsertPriv + ",UpdatePriv=" + UpdatePriv + ",DeletePriv=" + DeletePriv + ",CreatePriv=" + CreatePriv + ",DropPriv=" + DropPriv + ",ReloadPriv=" + ReloadPriv + ",ShutdownPriv=" + ShutdownPriv + ",ProcessPriv=" + ProcessPriv + ",FilePriv=" + FilePriv + ",GrantPriv=" + GrantPriv + ",ReferencesPriv=" + ReferencesPriv + ",IndexPriv=" + IndexPriv + ",AlterPriv=" + AlterPriv + ",ShowDbPriv=" + ShowDbPriv + ",SuperPriv=" + SuperPriv + ",CreateTmpTablePriv=" + CreateTmpTablePriv + ",LockTablesPriv=" + LockTablesPriv + ",ExecutePriv=" + ExecutePriv + ",ReplSlavePriv=" + ReplSlavePriv + ",ReplClientPriv=" + ReplClientPriv + ",CreateViewPriv=" + CreateViewPriv + ",ShowViewPriv=" + ShowViewPriv + ",CreateRoutinePriv=" + CreateRoutinePriv + ",AlterRoutinePriv=" + AlterRoutinePriv + ",CreateUserPriv=" + CreateUserPriv + ",EventPriv=" + EventPriv + ",TriggerPriv=" + TriggerPriv + ",CreateTablespacePriv=" + CreateTablespacePriv + ",SslType=" + SslType + ",SslCipher=" + SslCipher + ",X509Issuer=" + X509Issuer + ",X509Subject=" + X509Subject + ",MaxQuestions=" + MaxQuestions + ",MaxUpdates=" + MaxUpdates + ",MaxConnections=" + MaxConnections + ",MaxUserConnections=" + MaxUserConnections + ",Plugin=" + Plugin + ",AuthenticationString=" + AuthenticationString + ",PasswordExpired=" + PasswordExpired + ",PasswordLastChanged=" + PasswordLastChanged + ",PasswordLifetime=" + PasswordLifetime + ",AccountLocked=" + AccountLocked;
        }
        #endregion Model
    }
}
