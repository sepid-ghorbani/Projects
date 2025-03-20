using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class OperationHistoriesFactory
    {

        #region data Members

        OperationHistoriesSql _dataObject = null;

        #endregion

        #region Constructor

        public OperationHistoriesFactory()
        {
            _dataObject = new OperationHistoriesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new OperationHistories
        /// </summary>
        /// <param name="businessObject">OperationHistories object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(OperationHistories businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing OperationHistories
        /// </summary>
        /// <param name="businessObject">OperationHistories object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(OperationHistories businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get OperationHistories by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public OperationHistories GetByPrimaryKey(OperationHistoriesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all OperationHistoriess
        /// </summary>
        /// <returns>list</returns>
        public List<OperationHistories> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        public DataTable Search(int? userId, DateTime? startDate, DateTime? endDate, string search)
        {
            return _dataObject.Search(userId,startDate,endDate,search);
        }
        /// <summary>
        /// get list of OperationHistories by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<OperationHistories> GetAllBy(OperationHistories.OperationHistoriesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(OperationHistoriesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete OperationHistories by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(OperationHistories.OperationHistoriesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
