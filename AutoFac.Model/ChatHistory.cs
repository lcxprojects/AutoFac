using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class ChatHistory
	{
		public ChatHistory()
		{}
		#region Model
		private int _sn;
		private Guid _id;
		private Guid _groupname;
		private Guid _userid;
		private int _iscarowner=0;
		private string _sender;
		private string _phone;
		private string _msg;
		private DateTime _sendtime= DateTime.Now;
		private string _senderphoto;
		/// <summary>
		/// 序号
		/// </summary>
		public int SN
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 唯一标示
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 分组名称（assid）
		/// </summary>
		public Guid GroupName
		{
			set{ _groupname=value;}
			get{return _groupname;}
		}
		/// <summary>
		/// 发送人会员id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 发送人1是车主，0不是车主
		/// </summary>
		public int IsCarOwner
		{
			set{ _iscarowner=value;}
			get{return _iscarowner;}
		}
		/// <summary>
		/// 发送人名字
		/// </summary>
		public string Sender
		{
			set{ _sender=value;}
			get{return _sender;}
		}
		/// <summary>
		/// 发送人电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 发送的消息
		/// </summary>
		public string Msg
		{
			set{ _msg=value;}
			get{return _msg;}
		}
		/// <summary>
		/// 发送时间
		/// </summary>
		public DateTime SendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
		}
		/// <summary>
		/// 发送人头像
		/// </summary>
		public string SenderPhoto
		{
			set{ _senderphoto=value;}
			get{return _senderphoto;}
		}
		#endregion Model

	}
}

