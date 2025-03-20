using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.SqlServer.Management.Smo.Agent;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class JobsFactory
    {

        #region data Members

        JobsSql _dataObject = null;

        #endregion

        #region Constructor

        public JobsFactory()
        {
            _dataObject = new JobsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Jobs
        /// </summary>
        /// <param name="businessObject">Jobs object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Jobs businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }
        public bool Copy(int jobId)
        {
            return _dataObject.Copy(jobId);

        }
        /// <summary>
        /// Update existing Jobs
        /// </summary>
        /// <param name="businessObject">Jobs object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Jobs businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Jobs by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Jobs GetByPrimaryKey(JobsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys);
        }

        /// <summary>
        /// get list of all Jobss
        /// </summary>
        /// <returns>list</returns>
        public List<Jobs> GetAll(int customerId)
        {
            return _dataObject.SelectAll(customerId);
        }
        public List<Jobs> GetAllInserted(int? customerId)
        {
            return _dataObject.SelectAllInserted(customerId);
        }
        public DataTable GetAllForGrid(int? id, string name, string code, int startIndex, int pageSize)
        {
            return _dataObject.SelectAllForGrid(id, name, code, startIndex, pageSize);
        }

        public DataTable ReportBaseOnCustomer(string invoiceStatus, int? customerId, string jobName, int? jobNum, DateTime? startDate, DateTime? endDate)
        {
            return _dataObject.ReportBaseOnCustomer(invoiceStatus, customerId, jobName, jobNum, startDate, endDate);
        }

        public DataTable ReportBaseOnOrderReceiver(string levelName, int? orderReceiverId, string invoiceStatus, int? invoiceNum, int? customerId,
            string jobName, int? jobNum, DateTime? startDate, DateTime? endDate)
        {
            return _dataObject.ReportBaseOnOrderReceiver(levelName, orderReceiverId, invoiceStatus, invoiceNum, customerId,
                                                         jobName, jobNum, startDate, endDate);
        }

        public int GetTotalCount(int? id, string name, string code)
        {
            return _dataObject.GetTotalCount(id, name, code);
        }
        /// <summary>
        /// get list of Jobs by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Jobs> GetAllBy(Jobs.JobsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(JobsKeys keys)
        {
            return _dataObject.Delete(keys);
        }

        /// <summary>
        /// delete Jobs by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Jobs.JobsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value);
        }

        #endregion

    }
}
