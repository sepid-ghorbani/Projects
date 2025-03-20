using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class CartexesFactory
    {

        #region data Members

        CartexesSql _dataObject = null;

        #endregion

        #region Constructor

        public CartexesFactory()
        {
            _dataObject = new CartexesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Cartexes
        /// </summary>
        /// <param name="businessObject">Cartexes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Cartexes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Cartexes
        /// </summary>
        /// <param name="businessObject">Cartexes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Cartexes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        public bool UpdateCartexStock(int cartexId)
        {

            return _dataObject.UpdateCartexStock(cartexId);
        }
        /// <summary>
        /// get Cartexes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Cartexes GetByPrimaryKey(CartexesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys);
        }

        /// <summary>
        /// get list of all Cartexess
        /// </summary>
        /// <returns>list</returns>
        public List<Cartexes> GetAll()
        {
            return _dataObject.SelectAll();
        }
        public List<Cartexes> GetAllJobNames()
        {
            return _dataObject.SelectAllJobNames();
        }
        public List<Cartexes> GetAllJobCodes()
        {
            return _dataObject.SelectAllJobCodes();
        }
       
        public DataTable ReportBaseOnCustomer(int? customerId, string jobName, string jobCode, int? inputInvoiceStatus,
            int? outputInvoiceStatus, int? deliveryStatus, string outputInvoiceNum, DateTime? startDate, DateTime? endDate)
        {
            return _dataObject.ReportBaseOnCustomer(customerId, jobName, jobCode, inputInvoiceStatus, outputInvoiceStatus
                , deliveryStatus, outputInvoiceNum, startDate, endDate);
        }
        public DataTable ReportBaseOnOrderReceiver(int? jobTypeId, string levelName, int? orderReceiverId, string receiptNum,
            int? inputInvoiceStatus, string inputInvoiceNum, int? customerId, string jobName, string jobCode,
            int? deliveryStatus, DateTime? startDate, DateTime? endDate)
        {
            return _dataObject.ReportBaseOnOrderReceiver(jobTypeId, levelName, orderReceiverId,receiptNum,
             inputInvoiceStatus, inputInvoiceNum, customerId, jobName, jobCode,
             deliveryStatus, startDate, endDate);
        }
        public DataTable ReportProductStock(int? orderReceiverId, string jobName, string jobCode, int? jobTypeId)
        {
            return _dataObject.ReportProductStock(orderReceiverId, jobName, jobCode, jobTypeId);

        }
        public int GetTotalCount(string jobName, string jobCode)
        {
            return _dataObject.GetTotalCount(jobName, jobCode);
        }
        public DataTable GetAllForGrid(string jobName, string jobCode, int startIndex, int pageSize)
        {
            return _dataObject.SelectAllForGrid(jobName, jobCode, startIndex, pageSize);
        }
        /// <summary>
        /// get list of Cartexes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Cartexes> GetAllBy(Cartexes.CartexesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CartexesKeys keys)
        {
            return _dataObject.Delete(keys);
        }
        public bool OperationBeforeDelete(int cartexId)
        {
            return _dataObject.OperationBeforeDelete(cartexId);
        }

        /// <summary>
        /// delete Cartexes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Cartexes.CartexesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value);
        }

        #endregion

    }
}
