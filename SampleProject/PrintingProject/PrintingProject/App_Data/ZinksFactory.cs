using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class ZinksFactory
    {

        #region data Members

        ZinksSql _dataObject = null;

        #endregion

        #region Constructor

        public ZinksFactory()
        {
            _dataObject = new ZinksSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Zinks
        /// </summary>
        /// <param name="businessObject">Zinks object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Zinks businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Zinks
        /// </summary>
        /// <param name="businessObject">Zinks object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Zinks businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Zinks by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Zinks GetByPrimaryKey(ZinksKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Zinkss
        /// </summary>
        /// <returns>list</returns>
        public List<Zinks> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Zinks by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Zinks> GetAllBy(Zinks.ZinksFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(ZinksKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Zinks by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Zinks.ZinksFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
