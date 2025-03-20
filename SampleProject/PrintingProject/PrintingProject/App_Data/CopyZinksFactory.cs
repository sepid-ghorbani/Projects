using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class CopyZinksFactory
    {

        #region data Members

        CopyZinksSql _dataObject = null;

        #endregion

        #region Constructor

        public CopyZinksFactory()
        {
            _dataObject = new CopyZinksSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new CopyZinks
        /// </summary>
        /// <param name="businessObject">CopyZinks object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(CopyZinks businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing CopyZinks
        /// </summary>
        /// <param name="businessObject">CopyZinks object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(CopyZinks businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get CopyZinks by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public CopyZinks GetByPrimaryKey(CopyZinksKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all CopyZinkss
        /// </summary>
        /// <returns>list</returns>
        public List<CopyZinks> GetAll()
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
        /// get list of CopyZinks by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<CopyZinks> GetAllBy(CopyZinks.CopyZinksFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(CopyZinksKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete CopyZinks by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(CopyZinks.CopyZinksFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
