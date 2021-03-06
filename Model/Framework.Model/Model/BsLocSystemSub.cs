﻿

using System;
namespace Orm.Model
{
	/// <summary>
	/// 多媒体——科室分类表2 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsLocSystemSub:BaseModel
	{   
		 
		private string _mainId;  //对应的大类ID
		
		private string _code;  //科室子类
		
		private string _name;  //科室子类名称
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 对应的大类ID
		/// </summary>
		public string MainId
		{
			get { return _mainId;}
			set { _mainId = value;}
		}                                    
		
		/// <summary>
		/// 科室子类
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 科室子类名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}
    
    }  
}           


