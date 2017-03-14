using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
	/// <summary>
	/// Master Information
	/// </summary>
	[Table("slave_master_info")]
	public class SlaveMasterInfo
	{
		#region Model
		/// <summary>
		/// Number of lines in the file.
		/// </summary>
		[Column("Number_of_lines")]
		public int? NumberOfLines
		{
			set;
			get;
		}

		/// <summary>
		/// The name of the master binary log currently being read from the master.
		/// </summary>
		[Column("Master_log_name")]
		public string MasterLogName
		{
			set;
			get;
		}

		/// <summary>
		/// The master log position of the last read event.
		/// </summary>
		[Column("Master_log_pos")]
		public long? MasterLogPos
		{
			set;
			get;
		}

		/// <summary>
		/// The host name of the master.
		/// </summary>
		[Column("Host")]
		public string Host
		{
			set;
			get;
		}

		/// <summary>
		/// The user name used to connect to the master.
		/// </summary>
		[Column("User_name")]
		public string UserName
		{
			set;
			get;
		}

		/// <summary>
		/// The password used to connect to the master.
		/// </summary>
		[Column("User_password")]
		public string UserPassword
		{
			set;
			get;
		}

		/// <summary>
		/// The network port used to connect to the master.
		/// </summary>
		[Column("Port")]
		public int? Port
		{
			set;
			get;
		}

		/// <summary>
		/// The period (in seconds) that the slave will wait before trying to reconnect to the master.
		/// </summary>
		[Column("Connect_retry")]
		public int? ConnectRetry
		{
			set;
			get;
		}

		/// <summary>
		/// Indicates whether the server supports SSL connections.
		/// </summary>
		[Column("Enabled_ssl")]
		public bool? EnabledSsl
		{
			set;
			get;
		}

		/// <summary>
		/// The file used for the Certificate Authority (CA) certificate.
		/// </summary>
		[Column("Ssl_ca")]
		public string SslCa
		{
			set;
			get;
		}

		/// <summary>
		/// The path to the Certificate Authority (CA) certificates.
		/// </summary>
		[Column("Ssl_capath")]
		public string SslCapath
		{
			set;
			get;
		}

		/// <summary>
		/// The name of the SSL certificate file.
		/// </summary>
		[Column("Ssl_cert")]
		public string SslCert
		{
			set;
			get;
		}

		/// <summary>
		/// The name of the cipher in use for the SSL connection.
		/// </summary>
		[Column("Ssl_cipher")]
		public string SslCipher
		{
			set;
			get;
		}

		/// <summary>
		/// The name of the SSL key file.
		/// </summary>
		[Column("Ssl_key")]
		public string SslKey
		{
			set;
			get;
		}

		/// <summary>
		/// Whether to verify the server certificate.
		/// </summary>
		[Column("Ssl_verify_server_cert")]
		public bool? SslVerifyServerCert
		{
			set;
			get;
		}

		[Column("Heartbeat")]
		public string Heartbeat
		{
			set;
			get;
		}

		/// <summary>
		/// Displays which interface is employed when connecting to the MySQL server
		/// </summary>
		[Column("Bind")]
		public string Bind
		{
			set;
			get;
		}

		/// <summary>
		/// The number of server IDs to be ignored, followed by the actual server IDs
		/// </summary>
		[Column("Ignored_server_ids")]
		public string IgnoredServerIds
		{
			set;
			get;
		}

		/// <summary>
		/// The master server uuid.
		/// </summary>
		[Column("Uuid")]
		public string Uuid
		{
			set;
			get;
		}

		/// <summary>
		/// Number of reconnect attempts, to the master, before giving up.
		/// </summary>
		[Column("Retry_count")]
		public long? RetryCount
		{
			set;
			get;
		}

		/// <summary>
		/// The file used for the Certificate Revocation List (CRL)
		/// </summary>
		[Column("Ssl_crl")]
		public string SslCrl
		{
			set;
			get;
		}

		/// <summary>
		/// The path used for Certificate Revocation List (CRL) files
		/// </summary>
		[Column("Ssl_crlpath")]
		public string SslCrlpath
		{
			set;
			get;
		}

		/// <summary>
		/// Indicates whether GTIDs will be used to retrieve events from the master.
		/// </summary>
		[Column("Enabled_auto_position")]
		public bool? EnabledAutoPosition
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

		/// <summary>
		/// Tls version
		/// </summary>
		[Column("Tls_version")]
		public string TlsVersion
		{
			set;
			get;
		}

		public override string ToString()
		{
			return "NumberOfLines=" + NumberOfLines + ",MasterLogName=" + MasterLogName + ",MasterLogPos=" + MasterLogPos + ",Host=" + Host + ",UserName=" + UserName + ",UserPassword=" + UserPassword + ",Port=" + Port + ",ConnectRetry=" + ConnectRetry + ",EnabledSsl=" + EnabledSsl + ",SslCa=" + SslCa + ",SslCapath=" + SslCapath + ",SslCert=" + SslCert + ",SslCipher=" + SslCipher + ",SslKey=" + SslKey + ",SslVerifyServerCert=" + SslVerifyServerCert + ",Heartbeat=" + Heartbeat + ",Bind=" + Bind + ",IgnoredServerIds=" + IgnoredServerIds + ",Uuid=" + Uuid + ",RetryCount=" + RetryCount + ",SslCrl=" + SslCrl + ",SslCrlpath=" + SslCrlpath + ",EnabledAutoPosition=" + EnabledAutoPosition + ",ChannelName=" + ChannelName + ",TlsVersion=" + TlsVersion;
		}
		#endregion Model
	}
}
