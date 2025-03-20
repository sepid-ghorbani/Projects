using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class LeafCountFactory
    {

        #region data Members

        LeafCountSql _dataObject = null;

        #endregion

        #region Constructor

        public LeafCountFactory()
        {
            _dataObject = new LeafCountSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new LeafCount
        /// </summary>
        /// <param name="businessObject">LeafCount object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(LeafCount businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing LeafCount
        /// </summary>
        /// <param name="businessObject">LeafCount object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(LeafCount businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get LeafCount by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public LeafCount GetByPrimaryKey(LeafCountKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all LeafCounts
        /// </summary>
        /// <returns>list</returns>
        public List<LeafCount> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of LeafCount by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<LeafCount> GetAllBy(LeafCount.LeafCountFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(LeafCountKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete LeafCount by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(LeafCount.LeafCountFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
