using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class MaterialTypesFactory
    {

        #region data Members

        MaterialTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public MaterialTypesFactory()
        {
            _dataObject = new MaterialTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new MaterialTypes
        /// </summary>
        /// <param name="businessObject">MaterialTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(MaterialTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing MaterialTypes
        /// </summary>
        /// <param name="businessObject">MaterialTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(MaterialTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get MaterialTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public MaterialTypes GetByPrimaryKey(MaterialTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all MaterialTypess
        /// </summary>
        /// <returns>list</returns>
        public List<MaterialTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of MaterialTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<MaterialTypes> GetAllBy(MaterialTypes.MaterialTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(MaterialTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete MaterialTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(MaterialTypes.MaterialTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
