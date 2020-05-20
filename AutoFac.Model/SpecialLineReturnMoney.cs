using System;
namespace AutoFac.Model
{
	/// <summary>
	/// 车辆品牌型号(CarModel)
	/// </summary>
	[Serializable]
	public partial class SpecialLineReturnMoney
	{
		public SpecialLineReturnMoney()
		{}
		#region Model
		private Guid _id;
		private Guid _speciallineorderid;
		private int _returnseat=0;
		private decimal _returnmoney=0M;
		private string _returnusermark;
		private string _backremark;
		private DateTime _createtime;
		private DateTime _returnmoneytime;
		private string _returnorderno;
		private Guid _createuserid;
		private int _status;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 订单id
		/// </summary>
		public Guid SpecialLineOrderId
		{
			set{ _speciallineorderid=value;}
			get{return _speciallineorderid;}
		}
		/// <summary>
		/// 退订的座位数量
		/// </summary>
		public int ReturnSeat
		{
			set{ _returnseat=value;}
			get{return _returnseat;}
		}
		/// <summary>
		/// 退订的金钱
		/// </summary>
		public decimal ReturnMoney
		{
			set{ _returnmoney=value;}
			get{return _returnmoney;}
		}
		/// <summary>
		/// 用户退款备注
		/// </summary>
		public string ReturnUserMark
		{
			set{ _returnusermark=value;}
			get{return _returnusermark;}
		}
		/// <summary>
		/// 系统规则备注
		/// </summary>
		public string BackRemark
		{
			set{ _backremark=value;}
			get{return _backremark;}
		}
		/// <summary>
		/// 用户申请退订时间
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 退款时间
		/// </summary>
		public DateTime ReturnMoneyTime
		{
			set{ _returnmoneytime=value;}
			get{return _returnmoneytime;}
		}
		/// <summary>
		/// 退款单号
		/// </summary>
		public string ReturnOrderNo
		{
			set{ _returnorderno=value;}
			get{return _returnorderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid CreateUserId
		{
			set{ _createuserid=value;}
			get{return _createuserid;}
		}
		/// <summary>
		/// 状态1正常0退款中-1待支付-2失效-3全部退款-4部分退款
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

