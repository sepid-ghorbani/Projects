using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class ZinkTypesFactory
    {

        #region data Members

        ZinkTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public ZinkTypesFactory()
        {
            _dataObject = new ZinkTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new ZinkTypes
        /// </summary>
        /// <param name="businessObject">ZinkTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ZinkTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing ZinkTypes
        /// </summary>
        /// <param name="businessObject">ZinkTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ZinkTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get ZinkTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ZinkTypes GetByPrimaryKey(ZinkTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all ZinkTypess
        /// </summary>
        /// <returns>list</returns>
        public List<ZinkTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of ZinkTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ZinkTypes> GetAllBy(ZinkTypes.ZinkTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(ZinkTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete ZinkTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(ZinkTypes.ZinkTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
