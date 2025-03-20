using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Jobs: BusinessObjectBase
	{

		#region InnerClass
		public enum JobsFields
		{
			Id,
			CustomerId,
			Name,
			CreateDate,
			Description,
            Code,
            StoreCode
		}
		#endregion

		#region Data Members

			int _id;
			int _customerId;
			string _name;
			DateTime _createDate;
			string _description;
			string _code;
            int? _storeCode;

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

		public string  Name
		{
			 get { return _name; }
			 set
			 {
				 if (_name != value)
				 {
					_name = value;
					 PropertyHasChanged("Name");
				 }
			 }
		}

		public DateTime  CreateDate
		{
			 get { return _createDate; }
			 set
			 {
				 if (_createDate != value)
				 {
					_createDate = value;
					 PropertyHasChanged("CreateDate");
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
        public string Code
        {
            get { return _code; }
            set
            {
                if (_code != value)
                {
                    _code = value;
                    PropertyHasChanged("Code");
                }
            }
        }
        public string CreateDatePersian
        {
            get
            {
                PersianDateCal p = new PersianDateCal();
                return p.ConvertToPersianDate(CreateDate, "Y/m/d");
            }


        }
        public int? StoreCode
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
		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CustomerId", "CustomerId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Name", "Name"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name", "Name",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CreateDate", "CreateDate"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Code", "Code",2147483647));
		}

		#endregion

	}
}
