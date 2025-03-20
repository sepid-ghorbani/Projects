using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class VeneersFactory
    {

        #region data Members

        VeneersSql _dataObject = null;

        #endregion

        #region Constructor

        public VeneersFactory()
        {
            _dataObject = new VeneersSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Veneers
        /// </summary>
        /// <param name="businessObject">Veneers object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Veneers businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Veneers
        /// </summary>
        /// <param name="businessObject">Veneers object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Veneers businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Veneers by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Veneers GetByPrimaryKey(VeneersKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Veneerss
        /// </summary>
        /// <returns>list</returns>
        public List<Veneers> GetAll()
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
        /// get list of Veneers by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Veneers> GetAllBy(Veneers.VeneersFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(VeneersKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Veneers by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Veneers.VeneersFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
