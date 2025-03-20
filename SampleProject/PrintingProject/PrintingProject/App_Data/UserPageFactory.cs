using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class UserPageFactory
    {

        #region data Members

        UserPageSql _dataObject = null;

        #endregion

        #region Constructor

        public UserPageFactory()
        {
            _dataObject = new UserPageSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new UserPage
        /// </summary>
        /// <param name="businessObject">UserPage object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(UserPage businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing UserPage
        /// </summary>
        /// <param name="businessObject">UserPage object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(UserPage businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get UserPage by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public UserPage GetByPrimaryKey(UserPageKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all UserPages
        /// </summary>
        /// <returns>list</returns>
        public List<UserPage> GetAll()
        {
            return _dataObject.SelectAll(); 
        }
        public List<UserPage> GetByUserIdPageId(int userId, int pageId)
        {
            return _dataObject.SelectByUserIdPageId(userId,pageId);
        }
        public Boolean HasPermission(int userId, string path)
        {
            return _dataObject.HasPermission(userId,path);
        }
        /// <summary>
        /// get list of UserPage by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<UserPage> GetAllBy(UserPage.UserPageFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(UserPageKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete UserPage by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(UserPage.UserPageFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
