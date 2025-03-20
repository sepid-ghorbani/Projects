using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class JobTypesFactory
    {

        #region data Members

        JobTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public JobTypesFactory()
        {
            _dataObject = new JobTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new JobTypes
        /// </summary>
        /// <param name="businessObject">JobTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(JobTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing JobTypes
        /// </summary>
        /// <param name="businessObject">JobTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(JobTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get JobTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public JobTypes GetByPrimaryKey(JobTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all JobTypess
        /// </summary>
        /// <returns>list</returns>
        public List<JobTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of JobTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<JobTypes> GetAllBy(JobTypes.JobTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(JobTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete JobTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(JobTypes.JobTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
