using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class MakingTemplates: BusinessObjectBase
	{

		#region InnerClass
		public enum MakingTemplatesFields
		{
			Id,
			JobId,
			OrderReceiverId,
			LetterPressDeviceId,
			TemplateMaterialTypeId,
			Dimension,
			Count,
			BladeTypeId,
			PorferazhModel,
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
			int _letterPressDeviceId;
			int _templateMaterialTypeId;
			string _dimension;
			int? _count;
			int _bladeTypeId;
			string _porferazhModel;
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

		public int  LetterPressDeviceId
		{
			 get { return _letterPressDeviceId; }
			 set
			 {
				 if (_letterPressDeviceId != value)
				 {
					_letterPressDeviceId = value;
					 PropertyHasChanged("LetterPressDeviceId");
				 }
			 }
		}

		public int  TemplateMaterialTypeId
		{
			 get { return _templateMaterialTypeId; }
			 set
			 {
				 if (_templateMaterialTypeId != value)
				 {
					_templateMaterialTypeId = value;
					 PropertyHasChanged("TemplateMaterialTypeId");
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

		public int  BladeTypeId
		{
			 get { return _bladeTypeId; }
			 set
			 {
				 if (_bladeTypeId != value)
				 {
					_bladeTypeId = value;
					 PropertyHasChanged("BladeTypeId");
				 }
			 }
		}

		public string  PorferazhModel
		{
			 get { return _porferazhModel; }
			 set
			 {
				 if (_porferazhModel != value)
				 {
					_porferazhModel = value;
					 PropertyHasChanged("PorferazhModel");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("LetterPressDeviceId", "LetterPressDeviceId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("TemplateMaterialTypeId", "TemplateMaterialTypeId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Dimension", "Dimension",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("BladeTypeId", "BladeTypeId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("PorferazhModel", "PorferazhModel",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceRow", "InvoiceRow",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceNum", "InvoiceNum",50));
		}

		#endregion

	}
}
