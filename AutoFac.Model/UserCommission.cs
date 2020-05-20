using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserCommission
	{
		public UserCommission()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private Guid _fromuserid;
		private decimal _commission;
		private string _remark;
		private DateTime _addtime;
		private DateTime? _commissiontime;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 被推荐人id
		/// </summary>
		public Guid FromUserId
		{
			set{ _fromuserid=value;}
			get{return _fromuserid;}
		}
		/// <summary>
		/// 佣金
		/// </summary>
		public decimal Commission
		{
			set{ _commission=value;}
			get{return _commission;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 添加时间（被推荐人注册时间）
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 返佣时间（被推荐人成功出行时间）
		/// </summary>
		public DateTime? CommissionTime
		{
			set{ _commissiontime=value;}
			get{return _commissiontime;}
		}
		#endregion Model

	}
}

