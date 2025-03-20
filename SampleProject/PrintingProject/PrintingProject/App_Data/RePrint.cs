using System;
using System.Collections.Generic;
using System.Text;
namespace PrintingProject.BusinessLayer
{
    public class RePrint : BusinessObjectBase
    {

        #region InnerClass
        public enum RePrintFields
        {
            Id,
            JobId,
            CreateDate,
            Description
        }
        #endregion

        #region Data Members

        int _id;
        int _jobId;
        DateTime _createDate;
        string _description;

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

        public int JobId
        {
            get { return _jobId; }
            set
            {
                if (_jobId != value)
                {
                    _jobId = value;
                    PropertyHasChanged("JobId");
                }
            }
        }

        public DateTime CreateDate
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
        public string CreateDatePersian
        {
            get
            {
                PersianDateCal p = new PersianDateCal();
                return p.ConvertToPersianDate(CreateDate, "Y/m/d");
            }


        }
        public string Description
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
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("JobId", "JobId"));
            ValidationRules.AddRules(new Validation.ValidateRuleNotNull("CreateDate", "CreateDate"));
            ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Description", "Description", 2147483647));
        }

        #endregion

    }
}
