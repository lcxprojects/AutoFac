using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class LocationHistory
	{
		public LocationHistory()
		{}
		#region Model
		private Guid _id;
		private int _type;
		private Guid _assorrecid;
		private Guid _userid;
		private string _location;
		private DateTime _addtime;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 0车主定位，1乘客定位
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// AssId or RecId
		/// </summary>
		public Guid AssOrRecId
		{
			set{ _assorrecid=value;}
			get{return _assorrecid;}
		}
		/// <summary>
		/// 用户Id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 位置（gcj02坐标系）
		/// </summary>
		public string Location
		{
			set{ _location=value;}
			get{return _location;}
		}
		/// <summary>
		/// 定位时间
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

