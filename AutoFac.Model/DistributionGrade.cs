using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class DistributionGrade
	{
		public DistributionGrade()
		{}
		#region Model
		private Guid _id;
		private string _name;
		private string _description;
		private decimal _commissionslimit;
		private decimal _commissionrise=0M;
		private int _isdefault;
		private string _ico;
		private int _isenabled;
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
		/// 等级名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 等级描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 升级条件，设置分销商打到多少订单后，自动升级到这个等级
		/// </summary>
		public decimal CommissionsLimit
		{
			set{ _commissionslimit=value;}
			get{return _commissionslimit;}
		}
		/// <summary>
		/// 反佣金比例，相对信息费的百分比
		/// </summary>
		public decimal CommissionRise
		{
			set{ _commissionrise=value;}
			get{return _commissionrise;}
		}
		/// <summary>
		/// 是否默认等级，默认等级时，升级条件需为0
		/// </summary>
		public int IsDefault
		{
			set{ _isdefault=value;}
			get{return _isdefault;}
		}
		/// <summary>
		/// 等级图标
		/// </summary>
		public string Ico
		{
			set{ _ico=value;}
			get{return _ico;}
		}
		/// <summary>
		/// 0停用，1启用
		/// </summary>
		public int IsEnabled
		{
			set{ _isenabled=value;}
			get{return _isenabled;}
		}
		/// <summary>
		/// 返佣时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

