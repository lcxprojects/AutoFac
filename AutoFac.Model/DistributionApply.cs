using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class DistributionApply
	{
		public DistributionApply()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _name;
		private string _tel;
		private string _note;
		private int _authstatus;
		private string _authnote;
		private DateTime? _authtime;
		private DateTime _createtime;
		/// <summary>
		/// 分销商申请表id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 分销商id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 申请理由说明
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
		}
		/// <summary>
		/// 审核状态，-1不通过，0待审核，1已审核
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
		/// 审核时间
		/// </summary>
		public DateTime? AuthTime
		{
			set{ _authtime=value;}
			get{return _authtime;}
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

