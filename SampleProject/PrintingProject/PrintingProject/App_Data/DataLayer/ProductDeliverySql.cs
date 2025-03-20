using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PrintingProject.BusinessLayer.DataLayer
{
    /// <summary>
    /// Data access layer class for ProductDelivery
    /// </summary>
    class ProductDeliverySql : DataLayerBase
    {

        #region Constructor

        /// <summary>
        /// Class constructor
        /// </summary>
        public ProductDeliverySql()
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
        public bool Insert(ProductDelivery businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[ProductDelivery_Insert]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@CartexId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CartexId));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@JobTypesId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobTypesId));
                sqlCommand.Parameters.Add(new SqlParameter("@DeliveryReceiversId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeliveryReceiversId));
                sqlCommand.Parameters.Add(new SqlParameter("@DeliveryCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeliveryCount));
                sqlCommand.Parameters.Add(new SqlParameter("@Fee1", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Fee1));
                sqlCommand.Parameters.Add(new SqlParameter("@DeliveryDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeliveryDate));
                sqlCommand.Parameters.Add(new SqlParameter("@ReceiptNum", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ReceiptNum));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
                sqlCommand.Parameters.Add(new SqlParameter("@InputInvoiceDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InputInvoiceDate));
                sqlCommand.Parameters.Add(new SqlParameter("@InputInvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InputInvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@InputInvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InputInvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@InputInvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InputInvoiceCost));
                sqlCommand.Parameters.Add(new SqlParameter("@OutputInvoiceDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OutputInvoiceDate));
                sqlCommand.Parameters.Add(new SqlParameter("@OutputInvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OutputInvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@OutputInvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OutputInvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@OutputInvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OutputInvoiceCost));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                businessObject.Id = (int)sqlCommand.Parameters["@Id"].Value;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("ProductDelivery::Insert::Error occured.", ex);
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
        public bool Update(ProductDelivery businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[ProductDelivery_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@CartexId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CartexId));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderReceiverId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OrderReceiverId));
                sqlCommand.Parameters.Add(new SqlParameter("@JobTypesId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.JobTypesId));
                sqlCommand.Parameters.Add(new SqlParameter("@DeliveryReceiversId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeliveryReceiversId));
                sqlCommand.Parameters.Add(new SqlParameter("@DeliveryCount", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeliveryCount));
                sqlCommand.Parameters.Add(new SqlParameter("@Fee1", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Fee1));
                sqlCommand.Parameters.Add(new SqlParameter("@DeliveryDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.DeliveryDate));
                sqlCommand.Parameters.Add(new SqlParameter("@ReceiptNum", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ReceiptNum));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
                sqlCommand.Parameters.Add(new SqlParameter("@InputInvoiceDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InputInvoiceDate));
                sqlCommand.Parameters.Add(new SqlParameter("@InputInvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InputInvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@InputInvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InputInvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@InputInvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.InputInvoiceCost));
                sqlCommand.Parameters.Add(new SqlParameter("@OutputInvoiceDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OutputInvoiceDate));
                sqlCommand.Parameters.Add(new SqlParameter("@OutputInvoiceRow", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OutputInvoiceRow));
                sqlCommand.Parameters.Add(new SqlParameter("@OutputInvoiceNum", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OutputInvoiceNum));
                sqlCommand.Parameters.Add(new SqlParameter("@OutputInvoiceCost", SqlDbType.Money, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.OutputInvoiceCost));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("ProductDelivery::Update::Error occured.", ex);
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
        /// <returns>ProductDelivery business object</returns>
        public ProductDelivery SelectByPrimaryKey(ProductDeliveryKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[ProductDelivery_SelectByPrimaryKey]";
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
                    ProductDelivery businessObject = new ProductDelivery();

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
                throw new Exception("ProductDelivery::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of ProductDelivery</returns>
        public List<ProductDelivery> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[ProductDelivery_SelectAll]";
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
                throw new Exception("ProductDelivery::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public bool HasPermissionToInsert(int cartexId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[ProductDelivery_HasPermissionToInsert]";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@CartexId", cartexId);

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;
            try
            {

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                var result = false;
                while (dataReader.Read())
                {
                    result = dataReader.GetBoolean(0);
                }
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception("ProductDelivery::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable SelectAllForGrid(int cartextId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[ProductDelivery_SelectAll_ForGrid]";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("CartexId", cartextId);

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
                throw new Exception("ProductDelivery::SelectAll::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[ProductDelivery_reportById]";
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
                throw new Exception("ProductDelivery::SelectAll::Error occured.", ex);
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
        /// <returns>list of ProductDelivery</returns>
        public List<ProductDelivery> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[ProductDelivery_SelectByField]";
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
                throw new Exception("ProductDelivery::SelectByField::Error occured.", ex);
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
        public bool Delete(ProductDeliveryKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[ProductDelivery_DeleteByPrimaryKey]";
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
                throw new Exception("ProductDelivery::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[ProductDelivery_DeleteByField]";
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
                throw new Exception("ProductDelivery::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(ProductDelivery businessObject, IDataReader dataReader)
        {


            businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.Id.ToString()));

            businessObject.CartexId = dataReader.GetInt32(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.CartexId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OrderReceiverId.ToString())))
            {
                businessObject.OrderReceiverId = dataReader.GetInt32(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OrderReceiverId.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.JobTypesId.ToString())))
            {
                businessObject.JobTypesId = dataReader.GetInt32(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.JobTypesId.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.DeliveryReceiversId.ToString())))
            {
                businessObject.DeliveryReceiversId = dataReader.GetInt32(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.DeliveryReceiversId.ToString()));
            }

            businessObject.DeliveryCount = dataReader.GetInt32(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.DeliveryCount.ToString()));

            businessObject.Fee1 = dataReader.GetDecimal(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.Fee1.ToString()));

            businessObject.DeliveryDate = dataReader.GetDateTime(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.DeliveryDate.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.ReceiptNum.ToString())))
            {
                businessObject.ReceiptNum = dataReader.GetString(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.ReceiptNum.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.Description.ToString())))
            {
                businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.Description.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.InputInvoiceDate.ToString())))
            {
                businessObject.InputInvoiceDate = dataReader.GetDateTime(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.InputInvoiceDate.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.InputInvoiceRow.ToString())))
            {
                businessObject.InputInvoiceRow = dataReader.GetString(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.InputInvoiceRow.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.InputInvoiceNum.ToString())))
            {
                businessObject.InputInvoiceNum = dataReader.GetString(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.InputInvoiceNum.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.InputInvoiceCost.ToString())))
            {
                businessObject.InputInvoiceCost = dataReader.GetDecimal(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.InputInvoiceCost.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OutputInvoiceDate.ToString())))
            {
                businessObject.OutputInvoiceDate = dataReader.GetDateTime(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OutputInvoiceDate.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OutputInvoiceRow.ToString())))
            {
                businessObject.OutputInvoiceRow = dataReader.GetString(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OutputInvoiceRow.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OutputInvoiceNum.ToString())))
            {
                businessObject.OutputInvoiceNum = dataReader.GetString(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OutputInvoiceNum.ToString()));
            }

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OutputInvoiceCost.ToString())))
            {
                businessObject.OutputInvoiceCost = dataReader.GetDecimal(dataReader.GetOrdinal(ProductDelivery.ProductDeliveryFields.OutputInvoiceCost.ToString()));
            }




        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of ProductDelivery</returns>
        internal List<ProductDelivery> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<ProductDelivery> list = new List<ProductDelivery>();

            while (dataReader.Read())
            {
                ProductDelivery businessObject = new ProductDelivery();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

    }
}
