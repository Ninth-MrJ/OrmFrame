﻿

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库盘亏明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuPkDtl:BaseModel
	{   
		 
		private string _billId;  //单据ID
		
		private string _inBatchId;  //药品批次ID
		
		private string _itemId;  //项目ID
		
		private string _unitId;  //单位ID
		
		private double _drugNum;  //药品数量
		
		private double _stockPrice;  //进货(买入)价
		
		private double _retailPrice;  //零售价
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 单据ID
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
		}                                    
		
		/// <summary>
		/// 药品批次ID
		/// </summary>
		public string InBatchId
		{
			get { return _inBatchId;}
			set { _inBatchId = value;}
		}                                    
		
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 单位ID
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 药品数量
		/// </summary>
		public double DrugNum
		{
			get { return _drugNum;}
			set { _drugNum = value;}
		}                                    
		
		/// <summary>
		/// 进货(买入)价
		/// </summary>
		public double StockPrice
		{
			get { return _stockPrice;}
			set { _stockPrice = value;}
		}                                    
		
		/// <summary>
		/// 零售价
		/// </summary>
		public double RetailPrice
		{
			get { return _retailPrice;}
			set { _retailPrice = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		                                   
		        
	}  
}           


