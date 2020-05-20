using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserLoginLog
	{
		public UserLoginLog()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private DateTime _logintime;
		private string _loginip;
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
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 登录时间
		/// </summary>
		public DateTime LoginTime
		{
			set{ _logintime=value;}
			get{return _logintime;}
		}
		/// <summary>
		/// 登录IP
		/// </summary>
		public string LoginIP
		{
			set{ _loginip=value;}
			get{return _loginip;}
		}
		#endregion Model

	}
}

