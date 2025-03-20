using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Sahafies: BusinessObjectBase
	{

		#region InnerClass
		public enum SahafiesFields
		{
			Id,
			JobId,
			OrderReceiverId,
			SahafiTypeId,
			Tirazh,
			Dimension,
			PocketGlue,
			PaperGramazh,
			TextFormCount,
			FormSum,
			Description,
			InvoiceRow,
			InvoiceNum,
			InvoiceCost
		}
		#endregion

		#region Data Members

			int _id;
			int _jobId;
			int _orderReceiverId;
			int _sahafiTypeId;
			int? _tirazh;
			string _dimension;
			bool? _pocketGlue;
			string _paperGramazh;
			int? _textFormCount;
			int? _formSum;
			string _description;
			string _invoiceRow;
			string _invoiceNum;
			decimal? _invoiceCost;

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

		public int  SahafiTypeId
		{
			 get { return _sahafiTypeId; }
			 set
			 {
				 if (_sahafiTypeId != value)
				 {
					_sahafiTypeId = value;
					 PropertyHasChanged("SahafiTypeId");
				 }
			 }
		}

		public int?  Tirazh
		{
			 get { return _tirazh; }
			 set
			 {
				 if (_tirazh != value)
				 {
					_tirazh = value;
					 PropertyHasChanged("Tirazh");
				 }
			 }
		}

		public string  Dimension
		{
			 get { return _dimension; }
			 set
			 {
				 if (_dimension != value)
				 {
					_dimension = value;
					 PropertyHasChanged("Dimension");
				 }
			 }
		}

		public bool?  PocketGlue
		{
			 get { return _pocketGlue; }
			 set
			 {
				 if (_pocketGlue != value)
				 {
					_pocketGlue = value;
					 PropertyHasChanged("PocketGlue");
				 }
			 }
		}

		public string  PaperGramazh
		{
			 get { return _paperGramazh; }
			 set
			 {
				 if (_paperGramazh != value)
				 {
					_paperGramazh = value;
					 PropertyHasChanged("PaperGramazh");
				 }
			 }
		}

		public int?  TextFormCount
		{
			 get { return _textFormCount; }
			 set
			 {
				 if (_textFormCount != value)
				 {
					_textFormCount = value;
					 PropertyHasChanged("TextFormCount");
				 }
			 }
		}

		public int?  FormSum
		{
			 get { return _formSum; }
			 set
			 {
				 if (_formSum != value)
				 {
					_formSum = value;
					 PropertyHasChanged("FormSum");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobId", "JobId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OrderReceiverId", "OrderReceiverId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SahafiTypeId", "SahafiTypeId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Dimension", "Dimension",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("PaperGramazh", "PaperGramazh",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceRow", "InvoiceRow",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceNum", "InvoiceNum",50));
		}

		#endregion

	}
}
