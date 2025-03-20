using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class PaperWidthFactory
    {

        #region data Members

        PaperWidthSql _dataObject = null;

        #endregion

        #region Constructor

        public PaperWidthFactory()
        {
            _dataObject = new PaperWidthSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new PaperWidth
        /// </summary>
        /// <param name="businessObject">PaperWidth object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(PaperWidth businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing PaperWidth
        /// </summary>
        /// <param name="businessObject">PaperWidth object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(PaperWidth businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get PaperWidth by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PaperWidth GetByPrimaryKey(PaperWidthKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all PaperWidths
        /// </summary>
        /// <returns>list</returns>
        public List<PaperWidth> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of PaperWidth by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PaperWidth> GetAllBy(PaperWidth.PaperWidthFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PaperWidthKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete PaperWidth by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(PaperWidth.PaperWidthFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
