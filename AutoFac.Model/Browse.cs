using System;
namespace AutoFac.Model
{
	/// <summary>
	/// Browse:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Browse
	{
		public Browse()
		{}
		#region Model
		private Guid _id;
		private Guid _assid;
		private string _ip;
		private string _browser;
		private DateTime _creattime= DateTime.Now;
		private string _browsername;
		private string _dnsname;
		private Guid _recid;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid AssId
		{
			set{ _assid=value;}
			get{return _assid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Browser
		{
			set{ _browser=value;}
			get{return _browser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreatTime
		{
			set{ _creattime=value;}
			get{return _creattime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BrowserName
		{
			set{ _browsername=value;}
			get{return _browsername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DNSName
		{
			set{ _dnsname=value;}
			get{return _dnsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid RecId
		{
			set{ _recid=value;}
			get{return _recid;}
		}
		#endregion Model

	}
}

