using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class OperationHistories: BusinessObjectBase
	{

		#region InnerClass
		public enum OperationHistoriesFields
		{
			Id,
			Date,
			Description,
			UserId
		}
		#endregion

		#region Data Members

			int _id;
			DateTime _date;
			string _description;
			int _userId;

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

		public DateTime  Date
		{
			 get { return _date; }
			 set
			 {
				 if (_date != value)
				 {
					_date = value;
					 PropertyHasChanged("Date");
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

		public int  UserId
		{
			 get { return _userId; }
			 set
			 {
				 if (_userId != value)
				 {
					_userId = value;
					 PropertyHasChanged("UserId");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Date", "Date"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Description", "Description"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UserId", "UserId"));
		}

		#endregion

	}
}
