using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserClaim
	{
		public UserClaim()
		{}
		#region Model
		private Guid _id;
		private Guid _assid;
		private Guid _recid;
		private int _type;
		private Guid _fromuserid;
		private Guid _touserid;
		private DateTime _createtime;
		private int _state;
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
		public Guid AssId
		{
			set{ _assid=value;}
			get{return _assid;}
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
		/// 类型，0车主发起索赔、1乘客发起索赔
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 发起索赔的用户Id
		/// </summary>
		public Guid FromUserId
		{
			set{ _fromuserid=value;}
			get{return _fromuserid;}
		}
		/// <summary>
		/// 被索赔的用户Id
		/// </summary>
		public Guid ToUserId
		{
			set{ _touserid=value;}
			get{return _touserid;}
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 状态，0等待车主回复，1等待乘客回复，2等待客服介入，3弃权，4已赔付
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

