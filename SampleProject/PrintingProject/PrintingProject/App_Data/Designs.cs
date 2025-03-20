using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class Designs: BusinessObjectBase
	{

		#region InnerClass
		public enum DesignsFields
		{
			Id,
			CustomerId,
			DesignerId,
			OrderDate,
			DeliverDate,
			OrderType,
			CustomerAgent,
			Phone
		}
		#endregion

		#region Data Members

			int _id;
			int _customerId;
			int _designerId;
			DateTime? _orderDate;
			DateTime? _deliverDate;
			string _orderType;
			string _customerAgent;
			string _phone;

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

		public int  DesignerId
		{
			 get { return _designerId; }
			 set
			 {
				 if (_designerId != value)
				 {
					_designerId = value;
					 PropertyHasChanged("DesignerId");
				 }
			 }
		}

		public DateTime?  OrderDate
		{
			 get { return _orderDate; }
			 set
			 {
				 if (_orderDate != value)
				 {
					_orderDate = value;
					 PropertyHasChanged("OrderDate");
				 }
			 }
		}

		public DateTime?  DeliverDate
		{
			 get { return _deliverDate; }
			 set
			 {
				 if (_deliverDate != value)
				 {
					_deliverDate = value;
					 PropertyHasChanged("DeliverDate");
				 }
			 }
		}

		public string  OrderType
		{
			 get { return _orderType; }
			 set
			 {
				 if (_orderType != value)
				 {
					_orderType = value;
					 PropertyHasChanged("OrderType");
				 }
			 }
		}

		public string  CustomerAgent
		{
			 get { return _customerAgent; }
			 set
			 {
				 if (_customerAgent != value)
				 {
					_customerAgent = value;
					 PropertyHasChanged("CustomerAgent");
				 }
			 }
		}

		public string  Phone
		{
			 get { return _phone; }
			 set
			 {
				 if (_phone != value)
				 {
					_phone = value;
					 PropertyHasChanged("Phone");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CustomerId", "CustomerId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("DesignerId", "DesignerId"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("OrderType", "OrderType",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CustomerAgent", "CustomerAgent",2147483647));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Phone", "Phone",50));
		}

		#endregion

	}
}
