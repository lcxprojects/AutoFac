using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class ChatHistoryReadLog
	{
		public ChatHistoryReadLog()
		{}
		#region Model
		private Guid _id;
		private Guid _msgid;
		private Guid _userid;
		private DateTime _addtime;
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
		public Guid MsgId
		{
			set{ _msgid=value;}
			get{return _msgid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

