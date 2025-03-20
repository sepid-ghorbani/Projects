using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Cartexes: BusinessObjectBase
	{

		#region InnerClass
		public enum CartexesFields
		{
			Id,
			CustomerId,
			JobName,
			JobCode,
			Description,
			StoreCode,
			Stock
		}
		#endregion

		#region Data Members

			int _id;
			int _customerId;
			string _jobName;
			string _jobCode;
			string _description;
			int? _storeCode;
			long _stock;

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

		public int  CustomerId
		{
			 get { return _customerId; }
			 set
			 {
				 if (_customerId != value)
				 {
					_customerId = value;
					 PropertyHasChanged("CustomerId");
				 }
			 }
		}

		public string  JobName
		{
			 get { return _jobName; }
			 set
			 {
				 if (_jobName != value)
				 {
					_jobName = value;
					 PropertyHasChanged("JobName");
				 }
			 }
		}

		public string  JobCode
		{
			 get { return _jobCode; }
			 set
			 {
				 if (_jobCode != value)
				 {
					_jobCode = value;
					 PropertyHasChanged("JobCode");
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

		public int?  StoreCode
		{
			 get { return _storeCode; }
			 set
			 {
				 if (_storeCode != value)
				 {
					_storeCode = value;
					 PropertyHasChanged("StoreCode");
				 }
			 }
		}

		public long  Stock
		{
			 get { return _stock; }
			 set
			 {
				 if (_stock != value)
				 {
					_stock = value;
					 PropertyHasChanged("Stock");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CustomerId", "CustomerId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobName", "JobName"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("JobName", "JobName",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobCode", "JobCode"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("JobCode", "JobCode",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Stock", "Stock"));
		}

		#endregion

	}
}
