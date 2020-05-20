using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 管理员表
	/// </summary>
	[Serializable]
	public partial class SysAdverter
	{
		public SysAdverter()
		{}
		#region Model
		private Guid _id;
		private string _name;
		private string _code;
		private int _type;
		private string _remark;
		private int _num;
		private int _height;
		private int _width;
		private string _target;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 广告位名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 广告位类型 1文字2图片3幻灯片4动画5FLV视频6代码
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 显示数量
		/// </summary>
		public int Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 高度
		/// </summary>
		public int Height
		{
			set{ _height=value;}
			get{return _height;}
		}
		/// <summary>
		/// 宽度
		/// </summary>
		public int Width
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// _blank新窗口_self原窗口
		/// </summary>
		public string Target
		{
			set{ _target=value;}
			get{return _target;}
		}
		#endregion Model

	}
}

