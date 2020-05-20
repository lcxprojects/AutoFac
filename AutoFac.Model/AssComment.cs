using System;
namespace AutoFac.Model
{
	/// <summary>
	/// AssComment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AssComment
	{
		public AssComment()
		{}
		#region Model
		private Guid _id;
		private Guid _assid;
		private Guid _assuserid;
		private string _assuserphone;
		private Guid _recid;
		private Guid _recuserid;
		private string _recphone;
		private int _score=1;
		private string _context;
		private DateTime _addtime= DateTime.Now;
		private string _tag;
		private string _reply;
		private DateTime? _replytime;
		private int _isshow=1;
		private string _contextevaluate;
		private int _type=0;
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
		/// 拼车信息Id
		/// </summary>
		public Guid AssId
		{
			set{ _assid=value;}
			get{return _assid;}
		}
		/// <summary>
		/// 车主用户id
		/// </summary>
		public Guid AssUserId
		{
			set{ _assuserid=value;}
			get{return _assuserid;}
		}
		/// <summary>
		/// 车主电话
		/// </summary>
		public string AssUserPhone
		{
			set{ _assuserphone=value;}
			get{return _assuserphone;}
		}
		/// <summary>
		/// 拼车信息
		/// </summary>
		public Guid RecId
		{
			set{ _recid=value;}
			get{return _recid;}
		}
		/// <summary>
		/// 乘客用户id
		/// </summary>
		public Guid RecUserId
		{
			set{ _recuserid=value;}
			get{return _recuserid;}
		}
		/// <summary>
		/// 乘客电话
		/// </summary>
		public string RecPhone
		{
			set{ _recphone=value;}
			get{return _recphone;}
		}
		/// <summary>
		/// 评分，0差评，1好评
		/// </summary>
		public int Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		/// <summary>
		/// 评价内容
		/// </summary>
		public string Context
		{
			set{ _context=value;}
			get{return _context;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 标签
		/// </summary>
		public string Tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// 车主回复
		/// </summary>
		public string Reply
		{
			set{ _reply=value;}
			get{return _reply;}
		}
		/// <summary>
		/// 车主回复时间
		/// </summary>
		public DateTime? ReplyTime
		{
			set{ _replytime=value;}
			get{return _replytime;}
		}
		/// <summary>
		/// 1显示，0仅乘客可见
		/// </summary>
		public int IsShow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
		/// <summary>
		/// 评价内容,差评必填,好评选填
		/// </summary>
		public string ContextEvaluate
		{
			set{ _contextevaluate=value;}
			get{return _contextevaluate;}
		}
		/// <summary>
		/// type=0 乘客评价车主;type=1车主评价乘客
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
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

