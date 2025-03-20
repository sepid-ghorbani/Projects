using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class MainColorCountFactory
    {

        #region data Members

        MainColorCountSql _dataObject = null;

        #endregion

        #region Constructor

        public MainColorCountFactory()
        {
            _dataObject = new MainColorCountSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new MainColorCount
        /// </summary>
        /// <param name="businessObject">MainColorCount object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(MainColorCount businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing MainColorCount
        /// </summary>
        /// <param name="businessObject">MainColorCount object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(MainColorCount businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get MainColorCount by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public MainColorCount GetByPrimaryKey(MainColorCountKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all MainColorCounts
        /// </summary>
        /// <returns>list</returns>
        public List<MainColorCount> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of MainColorCount by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<MainColorCount> GetAllBy(MainColorCount.MainColorCountFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(MainColorCountKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete MainColorCount by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(MainColorCount.MainColorCountFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
