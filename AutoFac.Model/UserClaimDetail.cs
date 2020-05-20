using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserClaimDetail
	{
		public UserClaimDetail()
		{}
		#region Model
		private Guid _id;
		private Guid _assclaimid;
		private Guid _userid;
		private int _usertype;
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
		/// 
		/// </summary>
		public Guid AssClaimId
		{
			set{ _assclaimid=value;}
			get{return _assclaimid;}
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
		/// 情况说明内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 图片
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

