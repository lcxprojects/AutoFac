using System;
namespace AutoFac.Model
{
	/// <summary>
	/// Ass:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Ass
	{
		public Ass()
		{}
		#region Model
		private Guid _id;
		private string _phone;
		private string _startcity;
		private string _startplace;
		private string _startplacelocation;
		private string _endcity;
		private string _endplace;
		private string _endplacelocation;
		private string _cardowner;
		private string _starttime;
		private string _line;
		private string _bustype;
		private int? _seat;
		private int _visitcount=0;
		private DateTime _createtime= DateTime.Now;
		private string _shorturl;
		private Guid _recid;
		private string _money;
		private string _remark;
		private DateTime _gotime;
		private Guid _userid;
		private decimal? _cash;
		private string _startcityid;
		private string _endcityid;
		private string _startcityparentid;
		private string _endcityparentid;
		private int _iscountdriverpay=0;
		private int _status=1;
		private string _lastlocation;
		private DateTime? _lastlocationtime;
		private int _bookedseat=0;
		private int _chatcount=0;
		private decimal _infofee=0M;
		private string _vehiclenumber;
		private int _isdelete=0;
		private decimal _payablefee=0M;
		private decimal _payedfee=0M;
		private int _isplus=0;
		private decimal _plusmoney=0M;
		private int _isregulations=0;
		private long _sn;
		private decimal? _startplacelat;
		private decimal? _startplacelng;
		private decimal? _endplacelat;
		private decimal? _endplacelng;
		private DateTime? _canceltime;
		private int _platform=0;
		private int _vehicleseatnum=0;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
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
		/// 出发地点
		/// </summary>
		public string StartPlace
		{
			set{ _startplace=value;}
			get{return _startplace;}
		}
		/// <summary>
		/// 出发地点坐标（gcj02坐标系）
		/// </summary>
		public string StartPlaceLocation
		{
			set{ _startplacelocation=value;}
			get{return _startplacelocation;}
		}
		/// <summary>
		/// 目的城市
		/// </summary>
		public string EndCity
		{
			set{ _endcity=value;}
			get{return _endcity;}
		}
		/// <summary>
		/// 目的地点
		/// </summary>
		public string EndPlace
		{
			set{ _endplace=value;}
			get{return _endplace;}
		}
		/// <summary>
		/// 目的地点坐标（gcj02坐标系）
		/// </summary>
		public string EndPlaceLocation
		{
			set{ _endplacelocation=value;}
			get{return _endplacelocation;}
		}
		/// <summary>
		/// 司机姓名
		/// </summary>
		public string CardOwner
		{
			set{ _cardowner=value;}
			get{return _cardowner;}
		}
		/// <summary>
		/// (A费，带元)
		/// </summary>
		public string StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 路线
		/// </summary>
		public string Line
		{
			set{ _line=value;}
			get{return _line;}
		}
		/// <summary>
		/// 车型
		/// </summary>
		public string BusType
		{
			set{ _bustype=value;}
			get{return _bustype;}
		}
		/// <summary>
		/// 当前剩余座位数
		/// </summary>
		public int? Seat
		{
			set{ _seat=value;}
			get{return _seat;}
		}
		/// <summary>
		/// 访问数
		/// </summary>
		public int VisitCount
		{
			set{ _visitcount=value;}
			get{return _visitcount;}
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
		/// 车主发布 短链接
		/// </summary>
		public string ShortUrl
		{
			set{ _shorturl=value;}
			get{return _shorturl;}
		}
		/// <summary>
		/// 发送过Q群后，会将此字段赋值 用来区分是否发布过Q群
		/// </summary>
		public Guid RecId
		{
			set{ _recid=value;}
			get{return _recid;}
		}
		/// <summary>
		/// 所需费用(没用)
		/// </summary>
		public string Money
		{
			set{ _money=value;}
			get{return _money;}
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
		/// 出发时间
		/// </summary>
		public DateTime GoTime
		{
			set{ _gotime=value;}
			get{return _gotime;}
		}
		/// <summary>
		/// 用户ID 司机id，老数据可能为空
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 所需费用[A费]（费用的数字部分）
		/// </summary>
		public decimal? Cash
		{
			set{ _cash=value;}
			get{return _cash;}
		}
		/// <summary>
		/// 发送过wx群后，会将此字段赋值 用来区分是否发布过wx群
		/// </summary>
		public string StartCityId
		{
			set{ _startcityid=value;}
			get{return _startcityid;}
		}
		/// <summary>
		/// 没用
		/// </summary>
		public string EndCityId
		{
			set{ _endcityid=value;}
			get{return _endcityid;}
		}
		/// <summary>
		/// 没用
		/// </summary>
		public string StartCityParentId
		{
			set{ _startcityparentid=value;}
			get{return _startcityparentid;}
		}
		/// <summary>
		/// 没用
		/// </summary>
		public string EndCityParentId
		{
			set{ _endcityparentid=value;}
			get{return _endcityparentid;}
		}
		/// <summary>
		/// 是否已计算车主信息费
		/// </summary>
		public int IsCountDriverPay
		{
			set{ _iscountdriverpay=value;}
			get{return _iscountdriverpay;}
		}
		/// <summary>
		/// 状态，0取消，1正常，-1待支付
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 最后一次位置（gcj02坐标系）
		/// </summary>
		public string LastLocation
		{
			set{ _lastlocation=value;}
			get{return _lastlocation;}
		}
		/// <summary>
		/// 最后一次定位时间
		/// </summary>
		public DateTime? LastLocationTime
		{
			set{ _lastlocationtime=value;}
			get{return _lastlocationtime;}
		}
		/// <summary>
		/// 已订座数
		/// </summary>
		public int BookedSeat
		{
			set{ _bookedseat=value;}
			get{return _bookedseat;}
		}
		/// <summary>
		/// 聊天记录数
		/// </summary>
		public int ChatCount
		{
			set{ _chatcount=value;}
			get{return _chatcount;}
		}
		/// <summary>
		/// 有效信息费（含在线支付、余额支付，不含后台增加的余额支付的部分）
		/// </summary>
		public decimal InfoFee
		{
			set{ _infofee=value;}
			get{return _infofee;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string VehicleNumber
		{
			set{ _vehiclenumber=value;}
			get{return _vehiclenumber;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int IsDelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		/// <summary>
		/// 应付信息费（有效预定数*信息费单价）
		/// </summary>
		public decimal PayableFee
		{
			set{ _payablefee=value;}
			get{return _payablefee;}
		}
		/// <summary>
		/// 已付信息费（含余额、在线支付的钱）
		/// </summary>
		public decimal PayedFee
		{
			set{ _payedfee=value;}
			get{return _payedfee;}
		}
		/// <summary>
		/// 是否是诚信Plus形成，0不是1是
		/// </summary>
		public int IsPlus
		{
			set{ _isplus=value;}
			get{return _isplus;}
		}
		/// <summary>
		/// 此行程的诚信保证金
		/// </summary>
		public decimal PlusMoney
		{
			set{ _plusmoney=value;}
			get{return _plusmoney;}
		}
		/// <summary>
		/// 是否符合认证车型
		/// </summary>
		public int IsRegulations
		{
			set{ _isregulations=value;}
			get{return _isregulations;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long SN
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 出发地点坐标纬度（gcj02坐标系）
		/// </summary>
		public decimal? StartPlaceLat
		{
			set{ _startplacelat=value;}
			get{return _startplacelat;}
		}
		/// <summary>
		/// 目的地点坐标经度（gcj02坐标系）
		/// </summary>
		public decimal? StartPlaceLng
		{
			set{ _startplacelng=value;}
			get{return _startplacelng;}
		}
		/// <summary>
		/// 出发地点坐标纬度（gcj02坐标系）
		/// </summary>
		public decimal? EndPlaceLat
		{
			set{ _endplacelat=value;}
			get{return _endplacelat;}
		}
		/// <summary>
		/// 目的地点坐标经度（gcj02坐标系）
		/// </summary>
		public decimal? EndPlaceLng
		{
			set{ _endplacelng=value;}
			get{return _endplacelng;}
		}
		/// <summary>
		/// 撤下行程时间
		/// </summary>
		public DateTime? CancelTime
		{
			set{ _canceltime=value;}
			get{return _canceltime;}
		}
		/// <summary>
		/// 平台0微信公众号1安卓手机app
		/// </summary>
		public int Platform
		{
			set{ _platform=value;}
			get{return _platform;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int VehicleSeatNum
		{
			set{ _vehicleseatnum=value;}
			get{return _vehicleseatnum;}
		}
		#endregion Model

	}
}

