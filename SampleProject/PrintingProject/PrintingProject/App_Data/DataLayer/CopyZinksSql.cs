using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PrintingProject.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for CopyZinks
	/// </summary>
	class CopyZinksSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public CopyZinksSql()
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
		public bool Insert(CopyZinks businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[CopyZinks_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@DimensionId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DimensionId));
                sqlCommand.Parameters.Add(new SqlParameter("@LpiId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LpiId));
                sqlCommand.Parameters.Add(new SqlParameter("@MainColorCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MainColorCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@ExportColorId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ExportColorId));
                sqlCommand.Parameters.Add(new SqlParameter("@SpotColorCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SpotColorCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@SpotColors", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SpotColors));
                sqlCommand.Parameters.Add(new SqlParameter("@OverPrintBlackColor", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OverPrintBlackColor));
                sqlCommand.Parameters.Add(new SqlParameter("@DeviceCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeviceCount));
                sqlCommand.Parameters.Add(new SqlParameter("@FormEvertCount", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FormEvertCount));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceCost));


								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Id = (int)sqlCommand.Parameters["@Id"].Value;

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("CopyZinks::Insert::Error occured.", ex);
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
        public bool Update(CopyZinks businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[CopyZinks_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@DimensionId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DimensionId));
                sqlCommand.Parameters.Add(new SqlParameter("@LpiId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LpiId));
                sqlCommand.Parameters.Add(new SqlParameter("@MainColorCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MainColorCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@ExportColorId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ExportColorId));
                sqlCommand.Parameters.Add(new SqlParameter("@SpotColorCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SpotColorCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@SpotColors", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SpotColors));
                sqlCommand.Parameters.Add(new SqlParameter("@OverPrintBlackColor", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OverPrintBlackColor));
                sqlCommand.Parameters.Add(new SqlParameter("@DeviceCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeviceCount));
                sqlCommand.Parameters.Add(new SqlParameter("@FormEvertCount", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FormEvertCount));
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
                throw new Exception("CopyZinks::Update::Error occured.", ex);
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
        /// <returns>CopyZinks business object</returns>
        public CopyZinks SelectByPrimaryKey(CopyZinksKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[CopyZinks_SelectByPrimaryKey]";
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
                    CopyZinks businessObject = new CopyZinks();

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
                throw new Exception("CopyZinks::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of CopyZinks</returns>
        public List<CopyZinks> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[CopyZinks_SelectAll]";
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
                throw new Exception("CopyZinks::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[CopyZinks_SelectAll_ForGrid]";
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
                throw new Exception("CopyZinks::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[CopyZinks_ReportById]";
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
        /// <returns>list of CopyZinks</returns>
        public List<CopyZinks> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[CopyZinks_SelectByField]";
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
                throw new Exception("CopyZinks::SelectByField::Error occured.", ex);
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
        public bool Delete(CopyZinksKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[CopyZinks_DeleteByPrimaryKey]";
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
                throw new Exception("CopyZinks::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[CopyZinks_DeleteByField]";
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
                throw new Exception("CopyZinks::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(CopyZinks businessObject, IDataReader dataReader)
        {

            businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.Id.ToString()));

            businessObject.JobId = dataReader.GetInt32(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.JobId.ToString()));

            businessObject.OrderReceiverId = dataReader.GetInt32(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.OrderReceiverId.ToString()));

            businessObject.DimensionId = dataReader.GetInt32(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.DimensionId.ToString()));

            businessObject.LpiId = dataReader.GetInt32(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.LpiId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.MainColorCountId.ToString())))
            {
                businessObject.MainColorCountId = dataReader.GetInt32(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.MainColorCountId.ToString()));
            }

            businessObject.ExportColorId = dataReader.GetInt32(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.ExportColorId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.SpotColorCountId.ToString())))
            {
                businessObject.SpotColorCountId = dataReader.GetInt32(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.SpotColorCountId.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.SpotColors.ToString())))
            {
                businessObject.SpotColors = dataReader.GetString(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.SpotColors.ToString()));
            }

            businessObject.OverPrintBlackColor = dataReader.GetBoolean(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.OverPrintBlackColor.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.DeviceCount.ToString())))
            {
                businessObject.DeviceCount = dataReader.GetInt32(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.DeviceCount.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.FormEvertCount.ToString())))
            {
                businessObject.FormEvertCount = dataReader.GetDouble(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.FormEvertCount.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.Description.ToString())))
            {
                businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.Description.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.InvoiceRow.ToString())))
            {
                businessObject.InvoiceRow = dataReader.GetString(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.InvoiceRow.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.InvoiceNum.ToString())))
            {
                businessObject.InvoiceNum = dataReader.GetString(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.InvoiceNum.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.InvoiceCost.ToString())))
            {
                businessObject.InvoiceCost = dataReader.GetDecimal(dataReader.GetOrdinal(CopyZinks.CopyZinksFields.InvoiceCost.ToString()));
            }



        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of CopyZinks</returns>
        internal List<CopyZinks> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<CopyZinks> list = new List<CopyZinks>();

            while (dataReader.Read())
            {
                CopyZinks businessObject = new CopyZinks();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
