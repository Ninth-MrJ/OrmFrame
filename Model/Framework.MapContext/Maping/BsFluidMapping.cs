﻿

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验类型 - 实体类
	/// </summary>
	public partial class BsFluidMapping: ClassMap<BsFluid>
	{   
		/// <summary>
		/// 检验类型 - 实体类
		/// </summary>
		public BsFluidMapping()
		{
			this.TableName("BSFLUID").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

