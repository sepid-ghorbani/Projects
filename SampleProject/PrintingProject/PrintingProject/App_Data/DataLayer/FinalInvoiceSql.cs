using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PrintingProject.BusinessLayer.DataLayer
{
    /// <summary>
    /// Data access layer class for FinalInvoice
    /// </summary>
    class FinalInvoiceSql : DataLayerBase
    {

        #region Constructor

        /// <summary>
        /// Class constructor
        /// </summary>
        public FinalInvoiceSql()
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
        public bool Insert(FinalInvoice businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[FinalInvoice_Insert]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@HasInvoice", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HasInvoice));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@PlateCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PlateCost));
                sqlCommand.Parameters.Add(new SqlParameter("@FilmCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FilmCost));
                sqlCommand.Parameters.Add(new SqlParameter("@CopyZinkCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CopyZinkCost));
                sqlCommand.Parameters.Add(new SqlParameter("@StereotypeCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.StereotypeCost));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintingCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintingCost));
                sqlCommand.Parameters.Add(new SqlParameter("@BuyPaperCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BuyPaperCost));
                sqlCommand.Parameters.Add(new SqlParameter("@VeneerCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.VeneerCost));
                sqlCommand.Parameters.Add(new SqlParameter("@LetterPressCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LetterPressCost));
                sqlCommand.Parameters.Add(new SqlParameter("@MakingTemplateCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MakingTemplateCost));
                sqlCommand.Parameters.Add(new SqlParameter("@SahafiCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SahafiCost));
                sqlCommand.Parameters.Add(new SqlParameter("@SumAll", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SumAll));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));

                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                businessObject.Id = (int)sqlCommand.Parameters["@Id"].Value;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("FinalInvoice::Insert::Error occured.", ex);
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
        public bool Update(FinalInvoice businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[FinalInvoice_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@HasInvoice", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.HasInvoice));
                sqlCommand.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobId));
                sqlCommand.Parameters.Add(new SqlParameter("@PlateCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PlateCost));
                sqlCommand.Parameters.Add(new SqlParameter("@FilmCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.FilmCost));
                sqlCommand.Parameters.Add(new SqlParameter("@CopyZinkCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CopyZinkCost));
                sqlCommand.Parameters.Add(new SqlParameter("@StereotypeCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.StereotypeCost));
                sqlCommand.Parameters.Add(new SqlParameter("@PrintingCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PrintingCost));
                sqlCommand.Parameters.Add(new SqlParameter("@BuyPaperCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.BuyPaperCost));
                sqlCommand.Parameters.Add(new SqlParameter("@VeneerCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.VeneerCost));
                sqlCommand.Parameters.Add(new SqlParameter("@LetterPressCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.LetterPressCost));
                sqlCommand.Parameters.Add(new SqlParameter("@MakingTemplateCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MakingTemplateCost));
                sqlCommand.Parameters.Add(new SqlParameter("@SahafiCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SahafiCost));
                sqlCommand.Parameters.Add(new SqlParameter("@SumAll", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SumAll));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));

                

                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("FinalInvoice::Update::Error occured.", ex);
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
        /// <returns>FinalInvoice business object</returns>
        public FinalInvoice SelectByPrimaryKey(FinalInvoiceKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[FinalInvoice_SelectByPrimaryKey]";
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
                    FinalInvoice businessObject = new FinalInvoice();

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
                throw new Exception("FinalInvoice::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of FinalInvoice</returns>
        public List<FinalInvoice> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[FinalInvoice_SelectAll]";
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
                throw new Exception("FinalInvoice::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[FinalInvoice_ReportById]";
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
        public DataTable SelectInputCosts(int jobId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[FinalInvoice_SelectInputCosts]";
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
                throw new Exception("FinalInvoice::SelectAll::Error occured.", ex);
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
        /// <returns>list of FinalInvoice</returns>
        public List<FinalInvoice> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[FinalInvoice_SelectByField]";
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
                throw new Exception("FinalInvoice::SelectByField::Error occured.", ex);
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
        public bool Delete(FinalInvoiceKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[FinalInvoice_DeleteByPrimaryKey]";
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
                throw new Exception("FinalInvoice::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[FinalInvoice_DeleteByField]";
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
                throw new Exception("FinalInvoice::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(FinalInvoice businessObject, IDataReader dataReader)
        {


            businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.Id.ToString()));

            businessObject.HasInvoice = dataReader.GetBoolean(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.HasInvoice.ToString()));

            businessObject.JobId = dataReader.GetInt32(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.JobId.ToString()));

            businessObject.PlateCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.PlateCost.ToString()));

            businessObject.FilmCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.FilmCost.ToString()));

            businessObject.CopyZinkCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.CopyZinkCost.ToString()));

            businessObject.StereotypeCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.StereotypeCost.ToString()));

            businessObject.PrintingCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.PrintingCost.ToString()));

            businessObject.BuyPaperCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.BuyPaperCost.ToString()));

            businessObject.VeneerCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.VeneerCost.ToString()));

            businessObject.LetterPressCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.LetterPressCost.ToString()));

            businessObject.MakingTemplateCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.MakingTemplateCost.ToString()));

            businessObject.SahafiCost = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.SahafiCost.ToString()));

            businessObject.SumAll = dataReader.GetDecimal(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.SumAll.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.Description.ToString())))
            {
                businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(FinalInvoice.FinalInvoiceFields.Description.ToString()));
            }
        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of FinalInvoice</returns>
        internal List<FinalInvoice> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<FinalInvoice> list = new List<FinalInvoice>();

            while (dataReader.Read())
            {
                FinalInvoice businessObject = new FinalInvoice();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

    }
}
