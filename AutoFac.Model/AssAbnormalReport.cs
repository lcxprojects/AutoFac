using System;
namespace AutoFac.Model
{
	/// <summary>
	/// AssAbnormalReport:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AssAbnormalReport
	{
		public AssAbnormalReport()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private int _usertype;
		private Guid _recid;
		private string _content;
		private string _imgurls;
		private DateTime _createtime;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户Id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 用户类型，0车主、1乘客
		/// </summary>
		public int UserType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid RecId
		{
			set{ _recid=value;}
			get{return _recid;}
		}
		/// <summary>
		/// 异常报备内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 图片路径，逗号隔开
		/// </summary>
		public string ImgUrls
		{
			set{ _imgurls=value;}
			get{return _imgurls;}
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

