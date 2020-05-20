using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserWithdrawLog
	{
		public UserWithdrawLog()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _orderno;
		private decimal _money;
		private string _realname;
		private DateTime _createtime;
		private string _note;
		private int _status;
		private DateTime? _authtime;
		private string _authuser;
		private string _authnote;
		private string _kefuremark;
		private int _platform=0;
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
		/// 提现单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 提现金额
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 当前微信实名认证的真实姓名
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 提现说明
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
		}
		/// <summary>
		/// 提现状态，-1不通过，1待审核，2已审核，3已发放
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime? AuthTime
		{
			set{ _authtime=value;}
			get{return _authtime;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string AuthUser
		{
			set{ _authuser=value;}
			get{return _authuser;}
		}
		/// <summary>
		/// 审核意见
		/// </summary>
		public string AuthNote
		{
			set{ _authnote=value;}
			get{return _authnote;}
		}
		/// <summary>
		/// 客服备注
		/// </summary>
		public string KefuRemark
		{
			set{ _kefuremark=value;}
			get{return _kefuremark;}
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

