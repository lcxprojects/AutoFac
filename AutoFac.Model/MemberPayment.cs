using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class MemberPayment
	{
		public MemberPayment()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _orderno;
		private string _code;
		private string _tradeno;
		private string _paytype;
		private decimal? _orderamount;
		private decimal? _payableamount;
		private decimal? _payedamount;
		private int? _status;
		private string _remark;
		private DateTime _createtime= DateTime.Now;
		private string _createuser;
		private DateTime? _paytime;
		private DateTime? _confirmtime;
		private int _paymenttype=1;
		private decimal _returnmoney=0M;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 自己生成的支付单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 相关单号，首次预订直接跳转支付时记录recid使用、车主支付时记录assid
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 微信交易号
		/// </summary>
		public string TradeNo
		{
			set{ _tradeno=value;}
			get{return _tradeno;}
		}
		/// <summary>
		/// 支付类型，余额充值，乘客预定信息服务费，司机支付欠款，司机会员费，车主诚信保证金，乘客诚信保证金，专线订单费
		/// </summary>
		public string PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 订单金额
		/// </summary>
		public decimal? OrderAmount
		{
			set{ _orderamount=value;}
			get{return _orderamount;}
		}
		/// <summary>
		/// 应付金额
		/// </summary>
		public decimal? PayableAmount
		{
			set{ _payableamount=value;}
			get{return _payableamount;}
		}
		/// <summary>
		/// 实付金额
		/// </summary>
		public decimal? PayedAmount
		{
			set{ _payedamount=value;}
			get{return _payedamount;}
		}
		/// <summary>
		/// 支付状态（0未支付，1已支付，-1已退款,-2部分退款）
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
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
		/// 支付时间
		/// </summary>
		public DateTime? PayTime
		{
			set{ _paytime=value;}
			get{return _paytime;}
		}
		/// <summary>
		/// 确认时间
		/// </summary>
		public DateTime? ConfirmTime
		{
			set{ _confirmtime=value;}
			get{return _confirmtime;}
		}
		/// <summary>
		/// 付款方式，0余额支付，1微信支付MP，2微信支付H5，3千帆支付APP，4微信支付APP，5支付宝支付APP
		/// </summary>
		public int PaymentType
		{
			set{ _paymenttype=value;}
			get{return _paymenttype;}
		}
		/// <summary>
		/// 退款金额
		/// </summary>
		public decimal ReturnMoney
		{
			set{ _returnmoney=value;}
			get{return _returnmoney;}
		}
		#endregion Model

	}
}

