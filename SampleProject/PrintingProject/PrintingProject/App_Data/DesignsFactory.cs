using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class DesignsFactory
    {

        #region data Members

        DesignsSql _dataObject = null;

        #endregion

        #region Constructor

        public DesignsFactory()
        {
            _dataObject = new DesignsSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Designs
        /// </summary>
        /// <param name="businessObject">Designs object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Designs businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Designs
        /// </summary>
        /// <param name="businessObject">Designs object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Designs businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Designs by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Designs GetByPrimaryKey(DesignsKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Designss
        /// </summary>
        /// <returns>list</returns>
        public List<Designs> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Designs by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Designs> GetAllBy(Designs.DesignsFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(DesignsKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Designs by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Designs.DesignsFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
