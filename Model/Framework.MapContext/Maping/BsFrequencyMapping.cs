﻿

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 频率表 - 实体类
	/// </summary>
	public partial class BsFrequencyMapping: ClassMap<BsFrequency>
	{   
		/// <summary>
		/// 频率表 - 实体类
		/// </summary>
		public BsFrequencyMapping()
		{
			this.TableName("BSFREQUENCY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PrintName).ColumnName("PRINTNAME");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.Times).ColumnName("TIMES");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsHour).ColumnName("ISHOUR");
			  
			this.Column(p =>p.IsMax).ColumnName("ISMAX");
			  
			this.Column(p =>p.UserDefined).ColumnName("USERDEFINED");
			  
			this.Column(p =>p.UpCode).ColumnName("UPCODE");
			  
			this.Column(p =>p.YbCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

