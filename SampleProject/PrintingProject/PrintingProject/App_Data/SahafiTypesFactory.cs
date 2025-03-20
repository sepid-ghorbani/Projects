using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class SahafiTypesFactory
    {

        #region data Members

        SahafiTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public SahafiTypesFactory()
        {
            _dataObject = new SahafiTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new SahafiTypes
        /// </summary>
        /// <param name="businessObject">SahafiTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(SahafiTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing SahafiTypes
        /// </summary>
        /// <param name="businessObject">SahafiTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(SahafiTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get SahafiTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public SahafiTypes GetByPrimaryKey(SahafiTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all SahafiTypess
        /// </summary>
        /// <returns>list</returns>
        public List<SahafiTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of SahafiTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<SahafiTypes> GetAllBy(SahafiTypes.SahafiTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(SahafiTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete SahafiTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(SahafiTypes.SahafiTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
