using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class SpecialLineShift
	{
		public SpecialLineShift()
		{}
		#region Model
		private Guid _id;
		private Guid _lineid;
		private Guid _settingid;
		private DateTime _gotime;
		private DateTime _highwaytime;
		private decimal _price;
		private int _seatnum;
		private int _bookedseatnum;
		private int _superfluousnum=0;
		private int _status;
		private DateTime? _createtime;
		private string _createuser;
		private DateTime? _updatetime;
		private string _updateuser;
		private int _isenable=0;
		/// <summary>
		/// 主键id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 线路Id
		/// </summary>
		public Guid LineId
		{
			set{ _lineid=value;}
			get{return _lineid;}
		}
		/// <summary>
		/// 班次设置Id
		/// </summary>
		public Guid SettingId
		{
			set{ _settingid=value;}
			get{return _settingid;}
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
		/// 票价
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 余座
		/// </summary>
		public int SeatNum
		{
			set{ _seatnum=value;}
			get{return _seatnum;}
		}
		/// <summary>
		/// 订座数量
		/// </summary>
		public int BookedSeatNum
		{
			set{ _bookedseatnum=value;}
			get{return _bookedseatnum;}
		}
		/// <summary>
		/// 剩余的座位数量
		/// </summary>
		public int SuperfluousNum
		{
			set{ _superfluousnum=value;}
			get{return _superfluousnum;}
		}
		/// <summary>
		/// 专线状态
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CreateUser
		{
			set{ _createuser=value;}
			get{return _createuser;}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 更新人
		/// </summary>
		public string UpdateUser
		{
			set{ _updateuser=value;}
			get{return _updateuser;}
		}
		/// <summary>
		/// 是否启用 1是0否
		/// </summary>
		public int IsEnable
		{
			set{ _isenable=value;}
			get{return _isenable;}
		}
		#endregion Model

	}
}

