using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class SupervisionApply
	{
		public SupervisionApply()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _name;
		private string _tel;
		private string _idcardphoto;
		private string _licensephoto;
		private string _note;
		private int _authstatus;
		private string _authnote;
		private DateTime? _authtime;
		private DateTime _createtime;
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
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IdCardPhoto
		{
			set{ _idcardphoto=value;}
			get{return _idcardphoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LicensePhoto
		{
			set{ _licensephoto=value;}
			get{return _licensephoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Note
		{
			set{ _note=value;}
			get{return _note;}
		}
		/// <summary>
		/// 审核状态，-1不通过，0待审核，1已审核
		/// </summary>
		public int AuthStatus
		{
			set{ _authstatus=value;}
			get{return _authstatus;}
		}
		/// <summary>
		/// 审核意见
		/// </summary>
		public string AuthNote
		{
			set{ _authnote=value;}
			get{return _authnote;}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime? AuthTime
		{
			set{ _authtime=value;}
			get{return _authtime;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

