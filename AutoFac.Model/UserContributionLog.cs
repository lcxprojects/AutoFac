using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserContributionLog
	{
		public UserContributionLog()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _code;
		private int _action;
		private int _contribution;
		private int _nowcontribution;
		private DateTime _createtime;
		private string _note;
		private string _remark;
		/// <summary>
		/// 主键id
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
		/// Code
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 0收入1支出
		/// </summary>
		public int Action
		{
			set{ _action=value;}
			get{return _action;}
		}
		/// <summary>
		/// 贡献值
		/// </summary>
		public int Contribution
		{
			set{ _contribution=value;}
			get{return _contribution;}
		}
		/// <summary>
		/// 当前贡献值
		/// </summary>
		public int NowContribution
		{
			set{ _nowcontribution=value;}
			get{return _nowcontribution;}
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
		/// 通知
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

