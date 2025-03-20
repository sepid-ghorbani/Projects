using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class DeliveryReceiversFactory
    {

        #region data Members

        DeliveryReceiversSql _dataObject = null;

        #endregion

        #region Constructor

        public DeliveryReceiversFactory()
        {
            _dataObject = new DeliveryReceiversSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new DeliveryReceivers
        /// </summary>
        /// <param name="businessObject">DeliveryReceivers object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(DeliveryReceivers businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing DeliveryReceivers
        /// </summary>
        /// <param name="businessObject">DeliveryReceivers object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(DeliveryReceivers businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get DeliveryReceivers by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public DeliveryReceivers GetByPrimaryKey(DeliveryReceiversKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all DeliveryReceiverss
        /// </summary>
        /// <returns>list</returns>
        public List<DeliveryReceivers> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of DeliveryReceivers by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<DeliveryReceivers> GetAllBy(DeliveryReceivers.DeliveryReceiversFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(DeliveryReceiversKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete DeliveryReceivers by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(DeliveryReceivers.DeliveryReceiversFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
