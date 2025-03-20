using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class OrderReceiversFactory
    {

        #region data Members

        OrderReceiversSql _dataObject = null;

        #endregion

        #region Constructor

        public OrderReceiversFactory()
        {
            _dataObject = new OrderReceiversSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new OrderReceivers
        /// </summary>
        /// <param name="businessObject">OrderReceivers object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(OrderReceivers businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing OrderReceivers
        /// </summary>
        /// <param name="businessObject">OrderReceivers object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(OrderReceivers businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get OrderReceivers by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public OrderReceivers GetByPrimaryKey(OrderReceiversKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all OrderReceiverss
        /// </summary>
        /// <returns>list</returns>
        public List<OrderReceivers> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        public List<OrderReceivers> GetAllByLevel(int levelId)
        {
            return _dataObject.SelectAllByLevel(levelId);
        }
        public DataTable GetAllForGrid()
        {
            return _dataObject.SelectAllForGrid();
        }
        /// <summary>
        /// get list of OrderReceivers by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<OrderReceivers> GetAllBy(OrderReceivers.OrderReceiversFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(OrderReceiversKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete OrderReceivers by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(OrderReceivers.OrderReceiversFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
