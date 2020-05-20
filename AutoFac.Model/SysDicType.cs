using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 字典类型表
	/// </summary>
	[Serializable]
	public partial class SysDicType
	{
		public SysDicType()
		{}
		#region Model
		private Guid _id;
		private string _name;
		private string _code;
		private int _isenabled=1;
		private int _ordernum=0;
		private string _remark;
		/// <summary>
		/// 自增编号
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 类型名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 类型标识
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 是否使用1使用0停用
		/// </summary>
		public int IsEnabled
		{
			set{ _isenabled=value;}
			get{return _isenabled;}
		}
		/// <summary>
		/// 排序号
		/// </summary>
		public int OrderNum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

