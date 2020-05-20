using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserVehichesBlack
	{
		public UserVehichesBlack()
		{}
		#region Model
		private Guid _id;
		private string _vehiclenumber;
		private string _blackcause;
		private string _adduser;
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
		/// 拉黑车牌号
		/// </summary>
		public string VehicleNumber
		{
			set{ _vehiclenumber=value;}
			get{return _vehiclenumber;}
		}
		/// <summary>
		/// 拉黑原因
		/// </summary>
		public string BlackCause
		{
			set{ _blackcause=value;}
			get{return _blackcause;}
		}
		/// <summary>
		/// 添加人
		/// </summary>
		public string AddUser
		{
			set{ _adduser=value;}
			get{return _adduser;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

