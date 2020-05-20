using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class SpecialLineShiftSetting
	{
		public SpecialLineShiftSetting()
		{}
		#region Model
		private Guid _id;
		private Guid _lineid;
		private DateTime _gotime;
		private DateTime _highwaytime;
		private decimal _price;
		private int _seatnum;
		private int _type;
		private int _advanceday;
		private DateTime? _cratetime;
		private string _createuser;
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
		/// 线路id
		/// </summary>
		public Guid LineId
		{
			set{ _lineid=value;}
			get{return _lineid;}
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
		/// 座位
		/// </summary>
		public int SeatNum
		{
			set{ _seatnum=value;}
			get{return _seatnum;}
		}
		/// <summary>
		/// 1每天，2每周
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 提前天数
		/// </summary>
		public int AdvanceDay
		{
			set{ _advanceday=value;}
			get{return _advanceday;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CrateTime
		{
			set{ _cratetime=value;}
			get{return _cratetime;}
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
		/// 是否启用1是0否
		/// </summary>
		public int IsEnable
		{
			set{ _isenable=value;}
			get{return _isenable;}
		}
		#endregion Model

	}
}

