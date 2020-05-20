using System;
namespace AutoFac.Model
{
	/// <summary>
	/// AssCommentAppeal:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AssCommentAppeal
	{
		public AssCommentAppeal()
		{}
		#region Model
		private Guid _id;
		private Guid _asscommentid;
		private Guid _userid;
		private string _appealreason;
		private DateTime _createtime;
		private int _authstatus;
		private string _authnote;
		private string _authuser;
		private DateTime? _authtime;
		private decimal? _authmoney;
		private string _kefuremark;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 评价Id
		/// </summary>
		public Guid AssCommentId
		{
			set{ _asscommentid=value;}
			get{return _asscommentid;}
		}
		/// <summary>
		/// 申诉人id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 申诉理由
		/// </summary>
		public string AppealReason
		{
			set{ _appealreason=value;}
			get{return _appealreason;}
		}
		/// <summary>
		/// 申诉时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 状态，-1驳回申诉，0待审核申诉，1待支付申诉，2已同意申诉
		/// </summary>
		public int AuthStatus
		{
			set{ _authstatus=value;}
			get{return _authstatus;}
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
		/// 
		/// </summary>
		public string AuthUser
		{
			set{ _authuser=value;}
			get{return _authuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AuthTime
		{
			set{ _authtime=value;}
			get{return _authtime;}
		}
		/// <summary>
		/// 审核要支付的补偿款
		/// </summary>
		public decimal? AuthMoney
		{
			set{ _authmoney=value;}
			get{return _authmoney;}
		}
		/// <summary>
		/// 客服备注
		/// </summary>
		public string KefuRemark
		{
			set{ _kefuremark=value;}
			get{return _kefuremark;}
		}
		#endregion Model

	}
}

