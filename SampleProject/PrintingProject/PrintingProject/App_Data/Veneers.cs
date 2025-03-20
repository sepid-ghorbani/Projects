using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Veneers: BusinessObjectBase
	{

		#region InnerClass
		public enum VeneersFields
		{
			Id,
			JobId,
			OrderVeneer,
			OrderReceiverId,
			VeneerTypeId,
			Model,
			Tirazh,
			Dimension,
			PaperGramazh,
			Description,
			InvoiceRow,
			InvoiceNum,
			InvoiceCost
		}
		#endregion

		#region Data Members

			int _id;
			int _jobId;
			int _orderVeneer;
			int _orderReceiverId;
			int _veneerTypeId;
			int _model;
			int? _tirazh;
			string _dimension;
			string _paperGramazh;
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

		public int  OrderVeneer
		{
			 get { return _orderVeneer; }
			 set
			 {
				 if (_orderVeneer != value)
				 {
					_orderVeneer = value;
					 PropertyHasChanged("OrderVeneer");
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

		public int  VeneerTypeId
		{
			 get { return _veneerTypeId; }
			 set
			 {
				 if (_veneerTypeId != value)
				 {
					_veneerTypeId = value;
					 PropertyHasChanged("VeneerTypeId");
				 }
			 }
		}

		public int  Model
		{
			 get { return _model; }
			 set
			 {
				 if (_model != value)
				 {
					_model = value;
					 PropertyHasChanged("Model");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OrderVeneer", "OrderVeneer"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OrderReceiverId", "OrderReceiverId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("VeneerTypeId", "VeneerTypeId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Model", "Model"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Dimension", "Dimension",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("PaperGramazh", "PaperGramazh",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceRow", "InvoiceRow",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceNum", "InvoiceNum",50));
		}

		#endregion

	}
}
