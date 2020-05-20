using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class Distribution
	{
		public Distribution()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _name;
		private string _contact;
		private string _tel;
		private int _isenabled;
		private Guid _distributiongradeid;
		private DateTime _licenseendtime;
		private decimal _curcommission;
		private decimal _totalcommission;
		private int _totaluser=0;
		private int _sn;
		private string _code;
		private string _qrcodeimg;
		private DateTime _createtime= DateTime.Now;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 分销商标id 和UserId保持一致
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 分销商名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 分销商联系人
		/// </summary>
		public string Contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		/// <summary>
		/// 分销商联系电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 0停用，1启用
		/// </summary>
		public int IsEnabled
		{
			set{ _isenabled=value;}
			get{return _isenabled;}
		}
		/// <summary>
		/// 分销商等级
		/// </summary>
		public Guid DistributionGradeId
		{
			set{ _distributiongradeid=value;}
			get{return _distributiongradeid;}
		}
		/// <summary>
		/// 授权到期时间
		/// </summary>
		public DateTime LicenseEndTime
		{
			set{ _licenseendtime=value;}
			get{return _licenseendtime;}
		}
		/// <summary>
		/// 当前佣金
		/// </summary>
		public decimal CurCommission
		{
			set{ _curcommission=value;}
			get{return _curcommission;}
		}
		/// <summary>
		/// 累计总佣金
		/// </summary>
		public decimal TotalCommission
		{
			set{ _totalcommission=value;}
			get{return _totalcommission;}
		}
		/// <summary>
		/// 累计总会员
		/// </summary>
		public int TotalUser
		{
			set{ _totaluser=value;}
			get{return _totaluser;}
		}
		/// <summary>
		/// 专属推广码序号
		/// </summary>
		public int SN
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 专属推广码
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 专属推广二维码海报
		/// </summary>
		public string QrCodeImg
		{
			set{ _qrcodeimg=value;}
			get{return _qrcodeimg;}
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
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

