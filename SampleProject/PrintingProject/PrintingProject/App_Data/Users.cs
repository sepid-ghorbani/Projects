using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Users: BusinessObjectBase
	{

		#region InnerClass
		public enum UsersFields
		{
			Id,
			Name,
			UserName,
			Password,
			CreateDate,
			Enable,
			Email,
			Mobile
		}
		#endregion

		#region Data Members

			int _id;
			string _name;
			string _userName;
			string _password;
			DateTime _createDate;
			bool _enable;
			string _email;
			string _mobile;

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

		public string  UserName
		{
			 get { return _userName; }
			 set
			 {
				 if (_userName != value)
				 {
					_userName = value;
					 PropertyHasChanged("UserName");
				 }
			 }
		}

		public string  Password
		{
			 get { return _password; }
			 set
			 {
				 if (_password != value)
				 {
					_password = value;
					 PropertyHasChanged("Password");
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

		public bool  Enable
		{
			 get { return _enable; }
			 set
			 {
				 if (_enable != value)
				 {
					_enable = value;
					 PropertyHasChanged("Enable");
				 }
			 }
		}

		public string  Email
		{
			 get { return _email; }
			 set
			 {
				 if (_email != value)
				 {
					_email = value;
					 PropertyHasChanged("Email");
				 }
			 }
		}

		public string  Mobile
		{
			 get { return _mobile; }
			 set
			 {
				 if (_mobile != value)
				 {
					_mobile = value;
					 PropertyHasChanged("Mobile");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Name", "Name"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name", "Name",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UserName", "UserName"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UserName", "UserName",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Password", "Password"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Password", "Password",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CreateDate", "CreateDate"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Enable", "Enable"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Email", "Email"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Email", "Email",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Mobile", "Mobile"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Mobile", "Mobile",2147483647));
		}

		#endregion

	}
}
