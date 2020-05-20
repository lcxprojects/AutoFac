using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class State
	{
		public State()
		{}
		#region Model
		private int _id;
		private int _jobid;
		private string _name;
		private string _reason;
		private DateTime _createdat;
		private string _data;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int JobId
		{
			set{ _jobid=value;}
			get{return _jobid;}
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
		/// 
		/// </summary>
		public string Reason
		{
			set{ _reason=value;}
			get{return _reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreatedAt
		{
			set{ _createdat=value;}
			get{return _createdat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Data
		{
			set{ _data=value;}
			get{return _data;}
		}
		#endregion Model

	}
}

