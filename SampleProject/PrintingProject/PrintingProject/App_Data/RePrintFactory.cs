using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class RePrintFactory
    {

        #region data Members

        RePrintSql _dataObject = null;

        #endregion

        #region Constructor

        public RePrintFactory()
        {
            _dataObject = new RePrintSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new RePrint
        /// </summary>
        /// <param name="businessObject">RePrint object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(RePrint businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing RePrint
        /// </summary>
        /// <param name="businessObject">RePrint object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(RePrint businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get RePrint by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public RePrint GetByPrimaryKey(RePrintKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all RePrints
        /// </summary>
        /// <returns>list</returns>
        public List<RePrint> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of RePrint by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<RePrint> GetAllBy(RePrint.RePrintFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(RePrintKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete RePrint by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(RePrint.RePrintFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
