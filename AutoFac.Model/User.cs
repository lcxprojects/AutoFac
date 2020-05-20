using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class User
	{
		public User()
		{}
		#region Model
		private Guid _id;
		private string _phone;
		private string _name;
		private int? _sex;
		private string _remark;
		private DateTime _creattime= DateTime.Now;
		private int _isenabled=1;
		private string _openid;
		private DateTime? _updatetime= DateTime.Now;
		private int? _status;
		private DateTime? _viptime;
		private decimal? _dalance=0M;
		private Guid _recommender;
		private DateTime? _assviptime;
		private decimal _creditvalue=1M;
		private int _isfreeze=0;
		private int _goodnum=0;
		private int _badnum=0;
		private string _photo;
		private string _blacknote;
		private int _isrealname=0;
		private string _realname;
		private string _idcard;
		private string _idcardphotof;
		private string _idcardphotob;
		private string _isrealnameauthnote;
		private DateTime? _realnameauthtime;
		private string _idcardinfo;
		private int _isrealdriver=0;
		private string _drivercardphotof;
		private string _drivercardphotob;
		private string _isrealdriverauthnote;
		private DateTime? _realdriverauthtime;
		private string _drivercardinfo;
		private DateTime _lastupdatecreditvalue= DateTime.Now;
		private DateTime? _lastchangephone;
		private int _asscount=0;
		private int _reccount=0;
		private string _vehiclecardphotof;
		private string _vehiclecardphotob;
		private string _vehiclebrand;
		private string _vehiclemodel;
		private string _vehiclenumber;
		private string _vehiclecardinfo;
		private DateTime? _enableupdatetime;
		private string _enableupdateuser;
		private decimal? _adddalance=0M;
		private DateTime? _blackendtime;
		private string _qfuid;
		private DateTime? _lastlogintime;
		private int _logintimes=0;
		private string _idcardinfobyuser;
		private string _drivercardinfobyuser;
		private string _vehiclecardinfobyuser;
		private DateTime? _lastchangename;
		private string _unionid;
		private string _kefuremark;
		private int _islimit=0;
		private DateTime? _limitendtime;
		private DateTime? _limitregbegintime;
		private DateTime? _limitregendtime;
		private DateTime? _limitbegintime;
		private DateTime? _blackbegintime;
		private DateTime? _limitupdatetime;
		private string _limitupdateuser;
		private decimal _freezedalance=0M;
		private decimal _deposit=0M;
		private decimal _freezedeposit=0M;
		private string _nickname;
		private int _hascommercialinsurance=0;
		private DateTime? _insuranceendtime;
		private int _platform=0;
		private int _nowcontribution=0;
		private int _iscontribution=0;
		private string _vehiclefullmodel;
		private string _password;
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
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
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
		/// Sex 1男，0女
		/// </summary>
		public int? Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 后台备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
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
		/// 是否启用（黑名单）2白名单， 1正常，0黑名单
		/// </summary>
		public int IsEnabled
		{
			set{ _isenabled=value;}
			get{return _isenabled;}
		}
		/// <summary>
		/// 微信OpenId
		/// </summary>
		public string OpenId
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// Status  1乘客会员，0非乘客会员
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// VIPTime 乘客会员开始时间
		/// </summary>
		public DateTime? VIPTime
		{
			set{ _viptime=value;}
			get{return _viptime;}
		}
		/// <summary>
		/// 总余额（包含AddDalance、FreezeDalance）
		/// </summary>
		public decimal? Dalance
		{
			set{ _dalance=value;}
			get{return _dalance;}
		}
		/// <summary>
		/// 推荐人id
		/// </summary>
		public Guid Recommender
		{
			set{ _recommender=value;}
			get{return _recommender;}
		}
		/// <summary>
		/// 司机vip时间
		/// </summary>
		public DateTime? AssVIPTime
		{
			set{ _assviptime=value;}
			get{return _assviptime;}
		}
		/// <summary>
		/// 诚心值
		/// </summary>
		public decimal CreditValue
		{
			set{ _creditvalue=value;}
			get{return _creditvalue;}
		}
		/// <summary>
		/// 是否冻结1冻结，0不冻结
		/// </summary>
		public int IsFreeze
		{
			set{ _isfreeze=value;}
			get{return _isfreeze;}
		}
		/// <summary>
		/// 好评数
		/// </summary>
		public int GoodNum
		{
			set{ _goodnum=value;}
			get{return _goodnum;}
		}
		/// <summary>
		/// 差评数
		/// </summary>
		public int BadNum
		{
			set{ _badnum=value;}
			get{return _badnum;}
		}
		/// <summary>
		/// 头像
		/// </summary>
		public string Photo
		{
			set{ _photo=value;}
			get{return _photo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BlackNote
		{
			set{ _blacknote=value;}
			get{return _blacknote;}
		}
		/// <summary>
		/// 是否实名认证，-1未通过，0否，1审核中，2是
		/// </summary>
		public int IsRealName
		{
			set{ _isrealname=value;}
			get{return _isrealname;}
		}
		/// <summary>
		/// 实名
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 身份号
		/// </summary>
		public string IdCard
		{
			set{ _idcard=value;}
			get{return _idcard;}
		}
		/// <summary>
		/// 身份证照片正面
		/// </summary>
		public string IdCardPhotoF
		{
			set{ _idcardphotof=value;}
			get{return _idcardphotof;}
		}
		/// <summary>
		/// 身份证照片背面
		/// </summary>
		public string IdCardPhotoB
		{
			set{ _idcardphotob=value;}
			get{return _idcardphotob;}
		}
		/// <summary>
		/// 实名认证审核说明
		/// </summary>
		public string IsRealNameAuthNote
		{
			set{ _isrealnameauthnote=value;}
			get{return _isrealnameauthnote;}
		}
		/// <summary>
		/// 实名认证审核时间
		/// </summary>
		public DateTime? RealNameAuthTime
		{
			set{ _realnameauthtime=value;}
			get{return _realnameauthtime;}
		}
		/// <summary>
		/// 身份证上识别出来的信息
		/// </summary>
		public string IdCardInfo
		{
			set{ _idcardinfo=value;}
			get{return _idcardinfo;}
		}
		/// <summary>
		/// 是否车主认证，-1未通过，0否，1审核中，2是
		/// </summary>
		public int IsRealDriver
		{
			set{ _isrealdriver=value;}
			get{return _isrealdriver;}
		}
		/// <summary>
		/// 驾驶证照片正面
		/// </summary>
		public string DriverCardPhotoF
		{
			set{ _drivercardphotof=value;}
			get{return _drivercardphotof;}
		}
		/// <summary>
		/// 驾驶证照片背面
		/// </summary>
		public string DriverCardPhotoB
		{
			set{ _drivercardphotob=value;}
			get{return _drivercardphotob;}
		}
		/// <summary>
		/// 车主认证审核说明
		/// </summary>
		public string IsRealDriverAuthNote
		{
			set{ _isrealdriverauthnote=value;}
			get{return _isrealdriverauthnote;}
		}
		/// <summary>
		/// 车主认证审核时间
		/// </summary>
		public DateTime? RealDriverAuthTime
		{
			set{ _realdriverauthtime=value;}
			get{return _realdriverauthtime;}
		}
		/// <summary>
		/// 驾驶证信息上识别出来的信息
		/// </summary>
		public string DriverCardInfo
		{
			set{ _drivercardinfo=value;}
			get{return _drivercardinfo;}
		}
		/// <summary>
		/// 最后一次更新诚信值的时间
		/// </summary>
		public DateTime LastUpdateCreditValue
		{
			set{ _lastupdatecreditvalue=value;}
			get{return _lastupdatecreditvalue;}
		}
		/// <summary>
		/// 最后一次更改手机号时间
		/// </summary>
		public DateTime? LastChangePhone
		{
			set{ _lastchangephone=value;}
			get{return _lastchangephone;}
		}
		/// <summary>
		/// 发布行程次数（含撤销）
		/// </summary>
		public int AssCount
		{
			set{ _asscount=value;}
			get{return _asscount;}
		}
		/// <summary>
		/// 预订次数(含退订)
		/// </summary>
		public int RecCount
		{
			set{ _reccount=value;}
			get{return _reccount;}
		}
		/// <summary>
		/// 行驶证照片正面
		/// </summary>
		public string VehicleCardPhotoF
		{
			set{ _vehiclecardphotof=value;}
			get{return _vehiclecardphotof;}
		}
		/// <summary>
		/// 行驶证照片背面
		/// </summary>
		public string VehicleCardPhotoB
		{
			set{ _vehiclecardphotob=value;}
			get{return _vehiclecardphotob;}
		}
		/// <summary>
		/// 车辆品牌
		/// </summary>
		public string VehicleBrand
		{
			set{ _vehiclebrand=value;}
			get{return _vehiclebrand;}
		}
		/// <summary>
		/// 车辆型号
		/// </summary>
		public string VehicleModel
		{
			set{ _vehiclemodel=value;}
			get{return _vehiclemodel;}
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
		/// 行驶证信息上识别出来的信息
		/// </summary>
		public string VehicleCardInfo
		{
			set{ _vehiclecardinfo=value;}
			get{return _vehiclecardinfo;}
		}
		/// <summary>
		/// 是否启用（黑名单）修改时间
		/// </summary>
		public DateTime? EnableUpdateTime
		{
			set{ _enableupdatetime=value;}
			get{return _enableupdatetime;}
		}
		/// <summary>
		/// 是否启用（黑名单）修改人
		/// </summary>
		public string EnableUpdateUser
		{
			set{ _enableupdateuser=value;}
			get{return _enableupdateuser;}
		}
		/// <summary>
		/// 后台手动调的余额
		/// </summary>
		public decimal? AddDalance
		{
			set{ _adddalance=value;}
			get{return _adddalance;}
		}
		/// <summary>
		/// 黑名单到期时间
		/// </summary>
		public DateTime? BlackEndTime
		{
			set{ _blackendtime=value;}
			get{return _blackendtime;}
		}
		/// <summary>
		/// 千帆app客户的 uid
		/// </summary>
		public string QFUID
		{
			set{ _qfuid=value;}
			get{return _qfuid;}
		}
		/// <summary>
		/// 最后一次登录时间
		/// </summary>
		public DateTime? LastLoginTime
		{
			set{ _lastlogintime=value;}
			get{return _lastlogintime;}
		}
		/// <summary>
		/// 当月，登录天数
		/// </summary>
		public int LoginTimes
		{
			set{ _logintimes=value;}
			get{return _logintimes;}
		}
		/// <summary>
		/// 用户修改过的身份证识别信息
		/// </summary>
		public string IdCardInfoByUser
		{
			set{ _idcardinfobyuser=value;}
			get{return _idcardinfobyuser;}
		}
		/// <summary>
		/// 用户修改过的驾驶证识别信息
		/// </summary>
		public string DriverCardInfoByUser
		{
			set{ _drivercardinfobyuser=value;}
			get{return _drivercardinfobyuser;}
		}
		/// <summary>
		/// 用户修改过的行驶证识别信息
		/// </summary>
		public string VehicleCardInfoByUser
		{
			set{ _vehiclecardinfobyuser=value;}
			get{return _vehiclecardinfobyuser;}
		}
		/// <summary>
		/// 最后一次更改名称时间
		/// </summary>
		public DateTime? LastChangeName
		{
			set{ _lastchangename=value;}
			get{return _lastchangename;}
		}
		/// <summary>
		/// 微信开放平台UnionID
		/// </summary>
		public string UnionID
		{
			set{ _unionid=value;}
			get{return _unionid;}
		}
		/// <summary>
		/// 客服备注
		/// </summary>
		public string KefuRemark
		{
			set{ _kefuremark=value;}
			get{return _kefuremark;}
		}
		/// <summary>
		/// 0不限流，1仅自己可见，2仅30天内发布过的用户可见，3仅曾经发布过的用户可见，4仅指定时间注册用户可见
		/// </summary>
		public int IsLimit
		{
			set{ _islimit=value;}
			get{return _islimit;}
		}
		/// <summary>
		/// 限流结束时间，为空代表一致限流。
		/// </summary>
		public DateTime? LimitEndTime
		{
			set{ _limitendtime=value;}
			get{return _limitendtime;}
		}
		/// <summary>
		/// 当IsLimit=4时，限制注册用户开始时间
		/// </summary>
		public DateTime? LimitRegBeginTime
		{
			set{ _limitregbegintime=value;}
			get{return _limitregbegintime;}
		}
		/// <summary>
		/// 当IsLimit=4时，限制注册用户结束时间
		/// </summary>
		public DateTime? LimitRegEndTime
		{
			set{ _limitregendtime=value;}
			get{return _limitregendtime;}
		}
		/// <summary>
		/// 限流开始时间
		/// </summary>
		public DateTime? LimitBeginTime
		{
			set{ _limitbegintime=value;}
			get{return _limitbegintime;}
		}
		/// <summary>
		/// 黑名单开始时间
		/// </summary>
		public DateTime? BlackBeginTime
		{
			set{ _blackbegintime=value;}
			get{return _blackbegintime;}
		}
		/// <summary>
		/// 是否限流 修改时间
		/// </summary>
		public DateTime? LimitUpdateTime
		{
			set{ _limitupdatetime=value;}
			get{return _limitupdatetime;}
		}
		/// <summary>
		/// 是否限流 修改人
		/// </summary>
		public string LimitUpdateUser
		{
			set{ _limitupdateuser=value;}
			get{return _limitupdateuser;}
		}
		/// <summary>
		/// 冻结余额
		/// </summary>
		public decimal FreezeDalance
		{
			set{ _freezedalance=value;}
			get{return _freezedalance;}
		}
		/// <summary>
		/// 保证金（包含FreezeDeposit）
		/// </summary>
		public decimal Deposit
		{
			set{ _deposit=value;}
			get{return _deposit;}
		}
		/// <summary>
		/// 冻结保证金
		/// </summary>
		public decimal FreezeDeposit
		{
			set{ _freezedeposit=value;}
			get{return _freezedeposit;}
		}
		/// <summary>
		/// 微信昵称
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 是否已有商业保险，1是，0否。有商业险时，不再购买保险，信息费不加保险费
		/// </summary>
		public int HasCommercialInsurance
		{
			set{ _hascommercialinsurance=value;}
			get{return _hascommercialinsurance;}
		}
		/// <summary>
		/// 商业保险到期时间
		/// </summary>
		public DateTime? InsuranceEndTime
		{
			set{ _insuranceendtime=value;}
			get{return _insuranceendtime;}
		}
		/// <summary>
		/// 平台0微信公众号1手机安卓app
		/// </summary>
		public int Platform
		{
			set{ _platform=value;}
			get{return _platform;}
		}
		/// <summary>
		/// 当前贡献值
		/// </summary>
		public int NowContribution
		{
			set{ _nowcontribution=value;}
			get{return _nowcontribution;}
		}
		/// <summary>
		/// 是否开启贡献,1是0否
		/// </summary>
		public int IsContribution
		{
			set{ _iscontribution=value;}
			get{return _iscontribution;}
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
		/// 密码
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		#endregion Model

	}
}

