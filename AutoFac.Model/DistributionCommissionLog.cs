using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class DistributionCommissionLog
	{
		public DistributionCommissionLog()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private Guid _fromuserid;
		private Guid _curgradeid;
		private string _orderid;
		private decimal _ordermoney;
		private decimal _commissionmoney;
		private string _note;
		private string _remark;
		private DateTime _createtime;
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
		/// 当前分销商等级
		/// </summary>
		public Guid CurGradeId
		{
			set{ _curgradeid=value;}
			get{return _curgradeid;}
		}
		/// <summary>
		/// 订单id（recid）
		/// </summary>
		public string OrderId
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 订单金额（可分佣信息费金额）
		/// </summary>
		public decimal OrderMoney
		{
			set{ _ordermoney=value;}
			get{return _ordermoney;}
		}
		/// <summary>
		/// 返佣金额
		/// </summary>
		public decimal CommissionMoney
		{
			set{ _commissionmoney=value;}
			get{return _commissionmoney;}
		}
		/// <summary>
		/// 给用户看的备注
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
		}
		/// <summary>
		/// 给后台看的备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 返佣时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

