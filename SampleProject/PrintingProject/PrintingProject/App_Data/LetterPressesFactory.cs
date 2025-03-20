using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class LetterPressesFactory
    {

        #region data Members

        LetterPressesSql _dataObject = null;

        #endregion

        #region Constructor

        public LetterPressesFactory()
        {
            _dataObject = new LetterPressesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new LetterPresses
        /// </summary>
        /// <param name="businessObject">LetterPresses object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(LetterPresses businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing LetterPresses
        /// </summary>
        /// <param name="businessObject">LetterPresses object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(LetterPresses businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get LetterPresses by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public LetterPresses GetByPrimaryKey(LetterPressesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all LetterPressess
        /// </summary>
        /// <returns>list</returns>
        public List<LetterPresses> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        public DataTable ReportById(int id)
        {
            return _dataObject.ReportById(id);
        }
        public DataTable GetAllForGrid(int jobId)
        {
            return _dataObject.SelectAllForGrid(jobId);
        }
        /// <summary>
        /// get list of LetterPresses by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<LetterPresses> GetAllBy(LetterPresses.LetterPressesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(LetterPressesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete LetterPresses by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(LetterPresses.LetterPressesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
