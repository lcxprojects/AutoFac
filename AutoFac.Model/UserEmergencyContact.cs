using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserEmergencyContact
	{
		public UserEmergencyContact()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _name;
		private string _phone;
		private DateTime _createtime;
		private Guid _createuserid;
		private DateTime _updatetime= DateTime.Now;
		private string _updateusername;
		private int _platform=0;
		/// <summary>
		/// 紧急联系人主键id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户Id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 紧急联系人姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 紧急联系人电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 创建用户id
		/// </summary>
		public Guid CreateUserId
		{
			set{ _createuserid=value;}
			get{return _createuserid;}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 更新用户名称
		/// </summary>
		public string UpdateUserName
		{
			set{ _updateusername=value;}
			get{return _updateusername;}
		}
		/// <summary>
		/// 平台0微信公众号1安卓手机app
		/// </summary>
		public int Platform
		{
			set{ _platform=value;}
			get{return _platform;}
		}
		#endregion Model

	}
}

