using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
	public class ProductionOrder: BusinessObjectBase
	{

		#region InnerClass
		public enum ProductionOrderFields
		{
			Id,
			CartexId,
            OrderReceiverId,
            JobTypesId,
			OrderDate,
			OrderCount,
			Description
		}
		#endregion

		#region Data Members

			int _id;
			int _cartexId;
            int? _orderReceiverId;
            int? _jobTypesId;
			DateTime _orderDate;
			int _orderCount;
			string _description;

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

        public int? OrderReceiverId
        {
            get { return _orderReceiverId; }
            set
            {
                if (_orderReceiverId != value)
                {
                    _orderReceiverId = value;
                    PropertyHasChanged("OrderReceiverId");
                }
            }
        }

        public int? JobTypesId
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

		public DateTime  OrderDate
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

		public int  OrderCount
		{
			 get { return _orderCount; }
			 set
			 {
				 if (_orderCount != value)
				 {
					_orderCount = value;
					 PropertyHasChanged("OrderCount");
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


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CartexId", "CartexId"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OrderDate", "OrderDate"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("OrderCount", "OrderCount"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description",2147483647));
		}

		#endregion

	}
}
