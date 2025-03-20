using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class ProductDelivery: BusinessObjectBase
	{

		#region InnerClass
		public enum ProductDeliveryFields
		{
			Id,
			CartexId,
            OrderReceiverId,
            JobTypesId,
			DeliveryReceiversId,
			DeliveryCount,
			Fee1,
			DeliveryDate,
            ReceiptNum,
			Description,
			InputInvoiceDate,
			InputInvoiceRow,
			InputInvoiceNum,
			InputInvoiceCost,
			OutputInvoiceDate,
			OutputInvoiceRow,
			OutputInvoiceNum,
			OutputInvoiceCost
		}
		#endregion

		#region Data Members

			int _id;
			int _cartexId;
            int? _orderReceiverId;
            int? _jobTypesId;
			int? _deliveryReceiversId;
			int _deliveryCount;
			decimal _fee1;
			DateTime _deliveryDate;
            string _receiptNum;
			string _description;
			DateTime? _inputInvoiceDate;
			string _inputInvoiceRow;
			string _inputInvoiceNum;
			decimal? _inputInvoiceCost;
			DateTime? _outputInvoiceDate;
			string _outputInvoiceRow;
			string _outputInvoiceNum;
			decimal? _outputInvoiceCost;

		#endregion

		#region Properties

		public int  Id
		{
			 get { return _id; }
			 set
			 {
				 if (_id != value)
				 {
					_id = value;
					 PropertyHasChanged("Id");
				 }
			 }
		}

		public int  CartexId
		{
			 get { return _cartexId; }
			 set
			 {
				 if (_cartexId != value)
				 {
					_cartexId = value;
					 PropertyHasChanged("CartexId");
				 }
			 }
		}

        public int? OrderReceiverId
        {
            get { return _orderReceiverId; }
            set
            {
                if (_orderReceiverId != value)
                {
                    _orderReceiverId = value;
                    PropertyHasChanged("OrderReceiverId");
                }
            }
        }

        public int? JobTypesId
        {
            get { return _jobTypesId; }
            set
            {
                if (_jobTypesId != value)
                {
                    _jobTypesId = value;
                    PropertyHasChanged("JobTypesId");
                }
            }
        }
		public int?  DeliveryReceiversId
		{
			 get { return _deliveryReceiversId; }
			 set
			 {
				 if (_deliveryReceiversId != value)
				 {
					_deliveryReceiversId = value;
					 PropertyHasChanged("DeliveryReceiversId");
				 }
			 }
		}

		public int  DeliveryCount
		{
			 get { return _deliveryCount; }
			 set
			 {
				 if (_deliveryCount != value)
				 {
					_deliveryCount = value;
					 PropertyHasChanged("DeliveryCount");
				 }
			 }
		}

		public decimal  Fee1
		{
			 get { return _fee1; }
			 set
			 {
				 if (_fee1 != value)
				 {
					_fee1 = value;
					 PropertyHasChanged("Fee1");
				 }
			 }
		}

		public DateTime  DeliveryDate
		{
			 get { return _deliveryDate; }
			 set
			 {
				 if (_deliveryDate != value)
				 {
					_deliveryDate = value;
					 PropertyHasChanged("DeliveryDate");
				 }
			 }
		}

        public string ReceiptNum
        {
            get { return _receiptNum; }
            set
            {
                if (_receiptNum != value)
                {
                    _receiptNum = value;
                    PropertyHasChanged("ReceiptNum");
                }
            }
        }
		public string  Description
		{
			 get { return _description; }
			 set
			 {
				 if (_description != value)
				 {
					_description = value;
					 PropertyHasChanged("Description");
				 }
			 }
		}

		public DateTime?  InputInvoiceDate
		{
			 get { return _inputInvoiceDate; }
			 set
			 {
				 if (_inputInvoiceDate != value)
				 {
					_inputInvoiceDate = value;
					 PropertyHasChanged("InputInvoiceDate");
				 }
			 }
		}

		public string  InputInvoiceRow
		{
			 get { return _inputInvoiceRow; }
			 set
			 {
				 if (_inputInvoiceRow != value)
				 {
					_inputInvoiceRow = value;
					 PropertyHasChanged("InputInvoiceRow");
				 }
			 }
		}

		public string  InputInvoiceNum
		{
			 get { return _inputInvoiceNum; }
			 set
			 {
				 if (_inputInvoiceNum != value)
				 {
					_inputInvoiceNum = value;
					 PropertyHasChanged("InputInvoiceNum");
				 }
			 }
		}

		public decimal?  InputInvoiceCost
		{
			 get { return _inputInvoiceCost; }
			 set
			 {
				 if (_inputInvoiceCost != value)
				 {
					_inputInvoiceCost = value;
					 PropertyHasChanged("InputInvoiceCost");
				 }
			 }
		}

		public DateTime?  OutputInvoiceDate
		{
			 get { return _outputInvoiceDate; }
			 set
			 {
				 if (_outputInvoiceDate != value)
				 {
					_outputInvoiceDate = value;
					 PropertyHasChanged("OutputInvoiceDate");
				 }
			 }
		}

		public string  OutputInvoiceRow
		{
			 get { return _outputInvoiceRow; }
			 set
			 {
				 if (_outputInvoiceRow != value)
				 {
					_outputInvoiceRow = value;
					 PropertyHasChanged("OutputInvoiceRow");
				 }
			 }
		}

		public string  OutputInvoiceNum
		{
			 get { return _outputInvoiceNum; }
			 set
			 {
				 if (_outputInvoiceNum != value)
				 {
					_outputInvoiceNum = value;
					 PropertyHasChanged("OutputInvoiceNum");
				 }
			 }
		}

		public decimal?  OutputInvoiceCost
		{
			 get { return _outputInvoiceCost; }
			 set
			 {
				 if (_outputInvoiceCost != value)
				 {
					_outputInvoiceCost = value;
					 PropertyHasChanged("OutputInvoiceCost");
				 }
			 }
		}

		

		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CartexId", "CartexId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("DeliveryCount", "DeliveryCount"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Fee1", "Fee1"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("DeliveryDate", "DeliveryDate"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InputInvoiceRow", "InputInvoiceRow",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InputInvoiceNum", "InputInvoiceNum",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("OutputInvoiceRow", "OutputInvoiceRow",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("OutputInvoiceNum", "OutputInvoiceNum",50));
		}

		#endregion

	}
}
