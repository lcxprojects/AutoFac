using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 角色表
	/// </summary>
	[Serializable]
	public partial class UserDalanceLog
	{
		public UserDalanceLog()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _code;
		private int _action;
		private decimal _money;
		private decimal _nowmoney;
		private DateTime _createtime= DateTime.Now;
		private string _note;
		private string _remark;
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
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 相关单号
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 0收入，1支出
		/// </summary>
		public int Action
		{
			set{ _action=value;}
			get{return _action;}
		}
		/// <summary>
		/// 变动金额
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 变动后余额
		/// </summary>
		public decimal NowMoney
		{
			set{ _nowmoney=value;}
			get{return _nowmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 给用户看的备注
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
		}
		/// <summary>
		/// 内部看的备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

