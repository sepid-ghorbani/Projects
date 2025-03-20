using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class LPIFactory
    {

        #region data Members

        LPISql _dataObject = null;

        #endregion

        #region Constructor

        public LPIFactory()
        {
            _dataObject = new LPISql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new LPI
        /// </summary>
        /// <param name="businessObject">LPI object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(LPI businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing LPI
        /// </summary>
        /// <param name="businessObject">LPI object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(LPI businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get LPI by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public LPI GetByPrimaryKey(LPIKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all LPIs
        /// </summary>
        /// <returns>list</returns>
        public List<LPI> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of LPI by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<LPI> GetAllBy(LPI.LPIFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(LPIKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete LPI by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(LPI.LPIFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
