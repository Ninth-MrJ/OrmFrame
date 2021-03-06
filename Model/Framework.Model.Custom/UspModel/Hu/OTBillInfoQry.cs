using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    #region class of Model:OTBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a OTBillInfo.
    /// </summary>
    public class OTBillInfoQry : BaseModel
    {
         
        private int _billId;
        private string _billNo = String.Empty;
        private int _houseId;
        private string _reason = String.Empty;
        private DateTime _operTime;
        private int _operId;
        private bool _isSign;
        private DateTime _signTime;
        private int _signOperId;
        private string _inBatchNo = String.Empty;
        private int _itemId;
        private string _pNo = String.Empty;
        private int _unitId;
        private int _compId;
        private double _drugNum;
        private double _stockPrice;
        private double _retailPrice;
        private DateTime _storeDate;
        private DateTime _produceDate;
        private DateTime _limitDate;
        private string _manufactureryName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _unitName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private double _addPercent;

        public OTBillInfoQry()
        {
        }



        #region Public Properties
            public int BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }

        public int HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }

        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        public int OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        public bool IsSign
        {
            get { return _isSign; }
            set { _isSign = value; }
        }

        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
        }

        public int SignOperId
        {
            get { return _signOperId; }
            set { _signOperId = value; }
        }

        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }

        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }

        public int UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        public int CompId
        {
            get { return _compId; }
            set { _compId = value; }
        }

        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }

        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }

        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        public DateTime StoreDate
        {
            get { return _storeDate; }
            set { _storeDate = value; }
        }

        public DateTime ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
        }

        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }

        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }

        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }

        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }

        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }

        public double AddPercent
        {
            get { return _addPercent; }
            set { _addPercent = value; }
        }
        #endregion
    }
    #endregion
}







