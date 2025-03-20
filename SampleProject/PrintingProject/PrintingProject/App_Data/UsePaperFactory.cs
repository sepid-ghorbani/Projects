using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class UsePaperFactory
    {

        #region data Members

        UsePaperSql _dataObject = null;

        #endregion

        #region Constructor

        public UsePaperFactory()
        {
            _dataObject = new UsePaperSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new UsePaper
        /// </summary>
        /// <param name="businessObject">UsePaper object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(UsePaper businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing UsePaper
        /// </summary>
        /// <param name="businessObject">UsePaper object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(UsePaper businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get UsePaper by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public UsePaper GetByPrimaryKey(UsePaperKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys);
        }

        /// <summary>
        /// get list of all UsePapers
        /// </summary>
        /// <returns>list</returns>
        public List<UsePaper> GetAll()
        {
            return _dataObject.SelectAll();
        }
        public DataTable UsePaperGeneralReport(int? customerId, int? sourceId, int? materialTypeId
           , int? materialTypeGramazhId, int? paperWidthId, int? paperHeightId, DateTime? startDate,
           DateTime? endDate, int? useStatus)
        {
            return _dataObject.UsePaperGeneralReport(customerId, sourceId, materialTypeId,
                materialTypeGramazhId, paperWidthId, paperHeightId, startDate, endDate, useStatus);
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
        /// get list of UsePaper by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<UsePaper> GetAllBy(UsePaper.UsePaperFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(UsePaperKeys keys)
        {
            return _dataObject.Delete(keys);
        }

        /// <summary>
        /// delete UsePaper by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(UsePaper.UsePaperFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value);
        }

        #endregion

    }
}
