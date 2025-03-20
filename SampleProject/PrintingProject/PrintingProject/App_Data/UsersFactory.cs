using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class UsersFactory
    {

        #region data Members

        UsersSql _dataObject = null;

        #endregion

        #region Constructor

        public UsersFactory()
        {
            _dataObject = new UsersSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Users
        /// </summary>
        /// <param name="businessObject">Users object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Users businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Users
        /// </summary>
        /// <param name="businessObject">Users object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Users businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Users by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Users GetByPrimaryKey(UsersKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Userss
        /// </summary>
        /// <returns>list</returns>
        public List<Users> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Users by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Users> GetAllBy(Users.UsersFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(UsersKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Users by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Users.UsersFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
