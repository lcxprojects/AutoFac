using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class Job
	{
		public Job()
		{}
		#region Model
		private int _id;
		private int? _stateid;
		private string _statename;
		private string _invocationdata;
		private string _arguments;
		private DateTime _createdat;
		private DateTime _expireat;
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
		public int? StateId
		{
			set{ _stateid=value;}
			get{return _stateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StateName
		{
			set{ _statename=value;}
			get{return _statename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvocationData
		{
			set{ _invocationdata=value;}
			get{return _invocationdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Arguments
		{
			set{ _arguments=value;}
			get{return _arguments;}
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
		public DateTime ExpireAt
		{
			set{ _expireat=value;}
			get{return _expireat;}
		}
		#endregion Model

	}
}

