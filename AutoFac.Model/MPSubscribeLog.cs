using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class MPSubscribeLog
	{
		public MPSubscribeLog()
		{}
		#region Model
		private Guid _id;
		private Guid _fromuserid;
		private Guid _touserid;
		private string _touseropenid;
		private string _tousernickname;
		private string _touserphoto;
		private DateTime _addtime;
		private int _scantype=0;
		private int _reftype=0;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 推荐人userid
		/// </summary>
		public Guid FromUserId
		{
			set{ _fromuserid=value;}
			get{return _fromuserid;}
		}
		/// <summary>
		/// 被推荐人OpenId
		/// </summary>
		public Guid ToUserId
		{
			set{ _touserid=value;}
			get{return _touserid;}
		}
		/// <summary>
		/// 被推荐人OpenId
		/// </summary>
		public string ToUserOpenId
		{
			set{ _touseropenid=value;}
			get{return _touseropenid;}
		}
		/// <summary>
		/// 被推荐人OpenId
		/// </summary>
		public string ToUserNickName
		{
			set{ _tousernickname=value;}
			get{return _tousernickname;}
		}
		/// <summary>
		/// 被推荐人OpenId
		/// </summary>
		public string ToUserPhoto
		{
			set{ _touserphoto=value;}
			get{return _touserphoto;}
		}
		/// <summary>
		/// 关注时间
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 扫描类型，0新关注请求，1已关注又扫码请求
		/// </summary>
		public int ScanType
		{
			set{ _scantype=value;}
			get{return _scantype;}
		}
		/// <summary>
		/// 拉新类型，0拉新用户，1贡献值拉新
		/// </summary>
		public int RefType
		{
			set{ _reftype=value;}
			get{return _reftype;}
		}
		#endregion Model

	}
}

