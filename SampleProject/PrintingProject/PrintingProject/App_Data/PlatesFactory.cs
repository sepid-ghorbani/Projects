using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class PlatesFactory
    {

        #region data Members

        PlatesSql _dataObject = null;

        #endregion

        #region Constructor

        public PlatesFactory()
        {
            _dataObject = new PlatesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Plates
        /// </summary>
        /// <param name="businessObject">Plates object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Plates businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Plates
        /// </summary>
        /// <param name="businessObject">Plates object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Plates businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Plates by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Plates GetByPrimaryKey(PlatesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Platess
        /// </summary>
        /// <returns>list</returns>
        public List<Plates> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        public DataTable GetAllForGrid(int jobId)
        {
            return _dataObject.SelectAllForGrid(jobId);
        }

        public DataTable ReportById(int id)
        {
            return _dataObject.ReportById(id);
        }
        /// <summary>
        /// get list of Plates by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Plates> GetAllBy(Plates.PlatesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PlatesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Plates by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Plates.PlatesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
