using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class FinalInvoiceFactory
    {

        #region data Members

        FinalInvoiceSql _dataObject = null;

        #endregion

        #region Constructor

        public FinalInvoiceFactory()
        {
            _dataObject = new FinalInvoiceSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new FinalInvoice
        /// </summary>
        /// <param name="businessObject">FinalInvoice object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(FinalInvoice businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing FinalInvoice
        /// </summary>
        /// <param name="businessObject">FinalInvoice object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(FinalInvoice businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get FinalInvoice by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public FinalInvoice GetByPrimaryKey(FinalInvoiceKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all FinalInvoices
        /// </summary>
        /// <returns>list</returns>
        public List<FinalInvoice> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        public DataTable ReportById(int id)
        {
            return _dataObject.ReportById(id);
        }
        public DataTable GetInputCosts(int jobId)
        {
            return _dataObject.SelectInputCosts(jobId);
        }
        /// <summary>
        /// get list of FinalInvoice by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<FinalInvoice> GetAllBy(FinalInvoice.FinalInvoiceFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(FinalInvoiceKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete FinalInvoice by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(FinalInvoice.FinalInvoiceFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
