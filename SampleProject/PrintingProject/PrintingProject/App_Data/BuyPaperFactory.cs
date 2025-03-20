using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class BuyPaperFactory
    {

        #region data Members

        BuyPaperSql _dataObject = null;

        #endregion

        #region Constructor

        public BuyPaperFactory()
        {
            _dataObject = new BuyPaperSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new BuyPaper
        /// </summary>
        /// <param name="businessObject">BuyPaper object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(BuyPaper businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing BuyPaper
        /// </summary>
        /// <param name="businessObject">BuyPaper object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(BuyPaper businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get BuyPaper by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public BuyPaper GetByPrimaryKey(BuyPaperKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all BuyPapers
        /// </summary>
        /// <returns>list</returns>
        public List<BuyPaper> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        public DataTable BuyAndPreparingPaperReport(int? orderReceiverId, int? sourceId, int? destinationId, int? materialTypeId
            , int? materialTypeGramazhId, int? paperWidthId, int? paperHeightId, DateTime? startDate,
            DateTime? endDate)
        {
            return _dataObject.BuyAndPreparingPaperReport(orderReceiverId,sourceId,destinationId,materialTypeId,
                materialTypeGramazhId,paperWidthId,paperHeightId,startDate,endDate);
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
        /// get list of BuyPaper by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<BuyPaper> GetAllBy(BuyPaper.BuyPaperFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(BuyPaperKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete BuyPaper by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(BuyPaper.BuyPaperFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
