using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class LevelOrderReceiverFactory
    {

        #region data Members

        LevelOrderReceiverSql _dataObject = null;

        #endregion

        #region Constructor

        public LevelOrderReceiverFactory()
        {
            _dataObject = new LevelOrderReceiverSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new LevelOrderReceiver
        /// </summary>
        /// <param name="businessObject">LevelOrderReceiver object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(LevelOrderReceiver businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing LevelOrderReceiver
        /// </summary>
        /// <param name="businessObject">LevelOrderReceiver object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(LevelOrderReceiver businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get LevelOrderReceiver by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public LevelOrderReceiver GetByPrimaryKey(LevelOrderReceiverKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all LevelOrderReceivers
        /// </summary>
        /// <returns>list</returns>
        public List<LevelOrderReceiver> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of LevelOrderReceiver by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<LevelOrderReceiver> GetAllBy(LevelOrderReceiver.LevelOrderReceiverFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(LevelOrderReceiverKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete LevelOrderReceiver by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(LevelOrderReceiver.LevelOrderReceiverFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
