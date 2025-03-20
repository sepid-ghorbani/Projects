using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class SahafiesFactory
    {

        #region data Members

        SahafiesSql _dataObject = null;

        #endregion

        #region Constructor

        public SahafiesFactory()
        {
            _dataObject = new SahafiesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Sahafies
        /// </summary>
        /// <param name="businessObject">Sahafies object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Sahafies businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Sahafies
        /// </summary>
        /// <param name="businessObject">Sahafies object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Sahafies businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Sahafies by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Sahafies GetByPrimaryKey(SahafiesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Sahafiess
        /// </summary>
        /// <returns>list</returns>
        public List<Sahafies> GetAll()
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
        /// get list of Sahafies by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Sahafies> GetAllBy(Sahafies.SahafiesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(SahafiesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Sahafies by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Sahafies.SahafiesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
