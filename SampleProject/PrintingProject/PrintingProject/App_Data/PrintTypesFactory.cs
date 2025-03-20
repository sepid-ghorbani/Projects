using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class PrintTypesFactory
    {

        #region data Members

        PrintTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public PrintTypesFactory()
        {
            _dataObject = new PrintTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new PrintTypes
        /// </summary>
        /// <param name="businessObject">PrintTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(PrintTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing PrintTypes
        /// </summary>
        /// <param name="businessObject">PrintTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(PrintTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get PrintTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PrintTypes GetByPrimaryKey(PrintTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all PrintTypess
        /// </summary>
        /// <returns>list</returns>
        public List<PrintTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of PrintTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PrintTypes> GetAllBy(PrintTypes.PrintTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PrintTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete PrintTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(PrintTypes.PrintTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
