using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class AlertsFactory
    {

        #region data Members

        AlertsSql _dataObject = null;

        #endregion

        #region Constructor

        public AlertsFactory()
        {
            _dataObject = new AlertsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Alerts
        /// </summary>
        /// <param name="businessObject">Alerts object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Alerts businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Alerts
        /// </summary>
        /// <param name="businessObject">Alerts object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Alerts businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Alerts by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Alerts GetByPrimaryKey(AlertsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Alertss
        /// </summary>
        /// <returns>list</returns>
        public List<Alerts> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Alerts by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Alerts> GetAllBy(Alerts.AlertsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(AlertsKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Alerts by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Alerts.AlertsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
