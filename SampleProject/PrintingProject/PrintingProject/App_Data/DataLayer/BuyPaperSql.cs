using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PrintingProject.BusinessLayer.DataLayer
{
	/// <summary>
	/// Data access layer class for BuyPaper
	/// </summary>
	class BuyPaperSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public BuyPaperSql()
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
		public bool Insert(BuyPaper businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[BuyPaper_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@Row", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Row));
                sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeGramazhId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeGramazhId));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperWidthId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperWidthId));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperHeightId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperHeightId));
                sqlCommand.Parameters.Add(new SqlParameter("@ParagraphCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ParagraphCount));
                sqlCommand.Parameters.Add(new SqlParameter("@LeafCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LeafCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@Fee", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Fee));
                sqlCommand.Parameters.Add(new SqlParameter("@SumCostType", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SumCostType));
                sqlCommand.Parameters.Add(new SqlParameter("@SumCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SumCost));
                sqlCommand.Parameters.Add(new SqlParameter("@InstituteId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InstituteId));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceCost));
                sqlCommand.Parameters.AddWithValue("@Description", businessObject.Description);
								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                businessObject.Id = (int)sqlCommand.Parameters["@Id"].Value;

				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("BuyPaper::Insert::Error occured.", ex);
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
        public bool Update(BuyPaper businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BuyPaper_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@Row", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Row));
                sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeGramazhId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeGramazhId));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperWidthId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperWidthId));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperHeightId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperHeightId));
                sqlCommand.Parameters.Add(new SqlParameter("@ParagraphCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ParagraphCount));
                sqlCommand.Parameters.Add(new SqlParameter("@LeafCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LeafCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@Fee", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Fee));
                sqlCommand.Parameters.Add(new SqlParameter("@SumCostType", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SumCostType));
                sqlCommand.Parameters.Add(new SqlParameter("@SumCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SumCost));
                sqlCommand.Parameters.Add(new SqlParameter("@InstituteId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InstituteId));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceCost));
                sqlCommand.Parameters.AddWithValue("@Description", businessObject.Description);


                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("BuyPaper::Update::Error occured.", ex);
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
        /// <returns>BuyPaper business object</returns>
        public BuyPaper SelectByPrimaryKey(BuyPaperKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BuyPaper_SelectByPrimaryKey]";
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
                    BuyPaper businessObject = new BuyPaper();

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
                throw new Exception("BuyPaper::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of BuyPaper</returns>
        public List<BuyPaper> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BuyPaper_SelectAll]";
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
                throw new Exception("BuyPaper::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable BuyAndPreparingPaperReport(int? orderReceiverId,int? sourceId, int? destinationId, int? materialTypeId
            , int? materialTypeGramazhId, int? paperWidthId, int? paperHeightId, DateTime? startDate,
            DateTime? endDate)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BuyAndPreparingPaper_Report]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;
            sqlCommand.Parameters.AddWithValue("@OrderReceiverId", orderReceiverId);
            sqlCommand.Parameters.AddWithValue("@SourceId", sourceId);
            sqlCommand.Parameters.AddWithValue("@DestinationId", destinationId);
            sqlCommand.Parameters.AddWithValue("@MaterialTypeId", materialTypeId);
            sqlCommand.Parameters.AddWithValue("@MaterialTypeGramazhId", materialTypeGramazhId);
            sqlCommand.Parameters.AddWithValue("@PaperWidthId", paperWidthId);
            sqlCommand.Parameters.AddWithValue("@PaperHeightId", paperHeightId);
            sqlCommand.Parameters.AddWithValue("@StartDate", startDate);
            sqlCommand.Parameters.AddWithValue("@EndDate", endDate);
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
        public DataTable SelectAllForGrid(int jobId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BuyPaper_SelectAll_ForGrid]";
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
            sqlCommand.CommandText = "dbo.[BuyPaper_ReportById]";
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
        /// <returns>list of BuyPaper</returns>
        public List<BuyPaper> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BuyPaper_SelectByField]";
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
                throw new Exception("BuyPaper::SelectByField::Error occured.", ex);
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
        public bool Delete(BuyPaperKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[BuyPaper_DeleteByPrimaryKey]";
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
                throw new Exception("BuyPaper::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[BuyPaper_DeleteByField]";
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
                throw new Exception("BuyPaper::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(BuyPaper businessObject, IDataReader dataReader)
        {


            businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.Id.ToString()));

            businessObject.JobId = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.JobId.ToString()));

            businessObject.OrderReceiverId = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.OrderReceiverId.ToString()));

            businessObject.Row = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.Row.ToString()));

            businessObject.MaterialTypeId = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.MaterialTypeId.ToString()));

            businessObject.MaterialTypeGramazhId = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.MaterialTypeGramazhId.ToString()));

            businessObject.PaperWidthId = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.PaperWidthId.ToString()));

            businessObject.PaperHeightId = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.PaperHeightId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.ParagraphCount.ToString())))
            {
                businessObject.ParagraphCount = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.ParagraphCount.ToString()));
            }

            businessObject.LeafCountId = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.LeafCountId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.Fee.ToString())))
            {
                businessObject.Fee = dataReader.GetDecimal(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.Fee.ToString()));
            }

            businessObject.SumCostType = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.SumCostType.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.SumCost.ToString())))
            {
                businessObject.SumCost = dataReader.GetDecimal(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.SumCost.ToString()));
            }

            businessObject.InstituteId = dataReader.GetInt32(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.InstituteId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.InvoiceRow.ToString())))
            {
                businessObject.InvoiceRow = dataReader.GetString(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.InvoiceRow.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.InvoiceNum.ToString())))
            {
                businessObject.InvoiceNum = dataReader.GetString(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.InvoiceNum.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.InvoiceCost.ToString())))
            {
                businessObject.InvoiceCost = dataReader.GetDecimal(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.InvoiceCost.ToString()));
            }
            if (!dataReader.IsDBNull(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.Description.ToString())))
            {
                businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(BuyPaper.BuyPaperFields.Description.ToString()));
            }
        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of BuyPaper</returns>
        internal List<BuyPaper> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<BuyPaper> list = new List<BuyPaper>();

            while (dataReader.Read())
            {
                BuyPaper businessObject = new BuyPaper();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
