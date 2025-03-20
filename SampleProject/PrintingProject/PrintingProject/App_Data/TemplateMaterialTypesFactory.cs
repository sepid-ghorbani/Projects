using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class TemplateMaterialTypesFactory
    {

        #region data Members

        TemplateMaterialTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public TemplateMaterialTypesFactory()
        {
            _dataObject = new TemplateMaterialTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new TemplateMaterialTypes
        /// </summary>
        /// <param name="businessObject">TemplateMaterialTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(TemplateMaterialTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing TemplateMaterialTypes
        /// </summary>
        /// <param name="businessObject">TemplateMaterialTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(TemplateMaterialTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get TemplateMaterialTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public TemplateMaterialTypes GetByPrimaryKey(TemplateMaterialTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all TemplateMaterialTypess
        /// </summary>
        /// <returns>list</returns>
        public List<TemplateMaterialTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of TemplateMaterialTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<TemplateMaterialTypes> GetAllBy(TemplateMaterialTypes.TemplateMaterialTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(TemplateMaterialTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete TemplateMaterialTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(TemplateMaterialTypes.TemplateMaterialTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
