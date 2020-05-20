using System;
namespace AutoFac.Model
{
	/// <summary>
	/// AssSuggestPlace:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AssSuggestPlace
	{
		public AssSuggestPlace()
		{}
		#region Model
		private Guid _id;
		private string _city;
		private string _name;
		private decimal _lat;
		private decimal _lng;
		private string _remark;
		private DateTime _createtime;
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
		/// 所属城市
		/// </summary>
		public string City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 地点名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 坐标维度（gcj02）
		/// </summary>
		public decimal Lat
		{
			set{ _lat=value;}
			get{return _lat;}
		}
		/// <summary>
		/// 坐标经度（gcj02）
		/// </summary>
		public decimal Lng
		{
			set{ _lng=value;}
			get{return _lng;}
		}
		/// <summary>
		/// 备注说明
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

