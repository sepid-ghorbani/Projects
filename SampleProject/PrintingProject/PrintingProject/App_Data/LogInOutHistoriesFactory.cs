using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class LogInOutHistoriesFactory
    {

        #region data Members

        LogInOutHistoriesSql _dataObject = null;

        #endregion

        #region Constructor

        public LogInOutHistoriesFactory()
        {
            _dataObject = new LogInOutHistoriesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new LogInOutHistories
        /// </summary>
        /// <param name="businessObject">LogInOutHistories object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(LogInOutHistories businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing LogInOutHistories
        /// </summary>
        /// <param name="businessObject">LogInOutHistories object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(LogInOutHistories businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get LogInOutHistories by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public LogInOutHistories GetByPrimaryKey(LogInOutHistoriesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all LogInOutHistoriess
        /// </summary>
        /// <returns>list</returns>
        public List<LogInOutHistories> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of LogInOutHistories by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<LogInOutHistories> GetAllBy(LogInOutHistories.LogInOutHistoriesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(LogInOutHistoriesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete LogInOutHistories by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(LogInOutHistories.LogInOutHistoriesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
