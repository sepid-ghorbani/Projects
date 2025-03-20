using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class DimensionsFactory
    {

        #region data Members

        DimensionsSql _dataObject = null;

        #endregion

        #region Constructor

        public DimensionsFactory()
        {
            _dataObject = new DimensionsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Dimensions
        /// </summary>
        /// <param name="businessObject">Dimensions object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Dimensions businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Dimensions
        /// </summary>
        /// <param name="businessObject">Dimensions object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Dimensions businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Dimensions by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Dimensions GetByPrimaryKey(DimensionsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Dimensionss
        /// </summary>
        /// <returns>list</returns>
        public List<Dimensions> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Dimensions by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Dimensions> GetAllBy(Dimensions.DimensionsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(DimensionsKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Dimensions by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Dimensions.DimensionsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
