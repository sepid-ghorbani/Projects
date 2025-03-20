using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class BuyPaper: BusinessObjectBase
	{

		#region InnerClass
		public enum BuyPaperFields
		{
			Id,
			JobId,
			OrderReceiverId,
			Row,
			MaterialTypeId,
			MaterialTypeGramazhId,
			PaperWidthId,
			PaperHeightId,
			ParagraphCount,
			LeafCountId,
			Fee,
			SumCostType,
			SumCost,
			InstituteId,
			InvoiceRow,
			InvoiceNum,
			InvoiceCost,
            Description
		}
		#endregion

		#region Data Members

			int _id;
			int _jobId;
			int _orderReceiverId;
			int _row;
			int _materialTypeId;
			int _materialTypeGramazhId;
			int _paperWidthId;
			int _paperHeightId;
			int? _paragraphCount;
			int _leafCountId;
			decimal? _fee;
			int _sumCostType;
			decimal? _sumCost;
			int _instituteId;
			string _invoiceRow;
			string _invoiceNum;
			decimal? _invoiceCost;
            string _description;


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

		public int  JobId
		{
			 get { return _jobId; }
			 set
			 {
				 if (_jobId != value)
				 {
					_jobId = value;
					 PropertyHasChanged("JobId");
				 }
			 }
		}

		public int  OrderReceiverId
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

		public int  Row
		{
			 get { return _row; }
			 set
			 {
				 if (_row != value)
				 {
					_row = value;
					 PropertyHasChanged("Row");
				 }
			 }
		}

		public int  MaterialTypeId
		{
			 get { return _materialTypeId; }
			 set
			 {
				 if (_materialTypeId != value)
				 {
					_materialTypeId = value;
					 PropertyHasChanged("MaterialTypeId");
				 }
			 }
		}

		public int  MaterialTypeGramazhId
		{
			 get { return _materialTypeGramazhId; }
			 set
			 {
				 if (_materialTypeGramazhId != value)
				 {
					_materialTypeGramazhId = value;
					 PropertyHasChanged("MaterialTypeGramazhId");
				 }
			 }
		}

		public int  PaperWidthId
		{
			 get { return _paperWidthId; }
			 set
			 {
				 if (_paperWidthId != value)
				 {
					_paperWidthId = value;
					 PropertyHasChanged("PaperWidthId");
				 }
			 }
		}

		public int  PaperHeightId
		{
			 get { return _paperHeightId; }
			 set
			 {
				 if (_paperHeightId != value)
				 {
					_paperHeightId = value;
					 PropertyHasChanged("PaperHeightId");
				 }
			 }
		}

		public int?  ParagraphCount
		{
			 get { return _paragraphCount; }
			 set
			 {
				 if (_paragraphCount != value)
				 {
					_paragraphCount = value;
					 PropertyHasChanged("ParagraphCount");
				 }
			 }
		}

		public int  LeafCountId
		{
			 get { return _leafCountId; }
			 set
			 {
				 if (_leafCountId != value)
				 {
					_leafCountId = value;
					 PropertyHasChanged("LeafCountId");
				 }
			 }
		}

		public decimal?  Fee
		{
			 get { return _fee; }
			 set
			 {
				 if (_fee != value)
				 {
					_fee = value;
					 PropertyHasChanged("Fee");
				 }
			 }
		}

		public int  SumCostType
		{
			 get { return _sumCostType; }
			 set
			 {
				 if (_sumCostType != value)
				 {
					_sumCostType = value;
					 PropertyHasChanged("SumCostType");
				 }
			 }
		}

		public decimal?  SumCost
		{
			 get { return _sumCost; }
			 set
			 {
				 if (_sumCost != value)
				 {
					_sumCost = value;
					 PropertyHasChanged("SumCost");
				 }
			 }
		}

		public int  InstituteId
		{
			 get { return _instituteId; }
			 set
			 {
				 if (_instituteId != value)
				 {
					_instituteId = value;
					 PropertyHasChanged("InstituteId");
				 }
			 }
		}

		public string  InvoiceRow
		{
			 get { return _invoiceRow; }
			 set
			 {
				 if (_invoiceRow != value)
				 {
					_invoiceRow = value;
					 PropertyHasChanged("InvoiceRow");
				 }
			 }
		}

		public string  InvoiceNum
		{
			 get { return _invoiceNum; }
			 set
			 {
				 if (_invoiceNum != value)
				 {
					_invoiceNum = value;
					 PropertyHasChanged("InvoiceNum");
				 }
			 }
		}

		public decimal?  InvoiceCost
		{
			 get { return _invoiceCost; }
			 set
			 {
				 if (_invoiceCost != value)
				 {
					_invoiceCost = value;
					 PropertyHasChanged("InvoiceCost");
				 }
			 }
		}

        public string Description
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

		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobId", "JobId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OrderReceiverId", "OrderReceiverId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Row", "Row"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MaterialTypeId", "MaterialTypeId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MaterialTypeGramazhId", "MaterialTypeGramazhId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PaperWidthId", "PaperWidthId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("PaperHeightId", "PaperHeightId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("LeafCountId", "LeafCountId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SumCostType", "SumCostType"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("InstituteId", "InstituteId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceRow", "InvoiceRow",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceNum", "InvoiceNum",50));
		}

		#endregion

	}
}
