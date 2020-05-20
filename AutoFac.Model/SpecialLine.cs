using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class SpecialLine
	{
		public SpecialLine()
		{}
		#region Model
		private Guid _id;
		private string _startcity;
		private string _endcity;
		private DateTime? _createtime;
		private string _createuser;
		private int _ordernum=0;
		private string _carprovider;
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
		/// 线路出发城市
		/// </summary>
		public string StartCity
		{
			set{ _startcity=value;}
			get{return _startcity;}
		}
		/// <summary>
		/// 线路到达城市
		/// </summary>
		public string EndCity
		{
			set{ _endcity=value;}
			get{return _endcity;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 添加人
		/// </summary>
		public string CreateUser
		{
			set{ _createuser=value;}
			get{return _createuser;}
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
		/// 车辆提供方
		/// </summary>
		public string CarProvider
		{
			set{ _carprovider=value;}
			get{return _carprovider;}
		}
		/// <summary>
		/// 是否启用 1是0否
		/// </summary>
		public int IsEnable
		{
			set{ _isenable=value;}
			get{return _isenable;}
		}
		#endregion Model

	}
}

