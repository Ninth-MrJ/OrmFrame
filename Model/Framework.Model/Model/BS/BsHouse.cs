﻿

using System;
namespace XYHis.Model
{
    /// <summary>
    /// 药库表 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsHouse : BaseModel
    {

        

        private string _code;  //药库ID

        private string _name;  //药库

        private string _wbCode;  //五笔码

        private string _pyCode;  //拼音码

        private int _orderBy;  //显示顺序

        private bool _isActive;  //有效标志

        private int _iconIndex;  //图标类型

        private bool _isHouse;  //是否物资库

        private int _locationId;  //所属科室

        private int _roomId;  //在参数IsHuRmInOne控制药房药库合二为一的时候，如果RoomId有值，就在采购入库审核的时候直接把药品出库到RoomId的药房

        private string _upCode;  //行心云:上报码

        private string _ybCode;  //行心云:医保码

        private double _modiOperId;  //行心云:最后修改人

        private DateTime _modiTime;  //行心云:最后修改时间

        private int _hospitalId;  //

        private int _locationID; // 诊所iD 


        /// <summary>
        /// 唯一标识
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 药库ID
        /// </summary>
        [Collumn(HeaderName = "仓库编码", RelatedTableType = null, Length = 6)]
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 药库
        /// </summary>
        [Collumn(HeaderName = "仓库", RelatedTableType = null)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 五笔码
        /// </summary>
        [Collumn(HeaderName = "五笔码", RelatedTableType = null)]
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        /// <summary>
        /// 拼音码
        /// </summary>
        [Collumn(HeaderName = "拼音码", RelatedTableType = null)]
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        [Collumn(HeaderName = "显示顺序", RelatedTableType = null)]
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>
        /// 有效标志
        /// </summary>
        [Collumn(HeaderName = "有效标志", RelatedTableType = null)]
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 图标类型   1、西药库 2、中药库 3、未用 4、总务仓 5、设备仓.
        /// </summary>
        [Collumn(HeaderName = "图标", IsShow = false, RelatedTableType = null, LstType = "1:西药库|2:中药库|3:未用|4:总务仓|5:设备仓")]
        public int IconIndex
        {
            get { return _iconIndex; }
            set { _iconIndex = value; }
        }

        /// <summary>
        /// 是否物资库
        /// </summary>
        public bool IsHouse
        {
            get { return _isHouse; }
            set { _isHouse = value; }
        }

        /// <summary>
        /// 所属科室
        /// </summary>
      
        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 在参数IsHuRmInOne控制药房药库合二为一的时候，如果RoomId有值，就在采购入库审核的时候直接把药品出库到RoomId的药房
        /// </summary>
        public int RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }

        /// <summary>
        /// 行心云:上报码
        /// </summary>
        public string UpCode
        {
            get { return _upCode; }
            set { _upCode = value; }
        }

        /// <summary>
        /// 行心云:医保码
        /// </summary>
        public string YbCode
        {
            get { return _ybCode; }
            set { _ybCode = value; }
        }

        /// <summary>
        /// 行心云:最后修改人
        /// </summary>
        public double ModiOperId
        {
            get { return _modiOperId; }
            set { _modiOperId = value; }
        }

        /// <summary>
        /// 行心云:最后修改时间
        /// </summary>
        public DateTime ModiTime
        {
            get { return _modiTime; }
            set { _modiTime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }

        public int LocationID
        {
            get
            {
                return this._locationID;
            }
            set
            {
                this._locationID = value;
            }
        }

    }
}


