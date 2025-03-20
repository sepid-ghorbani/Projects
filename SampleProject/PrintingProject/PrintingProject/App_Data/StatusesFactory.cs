using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class StatusesFactory
    {

        #region data Members

        StatusesSql _dataObject = null;

        #endregion

        #region Constructor

        public StatusesFactory()
        {
            _dataObject = new StatusesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Statuses
        /// </summary>
        /// <param name="businessObject">Statuses object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Statuses businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Statuses
        /// </summary>
        /// <param name="businessObject">Statuses object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Statuses businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Statuses by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Statuses GetByPrimaryKey(StatusesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Statusess
        /// </summary>
        /// <returns>list</returns>
        public List<Statuses> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Statuses by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Statuses> GetAllBy(Statuses.StatusesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(StatusesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Statuses by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Statuses.StatusesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
