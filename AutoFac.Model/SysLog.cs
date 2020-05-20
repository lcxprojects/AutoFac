using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 日志表
	/// </summary>
	[Serializable]
	public partial class SysLog
	{
		public SysLog()
		{}
		#region Model
		private Guid _id;
		private string _title;
		private string _level;
		private string _content;
		private DateTime _addtime= DateTime.Now;
		/// <summary>
		/// Id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 日志标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 日志级别
		/// </summary>
		public string Level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 日志内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

