using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
    public class JobNames : BusinessObjectBase
    {

        #region InnerClass
        public enum JobNamesFields
        {
            Id,
            Code,
            Name,
            StoreCode,
            CustomerId,
            Fee1,
            Fee2
        }
        #endregion

        #region Data Members

        int _id;
        string _code;
        string _name;
        int? _storeCode;
        int? _customerId;
        decimal? _fee1;
        decimal? _fee2;

        #endregion

        #region Properties

        public int Id
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

        public string Code
        {
            get { return _code; }
            set
            {
                if (_code != value)
                {
                    _code = value;
                    PropertyHasChanged("Code");
                }
            }
        }

        public string Name
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

        public int? StoreCode
        {
            get { return _storeCode; }
            set
            {
                if (_storeCode != value)
                {
                    _storeCode = value;
                    PropertyHasChanged("StoreCode");
                }
            }
        }

        public int? CustomerId
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

        public decimal? Fee1
        {
            get { return _fee1; }
            set
            {
                if (_fee1 != value)
                {
                    _fee1 = value;
                    PropertyHasChanged("Fee1");
                }
            }
        }

        public decimal? Fee2
        {
            get { return _fee2; }
            set
            {
                if (_fee2 != value)
                {
                    _fee2 = value;
                    PropertyHasChanged("Fee2");
                }
            }
        }


        #endregion

        #region Validation

        internal override void AddValidationRules()
        {
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Id", "Id"));
            ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Code", "Code", 2147483647));
            ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name", "Name", 2147483647));
        }

        #endregion

    }
}
