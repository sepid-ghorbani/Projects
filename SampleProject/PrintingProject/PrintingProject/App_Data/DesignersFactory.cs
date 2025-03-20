using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PrintingProject.BusinessLayer.DataLayer;

namespace PrintingProject.BusinessLayer
{
    public class DesignersFactory
    {

        #region data Members

        DesignersSql _dataObject = null;

        #endregion

        #region Constructor

        public DesignersFactory()
        {
            _dataObject = new DesignersSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Designers
        /// </summary>
        /// <param name="businessObject">Designers object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Designers businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Designers
        /// </summary>
        /// <param name="businessObject">Designers object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Designers businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Designers by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Designers GetByPrimaryKey(DesignersKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Designerss
        /// </summary>
        /// <returns>list</returns>
        public List<Designers> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Designers by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Designers> GetAllBy(Designers.DesignersFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(DesignersKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Designers by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Designers.DesignersFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
