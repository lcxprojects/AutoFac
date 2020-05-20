using System;
namespace AutoFac.Model
{
	/// <summary>
	/// AssInsurance:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AssInsurance
	{
		public AssInsurance()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private int _type;
		private Guid _assid;
		private Guid _recid;
		private string _realname;
		private string _idcard;
		private string _phone;
		private DateTime _createtime= DateTime.Now;
		private int _status=0;
		private string _insurancesn;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户Id
		/// </summary>
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 0车主，1乘客
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// AssId
		/// </summary>
		public Guid AssId
		{
			set{ _assid=value;}
			get{return _assid;}
		}
		/// <summary>
		///  RecId，type=1时 有值
		/// </summary>
		public Guid RecId
		{
			set{ _recid=value;}
			get{return _recid;}
		}
		/// <summary>
		/// 真实姓名
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 身份证号
		/// </summary>
		public string IdCard
		{
			set{ _idcard=value;}
			get{return _idcard;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
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
		/// -1不投保（退订或没有乘客或有商业险），0待确认，1系统确认投保，2用户确认投保，3已投保
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 保单号
		/// </summary>
		public string InsuranceSN
		{
			set{ _insurancesn=value;}
			get{return _insurancesn;}
		}
		#endregion Model

	}
}

