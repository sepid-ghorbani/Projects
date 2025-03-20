using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.SqlServer.Management.Smo.Agent;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class PrintingsFactory
    {

        #region data Members

        PrintingsSql _dataObject = null;

        #endregion

        #region Constructor

        public PrintingsFactory()
        {
            _dataObject = new PrintingsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Printings
        /// </summary>
        /// <param name="businessObject">Printings object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Printings businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Printings
        /// </summary>
        /// <param name="businessObject">Printings object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Printings businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        public bool UpdateCartexStock(int id)
        {
            return _dataObject.UpdateCartexStock(id);
        }

        public bool UpdateCartexStockSub(int id)
        {
            return _dataObject.UpdateCartexStockSub(id);
        }
        /// <summary>
        /// get Printings by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Printings GetByPrimaryKey(PrintingsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys);
        }

        /// <summary>
        /// get list of all Printingss
        /// </summary>
        /// <returns>list</returns>
        public List<Printings> GetAll()
        {
            return _dataObject.SelectAll();
        }
        public DataTable ReportById(int id)
        {
            return _dataObject.ReportById(id);
        }
        public DataTable GetAllForGrid(int jobId)
        {
            return _dataObject.SelectAllForGrid(jobId);
        }
        /// <summary>
        /// get list of Printings by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Printings> GetAllBy(Printings.PrintingsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PrintingsKeys keys)
        {
            return _dataObject.Delete(keys);
        }

        public bool IsSend(int id)
        {
            return _dataObject.IsSend(id);
        }
        public bool HasCartex(int id)
        {
            return _dataObject.HasCartex(id);
        }
        /// <summary>
        /// delete Printings by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Printings.PrintingsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value);
        }

        #endregion

    }
}
