using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class LevelsFactory
    {

        #region data Members

        LevelsSql _dataObject = null;

        #endregion

        #region Constructor

        public LevelsFactory()
        {
            _dataObject = new LevelsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Levels
        /// </summary>
        /// <param name="businessObject">Levels object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Levels businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Levels
        /// </summary>
        /// <param name="businessObject">Levels object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Levels businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Levels by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Levels GetByPrimaryKey(LevelsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Levelss
        /// </summary>
        /// <returns>list</returns>
        public List<Levels> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Levels by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Levels> GetAllBy(Levels.LevelsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(LevelsKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Levels by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Levels.LevelsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
