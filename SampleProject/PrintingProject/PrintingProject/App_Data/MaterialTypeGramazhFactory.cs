using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class MaterialTypeGramazhFactory
    {

        #region data Members

        MaterialTypeGramazhSql _dataObject = null;

        #endregion

        #region Constructor

        public MaterialTypeGramazhFactory()
        {
            _dataObject = new MaterialTypeGramazhSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new MaterialTypeGramazh
        /// </summary>
        /// <param name="businessObject">MaterialTypeGramazh object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(MaterialTypeGramazh businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing MaterialTypeGramazh
        /// </summary>
        /// <param name="businessObject">MaterialTypeGramazh object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(MaterialTypeGramazh businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get MaterialTypeGramazh by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public MaterialTypeGramazh GetByPrimaryKey(MaterialTypeGramazhKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all MaterialTypeGramazhs
        /// </summary>
        /// <returns>list</returns>
        public List<MaterialTypeGramazh> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of MaterialTypeGramazh by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<MaterialTypeGramazh> GetAllBy(MaterialTypeGramazh.MaterialTypeGramazhFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(MaterialTypeGramazhKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete MaterialTypeGramazh by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(MaterialTypeGramazh.MaterialTypeGramazhFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
