using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class JobNamesFactory
    {

        #region data Members

        JobNamesSql _dataObject = null;

        #endregion

        #region Constructor

        public JobNamesFactory()
        {
            _dataObject = new JobNamesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new JobNames
        /// </summary>
        /// <param name="businessObject">JobNames object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(JobNames businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing JobNames
        /// </summary>
        /// <param name="businessObject">JobNames object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(JobNames businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get JobNames by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public JobNames GetByPrimaryKey(JobNamesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all JobNamess
        /// </summary>
        /// <returns>list</returns>
        public List<JobNames> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        public DataTable GetAllForGrid()
        {
            return _dataObject.SelectAllForGrid();
        }
        /// <summary>
        /// get list of JobNames by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<JobNames> GetAllBy(JobNames.JobNamesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(JobNamesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete JobNames by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(JobNames.JobNamesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
