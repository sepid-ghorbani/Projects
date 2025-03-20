using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Stereotypes: BusinessObjectBase
	{

		#region InnerClass
		public enum StereotypesFields
		{
			Id,
			JobId,
			OrderReceiverId,
			Dimension,
			Thickness,
			Type,
			Stereotype,
			StereotypeUsagesId,
			Count,
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
			string _dimension;
			int _thickness;
			int _type;
			bool _stereotype;
			int _stereotypeUsagesId;
			int? _count;
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

		public int  Thickness
		{
			 get { return _thickness; }
			 set
			 {
				 if (_thickness != value)
				 {
					_thickness = value;
					 PropertyHasChanged("Thickness");
				 }
			 }
		}

		public int  Type
		{
			 get { return _type; }
			 set
			 {
				 if (_type != value)
				 {
					_type = value;
					 PropertyHasChanged("Type");
				 }
			 }
		}

		public bool  Stereotype
		{
			 get { return _stereotype; }
			 set
			 {
				 if (_stereotype != value)
				 {
					_stereotype = value;
					 PropertyHasChanged("Stereotype");
				 }
			 }
		}

		public int  StereotypeUsagesId
		{
			 get { return _stereotypeUsagesId; }
			 set
			 {
				 if (_stereotypeUsagesId != value)
				 {
					_stereotypeUsagesId = value;
					 PropertyHasChanged("StereotypeUsagesId");
				 }
			 }
		}

		public int?  Count
		{
			 get { return _count; }
			 set
			 {
				 if (_count != value)
				 {
					_count = value;
					 PropertyHasChanged("Count");
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
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Dimension", "Dimension",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Thickness", "Thickness"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Type", "Type"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Stereotype", "Stereotype"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("StereotypeUsagesId", "StereotypeUsagesId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceRow", "InvoiceRow",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceNum", "InvoiceNum",50));
		}

		#endregion

	}
}
