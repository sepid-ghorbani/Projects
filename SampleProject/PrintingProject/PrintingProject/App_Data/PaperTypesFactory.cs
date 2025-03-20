using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class PaperTypesFactory
    {

        #region data Members

        PaperTypesSql _dataObject = null;

        #endregion

        #region Constructor

        public PaperTypesFactory()
        {
            _dataObject = new PaperTypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new PaperTypes
        /// </summary>
        /// <param name="businessObject">PaperTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(PaperTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing PaperTypes
        /// </summary>
        /// <param name="businessObject">PaperTypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(PaperTypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get PaperTypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PaperTypes GetByPrimaryKey(PaperTypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all PaperTypess
        /// </summary>
        /// <returns>list</returns>
        public List<PaperTypes> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of PaperTypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PaperTypes> GetAllBy(PaperTypes.PaperTypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PaperTypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete PaperTypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(PaperTypes.PaperTypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
