using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 菜单模块表
	/// </summary>
	[Serializable]
	public partial class SysRegion
	{
		public SysRegion()
		{}
		#region Model
		private Guid _id;
		private Guid _parentid;
		private string _relation;
		private int _level=1;
		private string _code;
		private string _name;
		private string _smallname;
		private string _telcode;
		private string _zipcode;
		private string _mername;
		private string _pinyin;
		private int _ordernum=99;
		private int _isenabled=1;
		private int _issubway=0;
		private int _ishot=0;
		private decimal? _lng;
		private decimal? _lat;
		private string _remark;
		private DateTime _createtime= DateTime.Now;
		private string _createuser;
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
		public Guid ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 关系路径
		/// </summary>
		public string Relation
		{
			set{ _relation=value;}
			get{return _relation;}
		}
		/// <summary>
		/// 层级
		/// </summary>
		public int Level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 行政编码
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 区域名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 区域简称
		/// </summary>
		public string SmallName
		{
			set{ _smallname=value;}
			get{return _smallname;}
		}
		/// <summary>
		/// 电话区号
		/// </summary>
		public string Telcode
		{
			set{ _telcode=value;}
			get{return _telcode;}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string Zipcode
		{
			set{ _zipcode=value;}
			get{return _zipcode;}
		}
		/// <summary>
		/// 组合名称
		/// </summary>
		public string MerName
		{
			set{ _mername=value;}
			get{return _mername;}
		}
		/// <summary>
		/// 全拼拼音
		/// </summary>
		public string PinYin
		{
			set{ _pinyin=value;}
			get{return _pinyin;}
		}
		/// <summary>
		/// 排序号,小的在前
		/// </summary>
		public int OrderNum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
		}
		/// <summary>
		/// 是否使用1使用0停用
		/// </summary>
		public int IsEnabled
		{
			set{ _isenabled=value;}
			get{return _isenabled;}
		}
		/// <summary>
		/// 是否地铁城市
		/// </summary>
		public int IsSubway
		{
			set{ _issubway=value;}
			get{return _issubway;}
		}
		/// <summary>
		/// 是否热门
		/// </summary>
		public int IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Lng
		{
			set{ _lng=value;}
			get{return _lng;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Lat
		{
			set{ _lat=value;}
			get{return _lat;}
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
		/// 
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
		#endregion Model

	}
}

