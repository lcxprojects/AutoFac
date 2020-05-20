using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 菜单模块表
	/// </summary>
	[Serializable]
	public partial class SysReport
	{
		public SysReport()
		{}
		#region Model
		private Guid _id;
		private string _datatype;
		private string _datetype;
		private DateTime _date;
		private int _num=0;
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
		public string DataType
		{
			set{ _datatype=value;}
			get{return _datatype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DateType
		{
			set{ _datetype=value;}
			get{return _datetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date
		{
			set{ _date=value;}
			get{return _date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		#endregion Model

	}
}

