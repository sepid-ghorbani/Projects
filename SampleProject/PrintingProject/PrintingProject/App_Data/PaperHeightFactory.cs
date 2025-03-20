using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class PaperHeightFactory
    {

        #region data Members

        PaperHeightSql _dataObject = null;

        #endregion

        #region Constructor

        public PaperHeightFactory()
        {
            _dataObject = new PaperHeightSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new PaperHeight
        /// </summary>
        /// <param name="businessObject">PaperHeight object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(PaperHeight businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing PaperHeight
        /// </summary>
        /// <param name="businessObject">PaperHeight object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(PaperHeight businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get PaperHeight by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PaperHeight GetByPrimaryKey(PaperHeightKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all PaperHeights
        /// </summary>
        /// <returns>list</returns>
        public List<PaperHeight> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of PaperHeight by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PaperHeight> GetAllBy(PaperHeight.PaperHeightFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PaperHeightKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete PaperHeight by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(PaperHeight.PaperHeightFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
