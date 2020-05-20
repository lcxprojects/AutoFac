using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class RecSubscribe
	{
		public RecSubscribe()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _startcity;
		private string _endcity;
		private DateTime _gotime;
		private int _waittime;
		private int _seat;
		private string _remark;
		private int _status;
		private DateTime _addtime= DateTime.Now;
		private int _matchcount=0;
		private string _startplace;
		private string _startplacelocation;
		private string _endplace;
		private string _endplacelocation;
		private decimal? _startplacelat;
		private decimal? _startplacelng;
		private int _startplacedistance=0;
		private decimal? _endplacelat;
		private decimal? _endplacelng;
		private int _endplacedistance=0;
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
		/// 用户id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
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
		/// 出发时间
		/// </summary>
		public DateTime GoTime
		{
			set{ _gotime=value;}
			get{return _gotime;}
		}
		/// <summary>
		/// 愿意等待时间（分钟）
		/// </summary>
		public int WaitTime
		{
			set{ _waittime=value;}
			get{return _waittime;}
		}
		/// <summary>
		/// 座位数
		/// </summary>
		public int Seat
		{
			set{ _seat=value;}
			get{return _seat;}
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
		/// 0停止订阅，1订阅
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 匹配通知次数
		/// </summary>
		public int MatchCount
		{
			set{ _matchcount=value;}
			get{return _matchcount;}
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
		/// 匹配距离，单位米。0代表任意距离
		/// </summary>
		public int StartPlaceDistance
		{
			set{ _startplacedistance=value;}
			get{return _startplacedistance;}
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
		/// 匹配距离，单位米。0代表任意距离
		/// </summary>
		public int EndPlaceDistance
		{
			set{ _endplacedistance=value;}
			get{return _endplacedistance;}
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

