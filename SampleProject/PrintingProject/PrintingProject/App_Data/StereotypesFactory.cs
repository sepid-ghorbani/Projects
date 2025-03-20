using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class StereotypesFactory
    {

        #region data Members

        StereotypesSql _dataObject = null;

        #endregion

        #region Constructor

        public StereotypesFactory()
        {
            _dataObject = new StereotypesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Stereotypes
        /// </summary>
        /// <param name="businessObject">Stereotypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Stereotypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Stereotypes
        /// </summary>
        /// <param name="businessObject">Stereotypes object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Stereotypes businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Stereotypes by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Stereotypes GetByPrimaryKey(StereotypesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Stereotypess
        /// </summary>
        /// <returns>list</returns>
        public List<Stereotypes> GetAll()
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
        /// get list of Stereotypes by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Stereotypes> GetAllBy(Stereotypes.StereotypesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(StereotypesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Stereotypes by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Stereotypes.StereotypesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
