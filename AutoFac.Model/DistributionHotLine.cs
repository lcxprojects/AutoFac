using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class DistributionHotLine
	{
		public DistributionHotLine()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _startcity;
		private string _endcity;
		private int _ordernum=99;
		private int _isenabled;
		private string _remark;
		private DateTime _createtime;
		/// <summary>
		/// 分销商热门线路配置id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 分销商id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartCity
		{
			set{ _startcity=value;}
			get{return _startcity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndCity
		{
			set{ _endcity=value;}
			get{return _endcity;}
		}
		/// <summary>
		/// 排序号，小的在前
		/// </summary>
		public int OrderNum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
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
		#endregion Model

	}
}

