using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class Rec
	{
		public Rec()
		{}
		#region Model
		private Guid _id;
		private int? _flag;
		private string _starttime;
		private Guid _assid;
		private string _phone;
		private int _bookseat=0;
		private string _startplace;
		private string _startcity;
		private string _endcity;
		private string _name;
		private string _gotime;
		private string _shorturl;
		private DateTime _creattime= DateTime.Now;
		private int? _visitcount;
		private int? _status;
		private string _endplace;
		private string _remark;
		private DateTime? _departuretime;
		private Guid _userid;
		private DateTime _booktime= DateTime.Now;
		private string _bookip;
		private string _incidentally;
		private int? _incidentallystate;
		private int _state=0;
		private decimal? _balance;
		private int _iscomment=0;
		private string _unsubscribetags;
		private string _unsubscribecomplain;
		private DateTime? _unsubscribetime;
		private int _isliableunsubscribe=0;
		private string _lastlocation;
		private DateTime? _lastlocationtime;
		private int _isdelete=0;
		private string _booklocation;
		private int _isplus=0;
		private decimal _plusmoney=0M;
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
		/// 
		/// </summary>
		public int? Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid AssId
		{
			set{ _assid=value;}
			get{return _assid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 预订座位数
		/// </summary>
		public int BookSeat
		{
			set{ _bookseat=value;}
			get{return _bookseat;}
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
		/// 
		/// </summary>
		public string StartCity
		{
			set{ _startcity=value;}
			get{return _startcity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndCity
		{
			set{ _endcity=value;}
			get{return _endcity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoTime
		{
			set{ _gotime=value;}
			get{return _gotime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShortUrl
		{
			set{ _shorturl=value;}
			get{return _shorturl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreatTime
		{
			set{ _creattime=value;}
			get{return _creattime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? VisitCount
		{
			set{ _visitcount=value;}
			get{return _visitcount;}
		}
		/// <summary>
		/// 无用
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndPlace
		{
			set{ _endplace=value;}
			get{return _endplace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 出发时间
		/// </summary>
		public DateTime? DepartureTime
		{
			set{ _departuretime=value;}
			get{return _departuretime;}
		}
		/// <summary>
		/// UserId,短连接预订，此字段可能为空
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 预订时间
		/// </summary>
		public DateTime BookTime
		{
			set{ _booktime=value;}
			get{return _booktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BookIp
		{
			set{ _bookip=value;}
			get{return _bookip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Incidentally
		{
			set{ _incidentally=value;}
			get{return _incidentally;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IncidentallyState
		{
			set{ _incidentallystate=value;}
			get{return _incidentallystate;}
		}
		/// <summary>
		/// 退订状态，-2待分享，-1待支付，0正常，1退订
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 是否发布评价 1是，0否
		/// </summary>
		public int IsComment
		{
			set{ _iscomment=value;}
			get{return _iscomment;}
		}
		/// <summary>
		/// 退订原因标签
		/// </summary>
		public string UnsubscribeTags
		{
			set{ _unsubscribetags=value;}
			get{return _unsubscribetags;}
		}
		/// <summary>
		/// 退订吐槽
		/// </summary>
		public string UnsubscribeComplain
		{
			set{ _unsubscribecomplain=value;}
			get{return _unsubscribecomplain;}
		}
		/// <summary>
		/// 退订时间
		/// </summary>
		public DateTime? UnsubscribeTime
		{
			set{ _unsubscribetime=value;}
			get{return _unsubscribetime;}
		}
		/// <summary>
		/// 是否有责退订，1是，0否
		/// </summary>
		public int IsLiableUnsubscribe
		{
			set{ _isliableunsubscribe=value;}
			get{return _isliableunsubscribe;}
		}
		/// <summary>
		/// 最后一次位置
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
		/// 是否删除
		/// </summary>
		public int IsDelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		/// <summary>
		/// 预订时乘客的位置
		/// </summary>
		public string BookLocation
		{
			set{ _booklocation=value;}
			get{return _booklocation;}
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

