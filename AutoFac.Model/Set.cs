using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class Set
	{
		public Set()
		{}
		#region Model
		private int _id;
		private string _key;
		private decimal _score;
		private string _value;
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
		public string Key
		{
			set{ _key=value;}
			get{return _key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Value
		{
			set{ _value=value;}
			get{return _value;}
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

