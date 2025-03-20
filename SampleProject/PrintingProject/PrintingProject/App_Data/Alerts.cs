using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Alerts: BusinessObjectBase
	{

		#region InnerClass
		public enum AlertsFields
		{
			Id,
			Text,
			Date,
			Viewed,
			UserId
		}
		#endregion

		#region Data Members

			int _id;
			string _text;
			DateTime _date;
			bool _viewed;
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

		public string  Text
		{
			 get { return _text; }
			 set
			 {
				 if (_text != value)
				 {
					_text = value;
					 PropertyHasChanged("Text");
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

		public bool  Viewed
		{
			 get { return _viewed; }
			 set
			 {
				 if (_viewed != value)
				 {
					_viewed = value;
					 PropertyHasChanged("Viewed");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Text", "Text"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Text", "Text",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Date", "Date"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Viewed", "Viewed"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UserId", "UserId"));
		}

		#endregion

	}
}
