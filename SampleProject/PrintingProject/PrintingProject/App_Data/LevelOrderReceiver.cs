using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class LevelOrderReceiver: BusinessObjectBase
	{

		#region InnerClass
		public enum LevelOrderReceiverFields
		{
			Level_Id,
			OrderReceiver_Id
		}
		#endregion

		#region Data Members

			int _level_Id;
			int _orderReceiver_Id;

		#endregion

		#region Properties

		public int  Level_Id
		{
			 get { return _level_Id; }
			 set
			 {
				 if (_level_Id != value)
				 {
					_level_Id = value;
					 PropertyHasChanged("Level_Id");
				 }
			 }
		}

		public int  OrderReceiver_Id
		{
			 get { return _orderReceiver_Id; }
			 set
			 {
				 if (_orderReceiver_Id != value)
				 {
					_orderReceiver_Id = value;
					 PropertyHasChanged("OrderReceiver_Id");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Level_Id", "Level_Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OrderReceiver_Id", "OrderReceiver_Id"));
		}

		#endregion

	}
}
