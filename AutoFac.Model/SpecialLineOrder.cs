using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class SpecialLineOrder
	{
		public SpecialLineOrder()
		{}
		#region Model
		private Guid _id;
		private Guid _shiftid;
		private string _name;
		private string _phone;
		private int _bookseatnum;
		private decimal _amont;
		private DateTime _gotime;
		private DateTime _highwaytime;
		private string _startcity;
		private string _startplace;
		private decimal? _startlong;
		private decimal? _startlat;
		private string _endcity;
		private string _endplace;
		private decimal? _endlong;
		private decimal? _endlat;
		private DateTime _createtime;
		private int _status;
		private DateTime? _canceltime;
		private string _cancelreason;
		private decimal _violationmoney;
		private int _isdelete;
		private Guid _creator;
		private string _backremark;
		private string _businfo;
		private string _driverinfo;
		private string _backreturnremark;
		private string _userremark;
		private int _returntotalseatnum=0;
		private decimal _returntotalamont=0M;
		private decimal _returnlastmoney=0M;
		private int _returnlastseat=0;
		private Guid _speciallinecarid;
		/// <summary>
		/// 主键id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 班次信息id
		/// </summary>
		public Guid ShiftId
		{
			set{ _shiftid=value;}
			get{return _shiftid;}
		}
		/// <summary>
		/// 乘车联系人
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 乘车联系电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 用户下单时的座位
		/// </summary>
		public int BookSeatNum
		{
			set{ _bookseatnum=value;}
			get{return _bookseatnum;}
		}
		/// <summary>
		/// 用户下单时的价钱
		/// </summary>
		public decimal Amont
		{
			set{ _amont=value;}
			get{return _amont;}
		}
		/// <summary>
		/// 出发时间
		/// </summary>
		public DateTime GoTime
		{
			set{ _gotime=value;}
			get{return _gotime;}
		}
		/// <summary>
		/// 上高速时间
		/// </summary>
		public DateTime HighwayTime
		{
			set{ _highwaytime=value;}
			get{return _highwaytime;}
		}
		/// <summary>
		/// 出发城市
		/// </summary>
		public string StartCity
		{
			set{ _startcity=value;}
			get{return _startcity;}
		}
		/// <summary>
		/// 上车点
		/// </summary>
		public string StartPlace
		{
			set{ _startplace=value;}
			get{return _startplace;}
		}
		/// <summary>
		/// 上车坐标(经度)
		/// </summary>
		public decimal? StartLong
		{
			set{ _startlong=value;}
			get{return _startlong;}
		}
		/// <summary>
		/// 上车坐标(纬度)
		/// </summary>
		public decimal? StartLat
		{
			set{ _startlat=value;}
			get{return _startlat;}
		}
		/// <summary>
		/// 到达城市
		/// </summary>
		public string EndCity
		{
			set{ _endcity=value;}
			get{return _endcity;}
		}
		/// <summary>
		/// 下车点
		/// </summary>
		public string EndPlace
		{
			set{ _endplace=value;}
			get{return _endplace;}
		}
		/// <summary>
		/// 下车坐标(经度)
		/// </summary>
		public decimal? EndLong
		{
			set{ _endlong=value;}
			get{return _endlong;}
		}
		/// <summary>
		/// 下车坐标(纬度)
		/// </summary>
		public decimal? EndLat
		{
			set{ _endlat=value;}
			get{return _endlat;}
		}
		/// <summary>
		/// 下单时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// -4退订部分退款,-3退订全部退款， -2失效,-1待支付,0退订,1正常
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 退单时间
		/// </summary>
		public DateTime? CancelTime
		{
			set{ _canceltime=value;}
			get{return _canceltime;}
		}
		/// <summary>
		/// 退订原因
		/// </summary>
		public string CancelReason
		{
			set{ _cancelreason=value;}
			get{return _cancelreason;}
		}
		/// <summary>
		/// 违约扣款
		/// </summary>
		public decimal ViolationMoney
		{
			set{ _violationmoney=value;}
			get{return _violationmoney;}
		}
		/// <summary>
		/// 是否删除 1删除 0正常
		/// </summary>
		public int IsDelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		/// <summary>
		/// 所属用户 
		/// </summary>
		public Guid Creator
		{
			set{ _creator=value;}
			get{return _creator;}
		}
		/// <summary>
		/// 后台备注
		/// </summary>
		public string BackRemark
		{
			set{ _backremark=value;}
			get{return _backremark;}
		}
		/// <summary>
		/// 派车信息
		/// </summary>
		public string BusInfo
		{
			set{ _businfo=value;}
			get{return _businfo;}
		}
		/// <summary>
		/// 司机信息
		/// </summary>
		public string DriverInfo
		{
			set{ _driverinfo=value;}
			get{return _driverinfo;}
		}
		/// <summary>
		/// 系统退订备注
		/// </summary>
		public string BackReturnRemark
		{
			set{ _backreturnremark=value;}
			get{return _backreturnremark;}
		}
		/// <summary>
		/// 用户下单备注
		/// </summary>
		public string UserRemark
		{
			set{ _userremark=value;}
			get{return _userremark;}
		}
		/// <summary>
		/// 累计退订座位
		/// </summary>
		public int ReturnTotalSeatNum
		{
			set{ _returntotalseatnum=value;}
			get{return _returntotalseatnum;}
		}
		/// <summary>
		/// 累计退款钱
		/// </summary>
		public decimal ReturnTotalAmont
		{
			set{ _returntotalamont=value;}
			get{return _returntotalamont;}
		}
		/// <summary>
		/// 单次退款
		/// </summary>
		public decimal ReturnlastMoney
		{
			set{ _returnlastmoney=value;}
			get{return _returnlastmoney;}
		}
		/// <summary>
		/// 单次退订座位
		/// </summary>
		public int ReturnlastSeat
		{
			set{ _returnlastseat=value;}
			get{return _returnlastseat;}
		}
		/// <summary>
		/// 专车id
		/// </summary>
		public Guid SpecialLineCarId
		{
			set{ _speciallinecarid=value;}
			get{return _speciallinecarid;}
		}
		#endregion Model

	}
}

