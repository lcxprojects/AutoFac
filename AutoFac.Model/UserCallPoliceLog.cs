using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserCallPoliceLog
	{
		public UserCallPoliceLog()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _name;
		private string _phone;
		private int _type;
		private string _callphone;
		private string _callname;
		private string _calllocation;
		private string _ip;
		private string _calladdress;
		private DateTime _createtime= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 所属用户id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 所属用户名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 所属用户电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 呼叫类型，0报警，1紧急联系人,2进入安全中心
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 被呼叫电话
		/// </summary>
		public string CallPhone
		{
			set{ _callphone=value;}
			get{return _callphone;}
		}
		/// <summary>
		/// 被呼叫人
		/// </summary>
		public string CallName
		{
			set{ _callname=value;}
			get{return _callname;}
		}
		/// <summary>
		/// 呼叫时的定位坐标（gcj02）
		/// </summary>
		public string CallLocation
		{
			set{ _calllocation=value;}
			get{return _calllocation;}
		}
		/// <summary>
		/// IP
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 中文地址
		/// </summary>
		public string CallAddress
		{
			set{ _calladdress=value;}
			get{return _calladdress;}
		}
		/// <summary>
		/// 呼叫时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

