using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class VisitorSendTmplLog
	{
		public VisitorSendTmplLog()
		{}
		#region Model
		private Guid _id;
		private string _openid;
		private string _tmplid;
		private string _tmplname;
		private DateTime _sendtime;
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
		public string OpenId
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 微信模板消息id
		/// </summary>
		public string TmplId
		{
			set{ _tmplid=value;}
			get{return _tmplid;}
		}
		/// <summary>
		/// 微信模板消息名称
		/// </summary>
		public string TmplName
		{
			set{ _tmplname=value;}
			get{return _tmplname;}
		}
		/// <summary>
		/// 发送时间
		/// </summary>
		public DateTime SendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
		}
		#endregion Model

	}
}

