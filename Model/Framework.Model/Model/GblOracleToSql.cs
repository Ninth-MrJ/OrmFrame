﻿

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class GblOracleToSql : BaseModel
    {   
		 
		private string _oracleTable;  //
		
		private string _oracleColumn;  //
		
		private string _sqlTable;  //
		
		private string _sqlColumn;  //
		 
         
		/// <summary>
		/// 
		/// </summary>
		public string OracleTable
		{
			get { return _oracleTable;}
			set { _oracleTable = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OracleColumn
		{
			get { return _oracleColumn;}
			set { _oracleColumn = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SqlTable
		{
			get { return _sqlTable;}
			set { _sqlTable = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SqlColumn
		{
			get { return _sqlColumn;}
			set { _sqlColumn = value;}
		}                                    
		        
	}  
}           


