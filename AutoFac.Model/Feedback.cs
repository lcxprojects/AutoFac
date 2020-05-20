using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class Feedback
	{
		public Feedback()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private int _type;
		private string _content;
		private string _imgurls;
		private DateTime _addtime;
		private string _reply;
		private DateTime? _replytime;
		private string _replyuser;
		private string _replyimgurls;
		private string _remark;
		private string _orderid;
		private int _platform=0;
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
		/// 反馈类型，1建议、2系统错误、3投诉、4申诉、99其他、5车主索赔申请、6乘客索赔申请
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 反馈内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 反馈图片
		/// </summary>
		public string ImgUrls
		{
			set{ _imgurls=value;}
			get{return _imgurls;}
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 回复内容
		/// </summary>
		public string Reply
		{
			set{ _reply=value;}
			get{return _reply;}
		}
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime? ReplyTime
		{
			set{ _replytime=value;}
			get{return _replytime;}
		}
		/// <summary>
		/// 回复人
		/// </summary>
		public string ReplyUser
		{
			set{ _replyuser=value;}
			get{return _replyuser;}
		}
		/// <summary>
		/// 回复图片
		/// </summary>
		public string ReplyImgUrls
		{
			set{ _replyimgurls=value;}
			get{return _replyimgurls;}
		}
		/// <summary>
		/// 内部备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 关联订单id
		/// </summary>
		public string OrderId
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 平台0微信公众号1安卓手机app
		/// </summary>
		public int Platform
		{
			set{ _platform=value;}
			get{return _platform;}
		}
		#endregion Model

	}
}

