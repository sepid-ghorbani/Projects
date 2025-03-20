using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class JobTypes: BusinessObjectBase
	{

		#region InnerClass
		public enum JobTypesFields
		{
			Id,
			Name
		}
		#endregion

		#region Data Members

			int _id;
			string _name;

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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Name", "Name"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name", "Name",2147483647));
		}

		#endregion

	}
}
