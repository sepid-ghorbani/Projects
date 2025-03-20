using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PrintingProject.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for UsePaper
	/// </summary>
	class UsePaperSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public UsePaperSql()
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
		public bool Insert(UsePaper businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[UsePaper_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
				sqlCommand.Parameters.Add(new SqlParameter("@FromInstituteId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FromInstituteId));
				sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeId));
				sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeGramazhId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeGramazhId));
				sqlCommand.Parameters.Add(new SqlParameter("@PaperWidthId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperWidthId));
				sqlCommand.Parameters.Add(new SqlParameter("@PaperHeightId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperHeightId));
				sqlCommand.Parameters.Add(new SqlParameter("@LeafCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LeafCount));
                sqlCommand.Parameters.AddWithValue("@Description", businessObject.Description);

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Id = (int)sqlCommand.Parameters["@Id"].Value;

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("UsePaper::Insert::Error occured.", ex);
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
        public bool Update(UsePaper businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[UsePaper_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
				sqlCommand.Parameters.Add(new SqlParameter("@FromInstituteId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FromInstituteId));
				sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeId));
				sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeGramazhId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeGramazhId));
				sqlCommand.Parameters.Add(new SqlParameter("@PaperWidthId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperWidthId));
				sqlCommand.Parameters.Add(new SqlParameter("@PaperHeightId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperHeightId));
				sqlCommand.Parameters.Add(new SqlParameter("@LeafCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LeafCount));
                sqlCommand.Parameters.AddWithValue("@Description", businessObject.Description);

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("UsePaper::Update::Error occured.", ex);
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
        /// <returns>UsePaper business object</returns>
        public UsePaper SelectByPrimaryKey(UsePaperKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[UsePaper_SelectByPrimaryKey]";
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
                    UsePaper businessObject = new UsePaper();

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
                throw new Exception("UsePaper::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of UsePaper</returns>
        public List<UsePaper> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[UsePaper_SelectAll]";
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
                throw new Exception("UsePaper::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[UsePaper_SelectAll_ForGrid]";
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
                throw new Exception("UsePaper::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable UsePaperGeneralReport(int? customerId, int? sourceId, int? materialTypeId
           , int? materialTypeGramazhId, int? paperWidthId, int? paperHeightId, DateTime? startDate,
           DateTime? endDate,int? useStatus)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[UsePaper_GeneralReport]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;
            sqlCommand.Parameters.AddWithValue("@CustomerId", customerId);
            sqlCommand.Parameters.AddWithValue("@SourceId", sourceId);
            sqlCommand.Parameters.AddWithValue("@MaterialTypeId", materialTypeId);
            sqlCommand.Parameters.AddWithValue("@MaterialTypeGramazhId", materialTypeGramazhId);
            sqlCommand.Parameters.AddWithValue("@PaperWidthId", paperWidthId);
            sqlCommand.Parameters.AddWithValue("@PaperHeightId", paperHeightId);
            sqlCommand.Parameters.AddWithValue("@StartDate", startDate);
            sqlCommand.Parameters.AddWithValue("@EndDate", endDate);
            sqlCommand.Parameters.AddWithValue("@UseStatus", useStatus);
            try
            {

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dataReader);
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("BuyPaper::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[UsePaper_ReportById]";
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
        /// <returns>list of UsePaper</returns>
        public List<UsePaper> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[UsePaper_SelectByField]";
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
                throw new Exception("UsePaper::SelectByField::Error occured.", ex);
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
        public bool Delete(UsePaperKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[UsePaper_DeleteByPrimaryKey]";
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
                throw new Exception("UsePaper::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[UsePaper_DeleteByField]";
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
                throw new Exception("UsePaper::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(UsePaper businessObject, IDataReader dataReader)
        {


				businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.Id.ToString()));

				businessObject.JobId = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.JobId.ToString()));

				businessObject.FromInstituteId = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.FromInstituteId.ToString()));

				businessObject.MaterialTypeId = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.MaterialTypeId.ToString()));

				businessObject.MaterialTypeGramazhId = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.MaterialTypeGramazhId.ToString()));

				businessObject.PaperWidthId = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.PaperWidthId.ToString()));

				businessObject.PaperHeightId = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.PaperHeightId.ToString()));

				businessObject.LeafCount = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.LeafCount.ToString()));
                if (!dataReader.IsDBNull(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.Description.ToString())))
                {
                    businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.Description.ToString()));
                }

        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of UsePaper</returns>
        internal List<UsePaper> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<UsePaper> list = new List<UsePaper>();

            while (dataReader.Read())
            {
                UsePaper businessObject = new UsePaper();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
