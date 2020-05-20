using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class SpecialLineCar
	{
		public SpecialLineCar()
		{}
		#region Model
		private Guid _id;
		private string _carnumber;
		private string _carcolor;
		private string _carbrand;
		private int _carseat=0;
		private string _drivername;
		private string _driverphone;
		private string _openid;
		private int _authstatus=0;
		private int _isenable=0;
		private DateTime _createtime;
		private string _createuser;
		private DateTime _updatetime= DateTime.Now;
		private string _updateuser;
		/// <summary>
		/// 主键id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string CarNumber
		{
			set{ _carnumber=value;}
			get{return _carnumber;}
		}
		/// <summary>
		/// 车颜色
		/// </summary>
		public string CarColor
		{
			set{ _carcolor=value;}
			get{return _carcolor;}
		}
		/// <summary>
		/// 车品牌型号
		/// </summary>
		public string CarBrand
		{
			set{ _carbrand=value;}
			get{return _carbrand;}
		}
		/// <summary>
		/// 车辆座位
		/// </summary>
		public int CarSeat
		{
			set{ _carseat=value;}
			get{return _carseat;}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string DriverName
		{
			set{ _drivername=value;}
			get{return _drivername;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string DriverPhone
		{
			set{ _driverphone=value;}
			get{return _driverphone;}
		}
		/// <summary>
		/// 微信id
		/// </summary>
		public string OpenId
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 审核状态0未审核(审核中)1已审核
		/// </summary>
		public int AuthStatus
		{
			set{ _authstatus=value;}
			get{return _authstatus;}
		}
		/// <summary>
		/// 是否启用0否1是
		/// </summary>
		public int IsEnable
		{
			set{ _isenable=value;}
			get{return _isenable;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime
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
		public DateTime UpdateTime
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
		#endregion Model

	}
}

