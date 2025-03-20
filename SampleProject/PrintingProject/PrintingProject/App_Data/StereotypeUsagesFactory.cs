using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class StereotypeUsagesFactory
    {

        #region data Members

        StereotypeUsagesSql _dataObject = null;

        #endregion

        #region Constructor

        public StereotypeUsagesFactory()
        {
            _dataObject = new StereotypeUsagesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new StereotypeUsages
        /// </summary>
        /// <param name="businessObject">StereotypeUsages object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(StereotypeUsages businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing StereotypeUsages
        /// </summary>
        /// <param name="businessObject">StereotypeUsages object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(StereotypeUsages businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get StereotypeUsages by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public StereotypeUsages GetByPrimaryKey(StereotypeUsagesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all StereotypeUsagess
        /// </summary>
        /// <returns>list</returns>
        public List<StereotypeUsages> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of StereotypeUsages by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<StereotypeUsages> GetAllBy(StereotypeUsages.StereotypeUsagesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(StereotypeUsagesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete StereotypeUsages by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(StereotypeUsages.StereotypeUsagesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
