using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class BladeTypesFactory
    {

        #region data Members

        BladeTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public BladeTypesFactory()
        {
            _dataObject = new BladeTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new BladeTypes
        /// </summary>
        /// <param name="businessObject">BladeTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(BladeTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing BladeTypes
        /// </summary>
        /// <param name="businessObject">BladeTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(BladeTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get BladeTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public BladeTypes GetByPrimaryKey(BladeTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all BladeTypess
        /// </summary>
        /// <returns>list</returns>
        public List<BladeTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of BladeTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<BladeTypes> GetAllBy(BladeTypes.BladeTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(BladeTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete BladeTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(BladeTypes.BladeTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
