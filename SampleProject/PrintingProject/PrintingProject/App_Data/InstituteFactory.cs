using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class InstituteFactory
    {

        #region data Members

        InstituteSql _dataObject = null;

        #endregion

        #region Constructor

        public InstituteFactory()
        {
            _dataObject = new InstituteSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Institute
        /// </summary>
        /// <param name="businessObject">Institute object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Institute businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Institute
        /// </summary>
        /// <param name="businessObject">Institute object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Institute businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Institute by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Institute GetByPrimaryKey(InstituteKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Institutes
        /// </summary>
        /// <returns>list</returns>
        public List<Institute> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        public List<Institute> GetAllSources()
        {
            return _dataObject.SelectAllSources();
        }
        /// <summary>
        /// get list of Institute by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Institute> GetAllBy(Institute.InstituteFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(InstituteKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Institute by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Institute.InstituteFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
