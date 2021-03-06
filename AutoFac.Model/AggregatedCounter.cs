﻿using System;
namespace AutoFac.Model
{
	/// <summary>
	/// AggregatedCounter:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AggregatedCounter
	{
		public AggregatedCounter()
		{}
		#region Model
		private int _id;
		private string _key;
		private long _value;
		private DateTime? _expireat;
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
		public long Value
		{
			set{ _value=value;}
			get{return _value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ExpireAt
		{
			set{ _expireat=value;}
			get{return _expireat;}
		}
		#endregion Model

	}
}

