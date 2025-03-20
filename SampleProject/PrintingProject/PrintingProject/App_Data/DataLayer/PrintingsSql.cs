using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PrintingProject.BusinessLayer.DataLayer
{
    /// <summary>
    /// Data access layer class for Printings
    /// </summary>
    class PrintingsSql : DataLayerBase
    {

        #region Constructor

        /// <summary>
        /// Class constructor
        /// </summary>
        public PrintingsSql()
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
        public bool Insert(Printings businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Printings_Insert]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@Row", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Row));
                sqlCommand.Parameters.Add(new SqlParameter("@Printing", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Printing));
                sqlCommand.Parameters.Add(new SqlParameter("@Dimension", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Dimension));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@ZinkTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ZinkTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintModelId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintModelId));
                sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeGramazhId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeGramazhId));
                sqlCommand.Parameters.Add(new SqlParameter("@LargePaperCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LargePaperCount));
                sqlCommand.Parameters.Add(new SqlParameter("@LargePaperSize", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LargePaperSize));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperParagraphCount", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperParagraphCount));
                sqlCommand.Parameters.Add(new SqlParameter("@ParagraphLeafCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ParagraphLeafCount));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintingTirazh", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintingTirazh));
                sqlCommand.Parameters.Add(new SqlParameter("@MainColorCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MainColorCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@ExportColorId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ExportColorId));
                sqlCommand.Parameters.Add(new SqlParameter("@SpotColorCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SpotColorCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@SpotColors", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SpotColors));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintingSupervision", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintingSupervision));
                sqlCommand.Parameters.Add(new SqlParameter("@ColorInstance", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ColorInstance));
                sqlCommand.Parameters.Add(new SqlParameter("@DeviceCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeviceCount));
                sqlCommand.Parameters.Add(new SqlParameter("@FormEvertCount", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FormEvertCount));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceCost));
                sqlCommand.Parameters.Add(new SqlParameter("@IsUse", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsUse));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperWidthId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperWidthId));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperHeightId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperHeightId));
                sqlCommand.Parameters.Add(new SqlParameter("@FromInstituteId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FromInstituteId));

                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                businessObject.Id = (int)sqlCommand.Parameters["@Id"].Value;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Printings::Insert::Error occured.", ex);
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
        public bool Update(Printings businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Printings_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@Row", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Row));
                sqlCommand.Parameters.Add(new SqlParameter("@Printing", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Printing));
                sqlCommand.Parameters.Add(new SqlParameter("@Dimension", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Dimension));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@ZinkTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ZinkTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintModelId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintModelId));
                sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeId));
                sqlCommand.Parameters.Add(new SqlParameter("@MaterialTypeGramazhId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MaterialTypeGramazhId));
                sqlCommand.Parameters.Add(new SqlParameter("@LargePaperCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LargePaperCount));
                sqlCommand.Parameters.Add(new SqlParameter("@LargePaperSize", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LargePaperSize));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperParagraphCount", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperParagraphCount));
                sqlCommand.Parameters.Add(new SqlParameter("@ParagraphLeafCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ParagraphLeafCount));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintingTirazh", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintingTirazh));
                sqlCommand.Parameters.Add(new SqlParameter("@MainColorCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MainColorCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@ExportColorId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ExportColorId));
                sqlCommand.Parameters.Add(new SqlParameter("@SpotColorCountId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SpotColorCountId));
                sqlCommand.Parameters.Add(new SqlParameter("@SpotColors", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SpotColors));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintingSupervision", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintingSupervision));
                sqlCommand.Parameters.Add(new SqlParameter("@ColorInstance", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ColorInstance));
                sqlCommand.Parameters.Add(new SqlParameter("@DeviceCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeviceCount));
                sqlCommand.Parameters.Add(new SqlParameter("@FormEvertCount", SqlDbType.Float, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FormEvertCount));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@InvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InvoiceCost));
                sqlCommand.Parameters.Add(new SqlParameter("@IsUse", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsUse));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperWidthId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperWidthId));
                sqlCommand.Parameters.Add(new SqlParameter("@PaperHeightId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PaperHeightId));
                sqlCommand.Parameters.Add(new SqlParameter("@FromInstituteId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FromInstituteId));

                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Printings::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        public bool UpdateCartexStock(int id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "[dbo].[Printings_UpdateCartexStock]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                sqlCommand.Parameters.AddWithValue("@Id", id);
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Printings::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        public bool UpdateCartexStockSub(int id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "[dbo].[Printings_UpdateCartexStockSub]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                sqlCommand.Parameters.AddWithValue("@Id", id);
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Printings::Update::Error occured.", ex);
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
        /// <returns>Printings business object</returns>
        public Printings SelectByPrimaryKey(PrintingsKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Printings_SelectByPrimaryKey]";
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
                    Printings businessObject = new Printings();

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
                throw new Exception("Printings::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of Printings</returns>
        public List<Printings> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Printings_SelectAll]";
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
                throw new Exception("Printings::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[Printings_SelectAll_ForGrid]";
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
                throw new Exception("Printings::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[Printings_ReportById]";
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
        /// <returns>list of Printings</returns>
        public List<Printings> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Printings_SelectByField]";
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
                throw new Exception("Printings::SelectByField::Error occured.", ex);
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
        public bool Delete(PrintingsKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Printings_DeleteByPrimaryKey]";
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
                throw new Exception("Printings::DeleteByKey::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public bool IsSend(int id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "[dbo].[Printings_IsSend]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                bool result = false;
                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.Parameters.Add(new SqlParameter("@Result", SqlDbType.Bit, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, result));

                MainConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return (bool)sqlCommand.Parameters["@Result"].Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Printings::DeleteByKey::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public bool HasCartex(int id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "[dbo].[Printings_HasCartex]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                bool result = false;
                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.Parameters.Add(new SqlParameter("@Result", SqlDbType.Bit, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, result));

                MainConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return (bool)sqlCommand.Parameters["@Result"].Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Printings::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[Printings_DeleteByField]";
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
                throw new Exception("Printings::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(Printings businessObject, IDataReader dataReader)
        {

            businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.Id.ToString()));

            businessObject.JobId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.JobId.ToString()));

            businessObject.Row = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.Row.ToString()));

            businessObject.Printing = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.Printing.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.Dimension.ToString())))
            {
                businessObject.Dimension = dataReader.GetString(dataReader.GetOrdinal(Printings.PrintingsFields.Dimension.ToString()));
            }

            businessObject.OrderReceiverId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.OrderReceiverId.ToString()));

            businessObject.PrintTypeId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.PrintTypeId.ToString()));

            businessObject.ZinkTypeId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.ZinkTypeId.ToString()));

            businessObject.PrintModelId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.PrintModelId.ToString()));

            businessObject.MaterialTypeId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.MaterialTypeId.ToString()));

            businessObject.MaterialTypeGramazhId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.MaterialTypeGramazhId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.LargePaperCount.ToString())))
            {
                businessObject.LargePaperCount = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.LargePaperCount.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.LargePaperSize.ToString())))
            {
                businessObject.LargePaperSize = dataReader.GetString(dataReader.GetOrdinal(Printings.PrintingsFields.LargePaperSize.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.PaperParagraphCount.ToString())))
            {
                businessObject.PaperParagraphCount = dataReader.GetDouble(dataReader.GetOrdinal(Printings.PrintingsFields.PaperParagraphCount.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.ParagraphLeafCount.ToString())))
            {
                businessObject.ParagraphLeafCount = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.ParagraphLeafCount.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.PrintingTirazh.ToString())))
            {
                businessObject.PrintingTirazh = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.PrintingTirazh.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.MainColorCountId.ToString())))
            {
                businessObject.MainColorCountId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.MainColorCountId.ToString()));
            }

            businessObject.ExportColorId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.ExportColorId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.SpotColorCountId.ToString())))
            {
                businessObject.SpotColorCountId = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.SpotColorCountId.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.SpotColors.ToString())))
            {
                businessObject.SpotColors = dataReader.GetString(dataReader.GetOrdinal(Printings.PrintingsFields.SpotColors.ToString()));
            }

            businessObject.PrintingSupervision = dataReader.GetBoolean(dataReader.GetOrdinal(Printings.PrintingsFields.PrintingSupervision.ToString()));

            businessObject.ColorInstance = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.ColorInstance.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.DeviceCount.ToString())))
            {
                businessObject.DeviceCount = dataReader.GetInt32(dataReader.GetOrdinal(Printings.PrintingsFields.DeviceCount.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.FormEvertCount.ToString())))
            {
                businessObject.FormEvertCount = dataReader.GetDouble(dataReader.GetOrdinal(Printings.PrintingsFields.FormEvertCount.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.Description.ToString())))
            {
                businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(Printings.PrintingsFields.Description.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.InvoiceRow.ToString())))
            {
                businessObject.InvoiceRow = dataReader.GetString(dataReader.GetOrdinal(Printings.PrintingsFields.InvoiceRow.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.InvoiceNum.ToString())))
            {
                businessObject.InvoiceNum = dataReader.GetString(dataReader.GetOrdinal(Printings.PrintingsFields.InvoiceNum.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.InvoiceCost.ToString())))
            {
                businessObject.InvoiceCost = dataReader.GetDecimal(dataReader.GetOrdinal(Printings.PrintingsFields.InvoiceCost.ToString()));
            }
            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.IsUse.ToString())))
            {
                businessObject.IsUse = dataReader.GetBoolean(dataReader.GetOrdinal(Printings.PrintingsFields.IsUse.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.PaperWidthId.ToString())))
            {
                businessObject.PaperWidthId = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.PaperWidthId.ToString()));
               
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.PaperHeightId.ToString())))
            {
                businessObject.PaperHeightId = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.PaperHeightId.ToString()));

            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Printings.PrintingsFields.FromInstituteId.ToString())))
            {
                businessObject.FromInstituteId = dataReader.GetInt32(dataReader.GetOrdinal(UsePaper.UsePaperFields.FromInstituteId.ToString()));

            }

        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of Printings</returns>
        internal List<Printings> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<Printings> list = new List<Printings>();

            while (dataReader.Read())
            {
                Printings businessObject = new Printings();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

    }
}
