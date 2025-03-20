using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class PrimaryStockFactory
    {

        #region data Members

        PrimaryStockSql _dataObject = null;

        #endregion

        #region Constructor

        public PrimaryStockFactory()
        {
            _dataObject = new PrimaryStockSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new PrimaryStock
        /// </summary>
        /// <param name="businessObject">PrimaryStock object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(PrimaryStock businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing PrimaryStock
        /// </summary>
        /// <param name="businessObject">PrimaryStock object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(PrimaryStock businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get PrimaryStock by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PrimaryStock GetByPrimaryKey(PrimaryStockKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all PrimaryStocks
        /// </summary>
        /// <returns>list</returns>
        public List<PrimaryStock> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        public DataTable GetAllForGrid(int cartexId)
        {
            return _dataObject.SelectAllForGrid(cartexId);
        }
        public DataTable ReportById(int id)
        {
            return _dataObject.ReportById(id);
        }
        /// <summary>
        /// get list of PrimaryStock by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PrimaryStock> GetAllBy(PrimaryStock.PrimaryStockFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PrimaryStockKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete PrimaryStock by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(PrimaryStock.PrimaryStockFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
