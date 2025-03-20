using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Films: BusinessObjectBase
	{

		#region InnerClass
		public enum FilmsFields
		{
			Id,
			JobId,
			OrderReceiverId,
			Dimension,
			LpiId,
			MainColorCountId,
			ExportColor,
			SpotColorCountId,
			SpotColors,
			OverPrintBlackColor,
			DeviceCount,
			FormEvertCount,
			Film,
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
			int _lpiId;
			int? _mainColorCountId;
			int _exportColor;
			int? _spotColorCountId;
			string _spotColors;
			bool _overPrintBlackColor;
			int? _deviceCount;
			double? _formEvertCount;
			bool _film;
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

		public int  LpiId
		{
			 get { return _lpiId; }
			 set
			 {
				 if (_lpiId != value)
				 {
					_lpiId = value;
					 PropertyHasChanged("LpiId");
				 }
			 }
		}

		public int?  MainColorCountId
		{
			 get { return _mainColorCountId; }
			 set
			 {
				 if (_mainColorCountId != value)
				 {
					_mainColorCountId = value;
					 PropertyHasChanged("MainColorCountId");
				 }
			 }
		}

		public int  ExportColor
		{
			 get { return _exportColor; }
			 set
			 {
				 if (_exportColor != value)
				 {
					_exportColor = value;
					 PropertyHasChanged("ExportColor");
				 }
			 }
		}

		public int?  SpotColorCountId
		{
			 get { return _spotColorCountId; }
			 set
			 {
				 if (_spotColorCountId != value)
				 {
					_spotColorCountId = value;
					 PropertyHasChanged("SpotColorCountId");
				 }
			 }
		}

		public string  SpotColors
		{
			 get { return _spotColors; }
			 set
			 {
				 if (_spotColors != value)
				 {
					_spotColors = value;
					 PropertyHasChanged("SpotColors");
				 }
			 }
		}

		public bool  OverPrintBlackColor
		{
			 get { return _overPrintBlackColor; }
			 set
			 {
				 if (_overPrintBlackColor != value)
				 {
					_overPrintBlackColor = value;
					 PropertyHasChanged("OverPrintBlackColor");
				 }
			 }
		}

		public int?  DeviceCount
		{
			 get { return _deviceCount; }
			 set
			 {
				 if (_deviceCount != value)
				 {
					_deviceCount = value;
					 PropertyHasChanged("DeviceCount");
				 }
			 }
		}

		public double?  FormEvertCount
		{
			 get { return _formEvertCount; }
			 set
			 {
				 if (_formEvertCount != value)
				 {
					_formEvertCount = value;
					 PropertyHasChanged("FormEvertCount");
				 }
			 }
		}

		public bool  Film
		{
			 get { return _film; }
			 set
			 {
				 if (_film != value)
				 {
					_film = value;
					 PropertyHasChanged("Film");
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
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Dimension", "Dimension",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("LpiId", "LpiId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ExportColor", "ExportColor"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("SpotColors", "SpotColors",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OverPrintBlackColor", "OverPrintBlackColor"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Film", "Film"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceRow", "InvoiceRow",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("InvoiceNum", "InvoiceNum",50));
		}

		#endregion

	}
}
