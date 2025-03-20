using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class StockFactory
    {

        #region data Members

        StockSql _dataObject = null;

        #endregion

        #region Constructor

        public StockFactory()
        {
            _dataObject = new StockSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Stock
        /// </summary>
        /// <param name="businessObject">Stock object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Stock businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Stock
        /// </summary>
        /// <param name="businessObject">Stock object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Stock businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Stock by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Stock GetByPrimaryKey(StockKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys);
        }

        /// <summary>
        /// get list of all Stocks
        /// </summary>
        /// <returns>list</returns>
        public List<Stock> GetAll()
        {
            return _dataObject.SelectAll();
        }
        public DataTable GetStockOfInstitute(int instituteId, int materialTypeId, int materialTypeGramazhId, int paperWidthId, int paperHeightId)
        {
            return _dataObject.GetStockOfInstitute(instituteId, materialTypeId, materialTypeGramazhId, paperWidthId,
                                                   paperHeightId);
        }

        public List<Stock> GetAllByInstitute(int instituteId, int materialTypeId, int materialTypeGramazhId, int paperWidthId, int paperHeightId)
        {
            return _dataObject.SelectAllByInstitute(instituteId, materialTypeId, materialTypeGramazhId, paperWidthId, paperHeightId);
        }
        public DataTable ReportByInstitute(int? instituteId)
        {
            return _dataObject.ReportByInstitute(instituteId);
        }
        /// <summary>
        /// get list of Stock by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Stock> GetAllBy(Stock.StockFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(StockKeys keys)
        {
            return _dataObject.Delete(keys);
        }

        /// <summary>
        /// delete Stock by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Stock.StockFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value);
        }

        #endregion

    }
}
