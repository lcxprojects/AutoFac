using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class LineConfig
	{
		public LineConfig()
		{}
		#region Model
		private Guid _id;
		private string _startcity;
		private string _endcity;
		private int _isuse=1;
		private int _ishot=0;
		private string _note;
		private DateTime _createtime= DateTime.Now;
		private string _createuser;
		private string _defaultlinedesc;
		private int _linedescminlength;
		private string _defaultremark;
		private string _dangerstartplace;
		private int _unsubscribetime=-60;
		private int _booktimespan=120;
		private int _isopenshorturlbook=0;
		private decimal _linefee=0M;
		private decimal _linefeemax=0M;
		private int _lineseat=3;
		private int _lineseatmax=6;
		private decimal _passengerinfofee=0M;
		private decimal _driverinfofee=0M;
		private DateTime? _driverinfofeebegintime;
		private int _isopenauthnamebook;
		private int _notauthnamebookcount;
		private DateTime? _notauthnamebookstarttime;
		private DateTime? _notauthnamebookcountstarttime;
		private int _isopenauthdriverpublish;
		private int _notauthdriverpublishcount;
		private DateTime? _notauthdriverpublishstarttime;
		private DateTime? _notauthdriverpublishcountstarttime;
		private int _isopenautoblack=7;
		private int _autoblackcountday=7;
		private int _autoblackmaxday=4;
		private string _autoblacknote;
		private int _autoblacktimespan=30;
		private int _isopenautoblackbywhite=7;
		private int _autoblackcountdaybywhite=7;
		private int _autoblackmaxdaybywhite=4;
		private string _autoblacknotebywhite;
		private int _autoblacktimespanbywhite=30;
		private int _isopenassautoblackkeywords;
		private string _assautoblackkeywords;
		private string _assautoblacknote;
		private int _assautoblacktimespan;
		private int _isopenunbookrateblack=60;
		private decimal _unbookrateblackrate=60M;
		private int _unbookrateblackreccount=10;
		private string _unbookrateblacknote;
		private int _isopenunsubscribeautoblack=12;
		private int _unsubscribeautoblackcounthours=12;
		private int _unsubscribeautoblackmaxcount=10;
		private string _unsubscribeautoblacknote;
		private int _unsubscribeautoblacktimespan=30;
		private int _isopenautolimit=7;
		private int _autolimitcountday=7;
		private int _autolimitmaxday=4;
		private int _autolimittimespan=30;
		private int _isopenbustypeautolimitkeywords;
		private string _bustypeautolimitkeywords;
		private int _bustypeautolimittimespan;
		private int _isopenplus;
		private decimal _plusinsurancefee=2M;
		private DateTime? _plusstarttime;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
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
		/// 目的城市
		/// </summary>
		public string EndCity
		{
			set{ _endcity=value;}
			get{return _endcity;}
		}
		/// <summary>
		/// 是否启用，1使用，0停用
		/// </summary>
		public int IsUse
		{
			set{ _isuse=value;}
			get{return _isuse;}
		}
		/// <summary>
		/// 是否首页热门线路，1热门，0普通
		/// </summary>
		public int IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
		/// <summary>
		/// 备注，后台可见
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
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
		/// 
		/// </summary>
		public string CreateUser
		{
			set{ _createuser=value;}
			get{return _createuser;}
		}
		/// <summary>
		/// 默认路线文字
		/// </summary>
		public string DefaultLineDesc
		{
			set{ _defaultlinedesc=value;}
			get{return _defaultlinedesc;}
		}
		/// <summary>
		/// 路线最小字数限制
		/// </summary>
		public int LineDescMinLength
		{
			set{ _linedescminlength=value;}
			get{return _linedescminlength;}
		}
		/// <summary>
		/// 默认备注
		/// </summary>
		public string DefaultRemark
		{
			set{ _defaultremark=value;}
			get{return _defaultremark;}
		}
		/// <summary>
		/// 危险上车点
		/// </summary>
		public string DangerStartPlace
		{
			set{ _dangerstartplace=value;}
			get{return _dangerstartplace;}
		}
		/// <summary>
		/// 发车前多长时间(分钟)内不可以退订
		/// </summary>
		public int UnsubscribeTime
		{
			set{ _unsubscribetime=value;}
			get{return _unsubscribetime;}
		}
		/// <summary>
		/// [弃用]预订间隔时间(分钟)
		/// </summary>
		public int BookTimespan
		{
			set{ _booktimespan=value;}
			get{return _booktimespan;}
		}
		/// <summary>
		/// 是否开启短连接预订，1开启，0关闭
		/// </summary>
		public int IsOpenShortUrlBook
		{
			set{ _isopenshorturlbook=value;}
			get{return _isopenshorturlbook;}
		}
		/// <summary>
		/// 线路A费建议价
		/// </summary>
		public decimal LineFee
		{
			set{ _linefee=value;}
			get{return _linefee;}
		}
		/// <summary>
		/// 线路A费最高价,0为不限
		/// </summary>
		public decimal LineFeeMax
		{
			set{ _linefeemax=value;}
			get{return _linefeemax;}
		}
		/// <summary>
		/// 默认座位数
		/// </summary>
		public int LineSeat
		{
			set{ _lineseat=value;}
			get{return _lineseat;}
		}
		/// <summary>
		/// 最大座位数
		/// </summary>
		public int LineSeatMax
		{
			set{ _lineseatmax=value;}
			get{return _lineseatmax;}
		}
		/// <summary>
		/// 乘客信息费
		/// </summary>
		public decimal PassengerInfoFee
		{
			set{ _passengerinfofee=value;}
			get{return _passengerinfofee;}
		}
		/// <summary>
		/// 车主信息费
		/// </summary>
		public decimal DriverInfoFee
		{
			set{ _driverinfofee=value;}
			get{return _driverinfofee;}
		}
		/// <summary>
		/// 车主信息费开始时间
		/// </summary>
		public DateTime? DriverInfoFeeBeginTime
		{
			set{ _driverinfofeebegintime=value;}
			get{return _driverinfofeebegintime;}
		}
		/// <summary>
		/// 未实名认证不可预订，是否开启
		/// </summary>
		public int IsOpenAuthNameBook
		{
			set{ _isopenauthnamebook=value;}
			get{return _isopenauthnamebook;}
		}
		/// <summary>
		/// 未实名认证可预定次数
		/// </summary>
		public int NotAuthNameBookCount
		{
			set{ _notauthnamebookcount=value;}
			get{return _notauthnamebookcount;}
		}
		/// <summary>
		/// 统计预订次数的开始时间
		/// </summary>
		public DateTime? NotAuthNameBookStartTime
		{
			set{ _notauthnamebookstarttime=value;}
			get{return _notauthnamebookstarttime;}
		}
		/// <summary>
		/// 从x开始，新注册的用户，未进行实名认证，预订次数受限制
		/// </summary>
		public DateTime? NotAuthNameBookCountStartTime
		{
			set{ _notauthnamebookcountstarttime=value;}
			get{return _notauthnamebookcountstarttime;}
		}
		/// <summary>
		/// 未认证车主不可发布，是否开启
		/// </summary>
		public int IsOpenAuthDriverPublish
		{
			set{ _isopenauthdriverpublish=value;}
			get{return _isopenauthdriverpublish;}
		}
		/// <summary>
		/// 未认证车主可发布次数，0为不限制
		/// </summary>
		public int NotAuthDriverPublishCount
		{
			set{ _notauthdriverpublishcount=value;}
			get{return _notauthdriverpublishcount;}
		}
		/// <summary>
		/// 统计发布次数的开始时间
		/// </summary>
		public DateTime? NotAuthDriverPublishStartTime
		{
			set{ _notauthdriverpublishstarttime=value;}
			get{return _notauthdriverpublishstarttime;}
		}
		/// <summary>
		/// 从x开始，新注册的用户，未进行车主认证，发布次数受限制
		/// </summary>
		public DateTime? NotAuthDriverPublishCountStartTime
		{
			set{ _notauthdriverpublishcountstarttime=value;}
			get{return _notauthdriverpublishcountstarttime;}
		}
		/// <summary>
		/// 普通用户出行次数限制，是否开启 
		/// </summary>
		public int IsOpenAutoBlack
		{
			set{ _isopenautoblack=value;}
			get{return _isopenautoblack;}
		}
		/// <summary>
		/// 普通用户出行次数限制，自动拉黑统计天数
		/// </summary>
		public int AutoBlackCountDay
		{
			set{ _autoblackcountday=value;}
			get{return _autoblackcountday;}
		}
		/// <summary>
		/// 普通用户出行次数限制，自动拉黑可出行天数
		/// </summary>
		public int AutoBlackMaxDay
		{
			set{ _autoblackmaxday=value;}
			get{return _autoblackmaxday;}
		}
		/// <summary>
		/// 普通用户出行次数限制，自动拉黑原因
		/// </summary>
		public string AutoBlackNote
		{
			set{ _autoblacknote=value;}
			get{return _autoblacknote;}
		}
		/// <summary>
		/// 普通用户出行次数限制，是否开启
		/// </summary>
		public int AutoBlackTimespan
		{
			set{ _autoblacktimespan=value;}
			get{return _autoblacktimespan;}
		}
		/// <summary>
		/// 普通用户出行天数限制，自动拉黑统计天数
		/// </summary>
		public int IsOpenAutoBlackByWhite
		{
			set{ _isopenautoblackbywhite=value;}
			get{return _isopenautoblackbywhite;}
		}
		/// <summary>
		/// 白名单用户出行天数限制，自动拉黑统计天数
		/// </summary>
		public int AutoBlackCountDayByWhite
		{
			set{ _autoblackcountdaybywhite=value;}
			get{return _autoblackcountdaybywhite;}
		}
		/// <summary>
		/// 白名单用户出行天数限制，自动拉黑可出行天数
		/// </summary>
		public int AutoBlackMaxDayByWhite
		{
			set{ _autoblackmaxdaybywhite=value;}
			get{return _autoblackmaxdaybywhite;}
		}
		/// <summary>
		/// 白名单用户出行天数限制，自动拉黑原因
		/// </summary>
		public string AutoBlackNoteByWhite
		{
			set{ _autoblacknotebywhite=value;}
			get{return _autoblacknotebywhite;}
		}
		/// <summary>
		/// 白名单用户出行天数限制，自动拉黑期限
		/// </summary>
		public int AutoBlackTimespanByWhite
		{
			set{ _autoblacktimespanbywhite=value;}
			get{return _autoblacktimespanbywhite;}
		}
		/// <summary>
		/// 路线备注自动拉黑,是否开启
		/// </summary>
		public int IsOpenAssAutoBlackKeywords
		{
			set{ _isopenassautoblackkeywords=value;}
			get{return _isopenassautoblackkeywords;}
		}
		/// <summary>
		/// 路线备注自动拉黑,关键字,支持正则
		/// </summary>
		public string AssAutoBlackKeywords
		{
			set{ _assautoblackkeywords=value;}
			get{return _assautoblackkeywords;}
		}
		/// <summary>
		/// 路线备注自动拉黑,拉黑原因
		/// </summary>
		public string AssAutoBlackNote
		{
			set{ _assautoblacknote=value;}
			get{return _assautoblacknote;}
		}
		/// <summary>
		/// 路线备注自动拉黑,拉黑期限，单位天
		/// </summary>
		public int AssAutoBlackTimespan
		{
			set{ _assautoblacktimespan=value;}
			get{return _assautoblacktimespan;}
		}
		/// <summary>
		/// 车主退订率自动拉黑，是否开启
		/// </summary>
		public int IsOpenUnbookRateBlack
		{
			set{ _isopenunbookrateblack=value;}
			get{return _isopenunbookrateblack;}
		}
		/// <summary>
		/// 车主退订率自动拉黑，退订率
		/// </summary>
		public decimal UnbookRateBlackRate
		{
			set{ _unbookrateblackrate=value;}
			get{return _unbookrateblackrate;}
		}
		/// <summary>
		/// 车主退订率自动拉黑，预定个数
		/// </summary>
		public int UnbookRateBlackRecCount
		{
			set{ _unbookrateblackreccount=value;}
			get{return _unbookrateblackreccount;}
		}
		/// <summary>
		/// 车主退订率自动拉黑，拉黑原因
		/// </summary>
		public string UnbookRateBlackNote
		{
			set{ _unbookrateblacknote=value;}
			get{return _unbookrateblacknote;}
		}
		/// <summary>
		/// 普通用户最多退订次数配置,是否开启
		/// </summary>
		public int IsOpenUnsubscribeAutoBlack
		{
			set{ _isopenunsubscribeautoblack=value;}
			get{return _isopenunsubscribeautoblack;}
		}
		/// <summary>
		/// 普通用户最多退订次数配置,统计多少小时内的退订次数
		/// </summary>
		public int UnsubscribeAutoBlackCountHours
		{
			set{ _unsubscribeautoblackcounthours=value;}
			get{return _unsubscribeautoblackcounthours;}
		}
		/// <summary>
		/// 普通用户最多退订次数配置,统计小时内的最大退订次数
		/// </summary>
		public int UnsubscribeAutoBlackMaxCount
		{
			set{ _unsubscribeautoblackmaxcount=value;}
			get{return _unsubscribeautoblackmaxcount;}
		}
		/// <summary>
		/// 普通用户最多退订次数配置,拉黑原因
		/// </summary>
		public string UnsubscribeAutoBlackNote
		{
			set{ _unsubscribeautoblacknote=value;}
			get{return _unsubscribeautoblacknote;}
		}
		/// <summary>
		/// 普通用户最多退订次数配置,拉黑期限天
		/// </summary>
		public int UnsubscribeAutoBlackTimespan
		{
			set{ _unsubscribeautoblacktimespan=value;}
			get{return _unsubscribeautoblacktimespan;}
		}
		/// <summary>
		/// 出行频率自动限流配置，是否开启
		/// </summary>
		public int IsOpenAutoLimit
		{
			set{ _isopenautolimit=value;}
			get{return _isopenautolimit;}
		}
		/// <summary>
		/// 出行频率自动限流配置，统计天数，0不限
		/// </summary>
		public int AutoLimitCountDay
		{
			set{ _autolimitcountday=value;}
			get{return _autolimitcountday;}
		}
		/// <summary>
		/// 出行频率自动限流配置，可出行天数
		/// </summary>
		public int AutoLimitMaxDay
		{
			set{ _autolimitmaxday=value;}
			get{return _autolimitmaxday;}
		}
		/// <summary>
		/// 出行频率自动限流配置，限流期限
		/// </summary>
		public int AutoLimitTimespan
		{
			set{ _autolimittimespan=value;}
			get{return _autolimittimespan;}
		}
		/// <summary>
		/// 车型自动限流关键字,是否开启
		/// </summary>
		public int IsOpenBusTypeAutoLimitKeywords
		{
			set{ _isopenbustypeautolimitkeywords=value;}
			get{return _isopenbustypeautolimitkeywords;}
		}
		/// <summary>
		/// 车型自动限流关键字,支持正则。
		/// </summary>
		public string BusTypeAutoLimitKeywords
		{
			set{ _bustypeautolimitkeywords=value;}
			get{return _bustypeautolimitkeywords;}
		}
		/// <summary>
		/// 车型自动限流，限流时间，单位是天，0代表永久
		/// </summary>
		public int BusTypeAutoLimitTimespan
		{
			set{ _bustypeautolimittimespan=value;}
			get{return _bustypeautolimittimespan;}
		}
		/// <summary>
		/// 是否开启Plus
		/// </summary>
		public int IsOpenPlus
		{
			set{ _isopenplus=value;}
			get{return _isopenplus;}
		}
		/// <summary>
		/// plus线路保费
		/// </summary>
		public decimal PlusInsuranceFee
		{
			set{ _plusinsurancefee=value;}
			get{return _plusinsurancefee;}
		}
		/// <summary>
		/// plus线路开启时间
		/// </summary>
		public DateTime? PlusStartTime
		{
			set{ _plusstarttime=value;}
			get{return _plusstarttime;}
		}
		#endregion Model

	}
}

