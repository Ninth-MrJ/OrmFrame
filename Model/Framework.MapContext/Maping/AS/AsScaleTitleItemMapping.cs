﻿using ELinq.Mapping.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.MapContext.Maping.AS
{
    public class AsScaleTitleItemMapping: ClassMap<AsScaleTitleItem>
    {
        public AsScaleTitleItemMapping()
        {
            this.TableName("AsScaleTitleItem").Schema("orm");
            this.Column(p => p.AsScaleTitleId).ColumnName("ASSCALETITLEID");
            this.Column(p => p.ItemName).ColumnName("ITEMNAME");
            this.Column(p => p.Score).ColumnName("SCORE");
            this.Column(p => p.AddText).ColumnName("ADDTEXT");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.ID).ColumnName("ID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.ModioperID).ColumnName("MODIOPERID");

            this.Id(t => t.ID); this.Ignore(p => p.IsModify);
        }
    }
}
