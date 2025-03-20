using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class ProductionOrderFactory
    {

        #region data Members

        ProductionOrderSql _dataObject = null;

        #endregion

        #region Constructor

        public ProductionOrderFactory()
        {
            _dataObject = new ProductionOrderSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new ProductionOrder
        /// </summary>
        /// <param name="businessObject">ProductionOrder object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ProductionOrder businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing ProductionOrder
        /// </summary>
        /// <param name="businessObject">ProductionOrder object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ProductionOrder businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get ProductionOrder by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ProductionOrder GetByPrimaryKey(ProductionOrderKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all ProductionOrders
        /// </summary>
        /// <returns>list</returns>
        public List<ProductionOrder> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        public bool HasPermissionToDelete(int cartexId)
        {
            return _dataObject.HasPermissionToDelete(cartexId);
        }
        public DataTable ReportById(int id)
        {
            return _dataObject.ReportById(id);
        }
        public DataTable GetAllForGrid(int cartexId)
        {
            return _dataObject.SelectAllForGrid(cartexId);
        }
        /// <summary>
        /// get list of ProductionOrder by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ProductionOrder> GetAllBy(ProductionOrder.ProductionOrderFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(ProductionOrderKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete ProductionOrder by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(ProductionOrder.ProductionOrderFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
