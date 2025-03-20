using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class VeneerTypesFactory
    {

        #region data Members

        VeneerTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public VeneerTypesFactory()
        {
            _dataObject = new VeneerTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new VeneerTypes
        /// </summary>
        /// <param name="businessObject">VeneerTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(VeneerTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing VeneerTypes
        /// </summary>
        /// <param name="businessObject">VeneerTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(VeneerTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get VeneerTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public VeneerTypes GetByPrimaryKey(VeneerTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all VeneerTypess
        /// </summary>
        /// <returns>list</returns>
        public List<VeneerTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of VeneerTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<VeneerTypes> GetAllBy(VeneerTypes.VeneerTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(VeneerTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete VeneerTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(VeneerTypes.VeneerTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
