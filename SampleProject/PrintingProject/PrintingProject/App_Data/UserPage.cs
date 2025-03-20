using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class UserPage: BusinessObjectBase
	{

		#region InnerClass
		public enum UserPageFields
		{
			User_Id,
			Page_Id
		}
		#endregion

		#region Data Members

			int _user_Id;
			int _page_Id;

		#endregion

		#region Properties

		public int  User_Id
		{
			 get { return _user_Id; }
			 set
			 {
				 if (_user_Id != value)
				 {
					_user_Id = value;
					 PropertyHasChanged("User_Id");
				 }
			 }
		}

		public int  Page_Id
		{
			 get { return _page_Id; }
			 set
			 {
				 if (_page_Id != value)
				 {
					_page_Id = value;
					 PropertyHasChanged("Page_Id");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("User_Id", "User_Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Page_Id", "Page_Id"));
		}

		#endregion

	}
}
