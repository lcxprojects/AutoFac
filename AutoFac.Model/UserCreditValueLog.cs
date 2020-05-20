using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserCreditValueLog
	{
		public UserCreditValueLog()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private int _action;
		private decimal _changecreditvalue;
		private decimal _aftercreditvalue;
		private string _frontremark;
		private string _backremark;
		private string _createuser;
		private DateTime _createtime;
		/// <summary>
		/// 诚信值表主键Id
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
		/// 类型/增加诚信值=1,减少诚信值=0
		/// </summary>
		public int Action
		{
			set{ _action=value;}
			get{return _action;}
		}
		/// <summary>
		/// 变动诚信值
		/// </summary>
		public decimal ChangeCreditValue
		{
			set{ _changecreditvalue=value;}
			get{return _changecreditvalue;}
		}
		/// <summary>
		/// 变动之后的诚信值
		/// </summary>
		public decimal AfterCreditValue
		{
			set{ _aftercreditvalue=value;}
			get{return _aftercreditvalue;}
		}
		/// <summary>
		/// 前台备注(用户看的)
		/// </summary>
		public string FrontRemark
		{
			set{ _frontremark=value;}
			get{return _frontremark;}
		}
		/// <summary>
		/// 后台备注(管理人员看的)
		/// </summary>
		public string BackRemark
		{
			set{ _backremark=value;}
			get{return _backremark;}
		}
		/// <summary>
		/// 创建者,如果是服务的话,为空
		/// </summary>
		public string CreateUser
		{
			set{ _createuser=value;}
			get{return _createuser;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

