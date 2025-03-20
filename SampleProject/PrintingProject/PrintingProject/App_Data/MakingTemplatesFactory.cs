using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class MakingTemplatesFactory
    {

        #region data Members

        MakingTemplatesSql _dataObject = null;

        #endregion

        #region Constructor

        public MakingTemplatesFactory()
        {
            _dataObject = new MakingTemplatesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new MakingTemplates
        /// </summary>
        /// <param name="businessObject">MakingTemplates object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(MakingTemplates businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing MakingTemplates
        /// </summary>
        /// <param name="businessObject">MakingTemplates object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(MakingTemplates businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get MakingTemplates by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public MakingTemplates GetByPrimaryKey(MakingTemplatesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all MakingTemplatess
        /// </summary>
        /// <returns>list</returns>
        public List<MakingTemplates> GetAll()
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
        /// get list of MakingTemplates by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<MakingTemplates> GetAllBy(MakingTemplates.MakingTemplatesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(MakingTemplatesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete MakingTemplates by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(MakingTemplates.MakingTemplatesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
