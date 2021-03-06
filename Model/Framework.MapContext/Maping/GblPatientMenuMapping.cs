﻿

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class GblPatientMenuMapping: ClassMap<GblPatientMenu>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public GblPatientMenuMapping()
		{
			this.TableName("GBLPATIENTMENU").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LsType).ColumnName("LSTYPE");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			  
			this.Column(p =>p.IsTitle).ColumnName("ISTITLE");
			  
			this.Column(p =>p.FormName).ColumnName("FORMNAME");
			  
			this.Column(p =>p.TableName).ColumnName("TABLENAME");
			  
			this.Column(p =>p.IsForNew).ColumnName("ISFORNEW");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsAuth).ColumnName("ISAUTH");
			  
			this.Column(p =>p.IsPrint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.SearchConfig).ColumnName("SEARCHCONFIG");
			  
			this.Column(p =>p.FileEmt).ColumnName("FILEEMT");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

