using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class PrimaryStock: BusinessObjectBase
	{

		#region InnerClass
		public enum PrimaryStockFields
		{
			Id,
			CartexId,
			FromOrderReceiversId,
			ToOrderReceiversId,
			JobTypesId,
			JobCount,
			Description,
            CreateDate
			
		}
		#endregion

		#region Data Members

			int _id;
			int _cartexId;
			int _fromOrderReceiversId;
			int _toOrderReceiversId;
			int _jobTypesId;
			int? _jobCount;
			string _description;
            DateTime? _createDate;

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

		public int  FromOrderReceiversId
		{
			 get { return _fromOrderReceiversId; }
			 set
			 {
				 if (_fromOrderReceiversId != value)
				 {
					_fromOrderReceiversId = value;
					 PropertyHasChanged("FromOrderReceiversId");
				 }
			 }
		}

		public int  ToOrderReceiversId
		{
			 get { return _toOrderReceiversId; }
			 set
			 {
				 if (_toOrderReceiversId != value)
				 {
					_toOrderReceiversId = value;
					 PropertyHasChanged("ToOrderReceiversId");
				 }
			 }
		}

		public int  JobTypesId
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

		public int?  JobCount
		{
			 get { return _jobCount; }
			 set
			 {
				 if (_jobCount != value)
				 {
					_jobCount = value;
					 PropertyHasChanged("JobCount");
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

        public DateTime? CreateDate
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

		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CartexId", "CartexId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FromOrderReceiversId", "FromOrderReceiversId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ToOrderReceiversId", "ToOrderReceiversId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobTypesId", "JobTypesId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
		}

		#endregion

	}
}
