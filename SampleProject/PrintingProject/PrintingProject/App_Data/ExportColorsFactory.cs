using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class ExportColorsFactory
    {

        #region data Members

        ExportColorsSql _dataObject = null;

        #endregion

        #region Constructor

        public ExportColorsFactory()
        {
            _dataObject = new ExportColorsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new ExportColors
        /// </summary>
        /// <param name="businessObject">ExportColors object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ExportColors businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing ExportColors
        /// </summary>
        /// <param name="businessObject">ExportColors object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ExportColors businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get ExportColors by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ExportColors GetByPrimaryKey(ExportColorsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all ExportColorss
        /// </summary>
        /// <returns>list</returns>
        public List<ExportColors> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of ExportColors by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<ExportColors> GetAllBy(ExportColors.ExportColorsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(ExportColorsKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete ExportColors by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(ExportColors.ExportColorsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
