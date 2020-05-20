using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class TmpKaiCheng
	{
		public TmpKaiCheng()
		{}
		#region Model
		private Guid _id;
		private string _phone;
		private string _photo;
		private string _drivercardphotof;
		private string _drivercardphotob;
		private string _vehiclecardphotof;
		private string _vehiclecardphotob;
		private string _car;
		private DateTime _createtime;
		private string _kefuremark;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 手机号
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 2寸证件照照片
		/// </summary>
		public string Photo
		{
			set{ _photo=value;}
			get{return _photo;}
		}
		/// <summary>
		/// 驾驶证正页照片
		/// </summary>
		public string DriverCardPhotoF
		{
			set{ _drivercardphotof=value;}
			get{return _drivercardphotof;}
		}
		/// <summary>
		/// 驾驶证副页照片
		/// </summary>
		public string DriverCardPhotoB
		{
			set{ _drivercardphotob=value;}
			get{return _drivercardphotob;}
		}
		/// <summary>
		/// 行驶证正页照片
		/// </summary>
		public string VehicleCardPhotoF
		{
			set{ _vehiclecardphotof=value;}
			get{return _vehiclecardphotof;}
		}
		/// <summary>
		/// 行驶证副页照片
		/// </summary>
		public string VehicleCardPhotoB
		{
			set{ _vehiclecardphotob=value;}
			get{return _vehiclecardphotob;}
		}
		/// <summary>
		/// 车身45°照片
		/// </summary>
		public string Car
		{
			set{ _car=value;}
			get{return _car;}
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
		/// 客服备注
		/// </summary>
		public string KefuRemark
		{
			set{ _kefuremark=value;}
			get{return _kefuremark;}
		}
		#endregion Model

	}
}

