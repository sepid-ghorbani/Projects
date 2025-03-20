using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class FilmsFactory
    {

        #region data Members

        FilmsSql _dataObject = null;

        #endregion

        #region Constructor

        public FilmsFactory()
        {
            _dataObject = new FilmsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Films
        /// </summary>
        /// <param name="businessObject">Films object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Films businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Films
        /// </summary>
        /// <param name="businessObject">Films object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Films businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Films by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Films GetByPrimaryKey(FilmsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Filmss
        /// </summary>
        /// <returns>list</returns>
        public List<Films> GetAll()
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
        /// get list of Films by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Films> GetAllBy(Films.FilmsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(FilmsKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Films by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Films.FilmsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
