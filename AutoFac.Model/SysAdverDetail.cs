using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 管理员表
	/// </summary>
	[Serializable]
	public partial class SysAdverDetail
	{
		public SysAdverDetail()
		{}
		#region Model
		private Guid _id;
		private Guid _adverterid;
		private string _advertername;
		private string _imgurl;
		private string _url;
		private DateTime _begintime;
		private DateTime _endtime;
		private int _ordernum;
		private int _isenabled;
		private string _remark;
		private string _line;
		private int _platform=0;
		private int _selectclick=0;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 广告位ID
		/// </summary>
		public Guid AdverterId
		{
			set{ _adverterid=value;}
			get{return _adverterid;}
		}
		/// <summary>
		/// 广告位名称
		/// </summary>
		public string AdverterName
		{
			set{ _advertername=value;}
			get{return _advertername;}
		}
		/// <summary>
		/// 图片地址
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 链接网址
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 投放时间
		/// </summary>
		public DateTime BeginTime
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 到期时间
		/// </summary>
		public DateTime EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
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
		/// 状态1正常0暂停
		/// </summary>
		public int IsEnabled
		{
			set{ _isenabled=value;}
			get{return _isenabled;}
		}
		/// <summary>
		/// 备注代码
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 线路，为空代表全部。例如：郑州-全部
		/// </summary>
		public string Line
		{
			set{ _line=value;}
			get{return _line;}
		}
		/// <summary>
		/// 要显示的平台，0代表全部，1微信
		/// </summary>
		public int Platform
		{
			set{ _platform=value;}
			get{return _platform;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SelectClick
		{
			set{ _selectclick=value;}
			get{return _selectclick;}
		}
		#endregion Model

	}
}

