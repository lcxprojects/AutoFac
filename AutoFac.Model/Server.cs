using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class Server
	{
		public Server()
		{}
		#region Model
		private string _id;
		private string _data;
		private DateTime _lastheartbeat;
		/// <summary>
		/// 
		/// </summary>
		public string Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Data
		{
			set{ _data=value;}
			get{return _data;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LastHeartbeat
		{
			set{ _lastheartbeat=value;}
			get{return _lastheartbeat;}
		}
		#endregion Model

	}
}

