using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 字典数据表
	/// </summary>
	[Serializable]
	public partial class SysDicDetail
	{
		public SysDicDetail()
		{}
		#region Model
		private Guid _id;
		private Guid _parentid;
		private Guid _dictypeid;
		private string _name;
		private string _relation;
		private int _level=1;
		private int _ordernum=0;
		private string _remark;
		private int _isenabled=1;
		private int _issubway=0;
		private int _ishot=0;
		private string _newname;
		private Guid _newid;
		/// <summary>
		/// 自增编号
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 父id
		/// </summary>
		public Guid ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 字典类型ID
		/// </summary>
		public Guid DicTypeId
		{
			set{ _dictypeid=value;}
			get{return _dictypeid;}
		}
		/// <summary>
		/// 字典名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 关系路径
		/// </summary>
		public string Relation
		{
			set{ _relation=value;}
			get{return _relation;}
		}
		/// <summary>
		/// 层级
		/// </summary>
		public int Level
		{
			set{ _level=value;}
			get{return _level;}
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
		/// <summary>
		/// 是否使用1使用0停用
		/// </summary>
		public int IsEnabled
		{
			set{ _isenabled=value;}
			get{return _isenabled;}
		}
		/// <summary>
		/// 是否地铁城市
		/// </summary>
		public int IsSubway
		{
			set{ _issubway=value;}
			get{return _issubway;}
		}
		/// <summary>
		/// 是否热门
		/// </summary>
		public int IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewName
		{
			set{ _newname=value;}
			get{return _newname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid NewId
		{
			set{ _newid=value;}
			get{return _newid;}
		}
		#endregion Model

	}
}

