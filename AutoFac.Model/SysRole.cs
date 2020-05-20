using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class SysRole
	{
		public SysRole()
		{}
		#region Model
		private Guid _id;
		private string _code;
		private string _name;
		private string _moduleids;
		private string _remark;
		private int _isenabled=1;
		/// <summary>
		/// Id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 角色编码
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 角色名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 菜单权限,用逗号隔开
		/// </summary>
		public string ModuleIds
		{
			set{ _moduleids=value;}
			get{return _moduleids;}
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
		/// 是否使用1启用0停用
		/// </summary>
		public int IsEnabled
		{
			set{ _isenabled=value;}
			get{return _isenabled;}
		}
		#endregion Model

	}
}

