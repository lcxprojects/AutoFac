using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 管理员表
	/// </summary>
	[Serializable]
	public partial class SysAdmin
	{
		public SysAdmin()
		{}
		#region Model
		private Guid _id;
		private string _username;
		private string _password;
		private string _roleids;
		private string _realname;
		private string _lastloginip;
		private DateTime? _lastlogintime;
		private int _logintimes=0;
		private int _enabled=1;
		private DateTime _createtime= DateTime.Now;
		private string _createuser;
		private DateTime _updatetime= DateTime.Now;
		private string _updateuser;
		private string _remark;
		private string _openid;
		private string _wxnoticetypes;
		private string _wxnoticelines;
		/// <summary>
		/// 自增编号
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 用户密码
		/// </summary>
		public string PassWord
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 所属角色ID,逗号隔开
		/// </summary>
		public string RoleIds
		{
			set{ _roleids=value;}
			get{return _roleids;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 最后一次登录IP
		/// </summary>
		public string LastLoginIP
		{
			set{ _lastloginip=value;}
			get{return _lastloginip;}
		}
		/// <summary>
		/// 最后一次登录时间
		/// </summary>
		public DateTime? LastLoginTime
		{
			set{ _lastlogintime=value;}
			get{return _lastlogintime;}
		}
		/// <summary>
		/// 登录次数
		/// </summary>
		public int LoginTimes
		{
			set{ _logintimes=value;}
			get{return _logintimes;}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public int Enabled
		{
			set{ _enabled=value;}
			get{return _enabled;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 添加人
		/// </summary>
		public string CreateUser
		{
			set{ _createuser=value;}
			get{return _createuser;}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		public string UpdateUser
		{
			set{ _updateuser=value;}
			get{return _updateuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 微信OpenId
		/// </summary>
		public string OpenId
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 接受的微信通知类型
		/// </summary>
		public string WxNoticeTypes
		{
			set{ _wxnoticetypes=value;}
			get{return _wxnoticetypes;}
		}
		/// <summary>
		/// 接受微信通知线路，例如： 郑州-濮阳,濮阳-郑州 ，为空代表全部
		/// </summary>
		public string WxNoticeLines
		{
			set{ _wxnoticelines=value;}
			get{return _wxnoticelines;}
		}
		#endregion Model

	}
}

