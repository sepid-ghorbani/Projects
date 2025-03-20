using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class LetterPressDevicesFactory
    {

        #region data Members

        LetterPressDevicesSql _dataObject = null;

        #endregion

        #region Constructor

        public LetterPressDevicesFactory()
        {
            _dataObject = new LetterPressDevicesSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new LetterPressDevices
        /// </summary>
        /// <param name="businessObject">LetterPressDevices object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(LetterPressDevices businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing LetterPressDevices
        /// </summary>
        /// <param name="businessObject">LetterPressDevices object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(LetterPressDevices businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get LetterPressDevices by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public LetterPressDevices GetByPrimaryKey(LetterPressDevicesKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all LetterPressDevicess
        /// </summary>
        /// <returns>list</returns>
        public List<LetterPressDevices> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of LetterPressDevices by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<LetterPressDevices> GetAllBy(LetterPressDevices.LetterPressDevicesFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(LetterPressDevicesKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete LetterPressDevices by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(LetterPressDevices.LetterPressDevicesFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
