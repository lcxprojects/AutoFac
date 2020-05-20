using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class SpecialLineRange
	{
		public SpecialLineRange()
		{}
		#region Model
		private Guid _id;
		private Guid _lineid;
		private string _linerange;
		private int _rangetype=0;
		private decimal _lineprice;
		private DateTime _createtime= DateTime.Now;
		private string _createuser;
		private DateTime _updatetime= DateTime.Now;
		private string _updateuser;
		private string _linename;
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
		/// 范围
		/// </summary>
		public string LineRange
		{
			set{ _linerange=value;}
			get{return _linerange;}
		}
		/// <summary>
		/// 范围类型 0上车范围1下车范围
		/// </summary>
		public int RangeType
		{
			set{ _rangetype=value;}
			get{return _rangetype;}
		}
		/// <summary>
		/// 线路价格
		/// </summary>
		public decimal LinePrice
		{
			set{ _lineprice=value;}
			get{return _lineprice;}
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
		/// <summary>
		/// 线路名称
		/// </summary>
		public string LineName
		{
			set{ _linename=value;}
			get{return _linename;}
		}
		#endregion Model

	}
}

