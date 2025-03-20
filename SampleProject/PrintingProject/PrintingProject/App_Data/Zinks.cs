using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Zinks: BusinessObjectBase
	{

		#region InnerClass
		public enum ZinksFields
		{
			Id,
			JobId,
			OrderReceiverId,
			OtherOrderReceiver,
			Dimension,
			MainColorCount,
			ExportColor,
			SpotColorCount,
			SpotColors,
			OverPrintBlackColor,
			DeviceCount,
			FormEvertCount,
			Description
		}
		#endregion

		#region Data Members

			int _id;
			int _jobId;
			int? _orderReceiverId;
			string _otherOrderReceiver;
			string _dimension;
			string _mainColorCount;
			string _exportColor;
			string _spotColorCount;
			string _spotColors;
			int _overPrintBlackColor;
			string _deviceCount;
			string _formEvertCount;
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

		public int?  OrderReceiverId
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

		public string  OtherOrderReceiver
		{
			 get { return _otherOrderReceiver; }
			 set
			 {
				 if (_otherOrderReceiver != value)
				 {
					_otherOrderReceiver = value;
					 PropertyHasChanged("OtherOrderReceiver");
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

		public string  MainColorCount
		{
			 get { return _mainColorCount; }
			 set
			 {
				 if (_mainColorCount != value)
				 {
					_mainColorCount = value;
					 PropertyHasChanged("MainColorCount");
				 }
			 }
		}

		public string  ExportColor
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

		public string  SpotColorCount
		{
			 get { return _spotColorCount; }
			 set
			 {
				 if (_spotColorCount != value)
				 {
					_spotColorCount = value;
					 PropertyHasChanged("SpotColorCount");
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

		public int  OverPrintBlackColor
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

		public string  DeviceCount
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

		public string  FormEvertCount
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobId", "JobId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("OtherOrderReceiver", "OtherOrderReceiver",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Dimension", "Dimension"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Dimension", "Dimension",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("MainColorCount", "MainColorCount"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("MainColorCount", "MainColorCount",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ExportColor", "ExportColor"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("ExportColor", "ExportColor",50));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("SpotColorCount", "SpotColorCount"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("SpotColorCount", "SpotColorCount",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("SpotColors", "SpotColors",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OverPrintBlackColor", "OverPrintBlackColor"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("DeviceCount", "DeviceCount",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("FormEvertCount", "FormEvertCount",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
		}

		#endregion

	}
}
