using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PrintingProject.BusinessLayer.DataLayer
{
    /// <summary>
    /// Data access layer class for MakingTemplates
    /// </summary>
    class MakingTemplatesSql : DataLayerBase
    {

        #region Constructor

        /// <summary>
        /// Class constructor
        /// </summary>
        public MakingTemplatesSql()
        {
            // Nothing for now.
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// insert new row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true of successfully insert</returns>
        public bool Insert(MakingTemplates businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MakingTemplates_Insert]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@LetterPressDeviceId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LetterPressDeviceId));
                sqlCommand.Parameters.Add(new SqlParameter("@TemplateMaterialTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TemplateMaterialTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@Dimension", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Dimension));
                sqlCommand.Parameters.Add(new SqlParameter("@Count", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Count));
                sqlCommand.Parameters.Add(new SqlParameter("@BladeTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BladeTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@PorferazhModel", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PorferazhModel));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceCost));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                businessObject.Id = (int)sqlCommand.Parameters["@Id"].Value;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("MakingTemplates::Insert::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(MakingTemplates businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MakingTemplates_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@LetterPressDeviceId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LetterPressDeviceId));
                sqlCommand.Parameters.Add(new SqlParameter("@TemplateMaterialTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TemplateMaterialTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@Dimension", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Dimension));
                sqlCommand.Parameters.Add(new SqlParameter("@Count", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Count));
                sqlCommand.Parameters.Add(new SqlParameter("@BladeTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BladeTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@PorferazhModel", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PorferazhModel));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceCost));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("MakingTemplates::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>MakingTemplates business object</returns>
        public MakingTemplates SelectByPrimaryKey(MakingTemplatesKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MakingTemplates_SelectByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.Id));


                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    MakingTemplates businessObject = new MakingTemplates();

                    PopulateBusinessObjectFromReader(businessObject, dataReader);

                    return businessObject;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("MakingTemplates::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of MakingTemplates</returns>
        public List<MakingTemplates> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MakingTemplates_SelectAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("MakingTemplates::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable SelectAllForGrid(int jobId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MakingTemplates_SelectAll_ForGrid]";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("JobId", jobId);
            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("MakingTemplates::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable ReportById(int id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MakingTemplates_ReportById]";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("Id", id);
            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dataReader);
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Plates::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
        /// <summary>
        /// Select records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>list of MakingTemplates</returns>
        public List<MakingTemplates> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MakingTemplates_SelectByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("MakingTemplates::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(MakingTemplatesKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MakingTemplates_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys.Id));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("MakingTemplates::DeleteByKey::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>true for successfully deleted</returns>
        public bool DeleteByField(string fieldName, object value)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[MakingTemplates_DeleteByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));

                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("MakingTemplates::DeleteByField::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populate business object from data reader
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <param name="dataReader">data reader</param>
        internal void PopulateBusinessObjectFromReader(MakingTemplates businessObject, IDataReader dataReader)
        {

            businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.Id.ToString()));

            businessObject.JobId = dataReader.GetInt32(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.JobId.ToString()));

            businessObject.OrderReceiverId = dataReader.GetInt32(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.OrderReceiverId.ToString()));

            businessObject.LetterPressDeviceId = dataReader.GetInt32(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.LetterPressDeviceId.ToString()));

            businessObject.TemplateMaterialTypeId = dataReader.GetInt32(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.TemplateMaterialTypeId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.Dimension.ToString())))
            {
                businessObject.Dimension = dataReader.GetString(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.Dimension.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.Count.ToString())))
            {
                businessObject.Count = dataReader.GetInt32(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.Count.ToString()));
            }

            businessObject.BladeTypeId = dataReader.GetInt32(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.BladeTypeId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.PorferazhModel.ToString())))
            {
                businessObject.PorferazhModel = dataReader.GetString(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.PorferazhModel.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.Description.ToString())))
            {
                businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.Description.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.InvoiceRow.ToString())))
            {
                businessObject.InvoiceRow = dataReader.GetString(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.InvoiceRow.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.InvoiceNum.ToString())))
            {
                businessObject.InvoiceNum = dataReader.GetString(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.InvoiceNum.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.InvoiceCost.ToString())))
            {
                businessObject.InvoiceCost = dataReader.GetDecimal(dataReader.GetOrdinal(MakingTemplates.MakingTemplatesFields.InvoiceCost.ToString()));
            }

        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of MakingTemplates</returns>
        internal List<MakingTemplates> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<MakingTemplates> list = new List<MakingTemplates>();

            while (dataReader.Read())
            {
                MakingTemplates businessObject = new MakingTemplates();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

    }
}
