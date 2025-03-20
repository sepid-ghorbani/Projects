using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class PagesFactory
    {

        #region data Members

        PagesSql _dataObject = null;

        #endregion

        #region Constructor

        public PagesFactory()
        {
            _dataObject = new PagesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Pages
        /// </summary>
        /// <param name="businessObject">Pages object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Pages businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Pages
        /// </summary>
        /// <param name="businessObject">Pages object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Pages businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Pages by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Pages GetByPrimaryKey(PagesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Pagess
        /// </summary>
        /// <returns>list</returns>
        public List<Pages> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        public List<Pages> SelectByUserPermissions(int userId,int groupId)
        {
            return _dataObject.SelectByUserPermissions(userId,groupId);
        }
        /// <summary>
        /// get list of Pages by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Pages> GetAllBy(Pages.PagesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(PagesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Pages by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Pages.PagesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
