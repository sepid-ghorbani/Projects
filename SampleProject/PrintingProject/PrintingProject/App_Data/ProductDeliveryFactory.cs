using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class ProductDeliveryFactory
    {

        #region data Members

        ProductDeliverySql _dataObject = null;

        #endregion

        #region Constructor

        public ProductDeliveryFactory()
        {
            _dataObject = new ProductDeliverySql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new ProductDelivery
        /// </summary>
        /// <param name="businessObject">ProductDelivery object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ProductDelivery businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing ProductDelivery
        /// </summary>
        /// <param name="businessObject">ProductDelivery object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ProductDelivery businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get ProductDelivery by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ProductDelivery GetByPrimaryKey(ProductDeliveryKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all ProductDeliverys
        /// </summary>
        /// <returns>list</returns>
        public List<ProductDelivery> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        public bool HasPermissionToInsert(int cartexId)
        {
            return _dataObject.HasPermissionToInsert(cartexId);
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
        /// get list of ProductDelivery by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ProductDelivery> GetAllBy(ProductDelivery.ProductDeliveryFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(ProductDeliveryKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete ProductDelivery by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(ProductDelivery.ProductDeliveryFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
