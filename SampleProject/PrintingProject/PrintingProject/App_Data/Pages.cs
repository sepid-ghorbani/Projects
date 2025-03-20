using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Pages: BusinessObjectBase
	{

		#region InnerClass
		public enum PagesFields
		{
			Id,
			Name,
			Path,
			Icon,
			GroupId
		}
		#endregion

		#region Data Members

			int _id;
			string _name;
			string _path;
			string _icon;
			byte _groupId;

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

		public string  Path
		{
			 get { return _path; }
			 set
			 {
				 if (_path != value)
				 {
					_path = value;
					 PropertyHasChanged("Path");
				 }
			 }
		}

		public string  Icon
		{
			 get { return _icon; }
			 set
			 {
				 if (_icon != value)
				 {
					_icon = value;
					 PropertyHasChanged("Icon");
				 }
			 }
		}

		public byte  GroupId
		{
			 get { return _groupId; }
			 set
			 {
				 if (_groupId != value)
				 {
					_groupId = value;
					 PropertyHasChanged("GroupId");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Path", "Path"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Path", "Path",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Icon", "Icon"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Icon", "Icon",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("GroupId", "GroupId"));
		}

		#endregion

	}
}
