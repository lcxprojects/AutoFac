using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserVehiches
	{
		public UserVehiches()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _brand;
		private string _model;
		private string _vehiclecardphotof;
		private string _vehiclecardphotob;
		private int _isauth;
		private DateTime? _authtime;
		private string _vehiclecardinfo;
		private string _vehiclenumber;
		private string _vehicleowner;
		private DateTime? _vehicleregistertime;
		private string _authnote;
		private int _isdefault=0;
		private DateTime _addtime= DateTime.Now;
		private int _isdelete=0;
		private string _vehiclefullmodel;
		private string _vehiclecardinfofbyuser;
		private string _vehiclecardinfob;
		private string _vehiclecardinfobbyuser;
		private int _vehicleseatnum=0;
		private string _vehiclephoto;
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
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 车辆品牌
		/// </summary>
		public string Brand
		{
			set{ _brand=value;}
			get{return _brand;}
		}
		/// <summary>
		/// 车辆型号
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 行驶证正页
		/// </summary>
		public string VehicleCardPhotoF
		{
			set{ _vehiclecardphotof=value;}
			get{return _vehiclecardphotof;}
		}
		/// <summary>
		/// 行驶证副页
		/// </summary>
		public string VehicleCardPhotoB
		{
			set{ _vehiclecardphotob=value;}
			get{return _vehiclecardphotob;}
		}
		/// <summary>
		/// 是否认证，-1未通过，0否，1审核中，2是
		/// </summary>
		public int IsAuth
		{
			set{ _isauth=value;}
			get{return _isauth;}
		}
		/// <summary>
		/// 认证审核时间
		/// </summary>
		public DateTime? AuthTime
		{
			set{ _authtime=value;}
			get{return _authtime;}
		}
		/// <summary>
		/// 行驶证信息上识别出来的信息
		/// </summary>
		public string VehicleCardInfo
		{
			set{ _vehiclecardinfo=value;}
			get{return _vehiclecardinfo;}
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
		/// 车辆所有人
		/// </summary>
		public string VehicleOwner
		{
			set{ _vehicleowner=value;}
			get{return _vehicleowner;}
		}
		/// <summary>
		/// 注册日期
		/// </summary>
		public DateTime? VehicleRegisterTime
		{
			set{ _vehicleregistertime=value;}
			get{return _vehicleregistertime;}
		}
		/// <summary>
		/// 认证审核说明
		/// </summary>
		public string AuthNote
		{
			set{ _authnote=value;}
			get{return _authnote;}
		}
		/// <summary>
		/// 是否是默认车辆，1是，0否
		/// </summary>
		public int IsDefault
		{
			set{ _isdefault=value;}
			get{return _isdefault;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 是否已经删除1是0否 默认0
		/// </summary>
		public int IsDelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		/// <summary>
		/// 车辆完整型号
		/// </summary>
		public string VehicleFullModel
		{
			set{ _vehiclefullmodel=value;}
			get{return _vehiclefullmodel;}
		}
		/// <summary>
		/// 用户修改过的行驶证正页识别信息
		/// </summary>
		public string VehicleCardInfoFByUser
		{
			set{ _vehiclecardinfofbyuser=value;}
			get{return _vehiclecardinfofbyuser;}
		}
		/// <summary>
		/// 行驶证副页上识别出来的信息
		/// </summary>
		public string VehicleCardInfoB
		{
			set{ _vehiclecardinfob=value;}
			get{return _vehiclecardinfob;}
		}
		/// <summary>
		/// 用户修改过的行驶证副页识别信息
		/// </summary>
		public string VehicleCardInfoBByUser
		{
			set{ _vehiclecardinfobbyuser=value;}
			get{return _vehiclecardinfobbyuser;}
		}
		/// <summary>
		/// 核定载人数
		/// </summary>
		public int VehicleSeatNum
		{
			set{ _vehicleseatnum=value;}
			get{return _vehicleseatnum;}
		}
		/// <summary>
		/// 车头45度照片
		/// </summary>
		public string VehiclePhoto
		{
			set{ _vehiclephoto=value;}
			get{return _vehiclephoto;}
		}
		#endregion Model

	}
}

