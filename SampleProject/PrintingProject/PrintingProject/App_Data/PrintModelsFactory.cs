using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class PrintModelsFactory
    {

        #region data Members

        PrintModelsSql _dataObject = null;

        #endregion

        #region Constructor

        public PrintModelsFactory()
        {
            _dataObject = new PrintModelsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new PrintModels
        /// </summary>
        /// <param name="businessObject">PrintModels object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(PrintModels businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing PrintModels
        /// </summary>
        /// <param name="businessObject">PrintModels object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(PrintModels businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get PrintModels by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PrintModels GetByPrimaryKey(PrintModelsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all PrintModelss
        /// </summary>
        /// <returns>list</returns>
        public List<PrintModels> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of PrintModels by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PrintModels> GetAllBy(PrintModels.PrintModelsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PrintModelsKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete PrintModels by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(PrintModels.PrintModelsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
