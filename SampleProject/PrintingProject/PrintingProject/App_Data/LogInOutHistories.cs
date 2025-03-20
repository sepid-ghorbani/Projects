using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class LogInOutHistories: BusinessObjectBase
	{

		#region InnerClass
		public enum LogInOutHistoriesFields
		{
			Id,
			Date,
			Type,
			UserId
		}
		#endregion

		#region Data Members

			int _id;
			DateTime _date;
			bool _type;
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

		public bool  Type
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Type", "Type"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UserId", "UserId"));
		}

		#endregion

	}
}
