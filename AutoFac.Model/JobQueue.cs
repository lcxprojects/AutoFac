using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class JobQueue
	{
		public JobQueue()
		{}
		#region Model
		private int _id;
		private int _jobid;
		private string _queue;
		private DateTime _fetchedat;
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
		public string Queue
		{
			set{ _queue=value;}
			get{return _queue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime FetchedAt
		{
			set{ _fetchedat=value;}
			get{return _fetchedat;}
		}
		#endregion Model

	}
}

