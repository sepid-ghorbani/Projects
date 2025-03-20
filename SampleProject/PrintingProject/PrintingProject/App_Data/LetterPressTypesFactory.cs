using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class LetterPressTypesFactory
    {

        #region data Members

        LetterPressTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public LetterPressTypesFactory()
        {
            _dataObject = new LetterPressTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new LetterPressTypes
        /// </summary>
        /// <param name="businessObject">LetterPressTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(LetterPressTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing LetterPressTypes
        /// </summary>
        /// <param name="businessObject">LetterPressTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(LetterPressTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get LetterPressTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public LetterPressTypes GetByPrimaryKey(LetterPressTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all LetterPressTypess
        /// </summary>
        /// <returns>list</returns>
        public List<LetterPressTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of LetterPressTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<LetterPressTypes> GetAllBy(LetterPressTypes.LetterPressTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(LetterPressTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete LetterPressTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(LetterPressTypes.LetterPressTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
