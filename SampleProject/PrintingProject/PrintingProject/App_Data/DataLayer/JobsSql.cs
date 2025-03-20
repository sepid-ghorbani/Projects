using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PrintingProject.BusinessLayer.DataLayer
{
    /// <summary>
    /// Data access layer class for Jobs
    /// </summary>
    class JobsSql : DataLayerBase
    {

        #region Constructor

        /// <summary>
        /// Class constructor
        /// </summary>
        public JobsSql()
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
        public bool Insert(Jobs businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_Insert]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@CustomerId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CustomerId));
                sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@CreateDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreateDate));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
                sqlCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Code));
                sqlCommand.Parameters.Add(new SqlParameter("@StoreCode", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.StoreCode));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                businessObject.Id = (int)sqlCommand.Parameters["@Id"].Value;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Jobs::Insert::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        public bool Copy(int jobId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_Copy]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                sqlCommand.Parameters.AddWithValue("@JobId", jobId);

                MainConnection.Open();
                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Jobs::Insert::Error occured.", ex);
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
        public bool Update(Jobs businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@CustomerId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CustomerId));
                sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@CreateDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreateDate));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
                sqlCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 2147483647, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Code));
                sqlCommand.Parameters.Add(new SqlParameter("@StoreCode", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.StoreCode));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Jobs::Update::Error occured.", ex);
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
        /// <returns>Jobs business object</returns>
        public Jobs SelectByPrimaryKey(JobsKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_SelectByPrimaryKey]";
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
                    Jobs businessObject = new Jobs();

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
                throw new Exception("Jobs::SelectByPrimaryKey::Error occured.", ex);
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
        /// <returns>list of Jobs</returns>
        public List<Jobs> SelectAll(int customerId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_SelectAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                sqlCommand.Parameters.AddWithValue("@CustomerId", customerId);
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("Jobs::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
        public List<Jobs> SelectAllInserted(int? customerId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_SelectAllInserted]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                sqlCommand.Parameters.AddWithValue("@CustomerId", customerId);

                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("Jobs::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }
        public DataTable SelectAllForGrid(int? id, string name, string code, int startIndex, int pageSize)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_SelectAll_ForGrid]";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("Id", id);
            sqlCommand.Parameters.AddWithValue("Name", name);
            sqlCommand.Parameters.AddWithValue("@Code", code);
            sqlCommand.Parameters.AddWithValue("StartIndex", startIndex);
            sqlCommand.Parameters.AddWithValue("PageSize", pageSize);

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
                throw new Exception("Jobs::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public int GetTotalCount(int? id, string name,string code)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_GetTotalCount]";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Code", code);

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                MainConnection.Open();
                IDataReader dataReader = sqlCommand.ExecuteReader();
                var result = 0;
                while (dataReader.Read())
                {
                    result = dataReader.GetInt32(0);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("UserPage::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable ReportBaseOnCustomer(string invoiceStatus, int? cutomerId, string jobName, int? jobNum, DateTime? startDate, DateTime? endDate)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Job_Report_BaseOnCustomer]";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("InvoiceStatus", invoiceStatus);
            sqlCommand.Parameters.AddWithValue("CutomerId", cutomerId);
            sqlCommand.Parameters.AddWithValue("JobName", jobName);
            sqlCommand.Parameters.AddWithValue("JobNum", jobNum);
            sqlCommand.Parameters.AddWithValue("StartDate", startDate);
            sqlCommand.Parameters.AddWithValue("EndDate", endDate);

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
                throw new Exception("Jobs::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        public DataTable ReportBaseOnOrderReceiver(string levelName, int? orderReceiverId, string invoiceStatus, int? invoiceNum, int? customerId,
            string jobName, int? jobNum, DateTime? startDate, DateTime? endDate)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Job_Report_BaseOnOrderReceiver]";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("LevelName", levelName);
            sqlCommand.Parameters.AddWithValue("OrderReceiverId", orderReceiverId);
            sqlCommand.Parameters.AddWithValue("InvoiceStatus", invoiceStatus);
            sqlCommand.Parameters.AddWithValue("InvoiceNum", invoiceNum);
            sqlCommand.Parameters.AddWithValue("CustomerId", customerId);
            sqlCommand.Parameters.AddWithValue("JobName", jobName);
            sqlCommand.Parameters.AddWithValue("JobNum", jobNum);
            sqlCommand.Parameters.AddWithValue("StartDate", startDate);
            sqlCommand.Parameters.AddWithValue("EndDate", endDate);

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
                throw new Exception("Jobs::SelectAll::Error occured.", ex);
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
        /// <returns>list of Jobs</returns>
        public List<Jobs> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_SelectByField]";
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
                throw new Exception("Jobs::SelectByField::Error occured.", ex);
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
        public bool Delete(JobsKeys keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Jobs_DeleteByPrimaryKey]";
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
                throw new Exception("Jobs::DeleteByKey::Error occured.", ex);
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
            sqlCommand.CommandText = "dbo.[Jobs_DeleteByField]";
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
                throw new Exception("Jobs::DeleteByField::Error occured.", ex);
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
        internal void PopulateBusinessObjectFromReader(Jobs businessObject, IDataReader dataReader)
        {


            businessObject.Id = dataReader.GetInt32(dataReader.GetOrdinal(Jobs.JobsFields.Id.ToString()));

            businessObject.CustomerId = dataReader.GetInt32(dataReader.GetOrdinal(Jobs.JobsFields.CustomerId.ToString()));

            businessObject.Name = dataReader.GetString(dataReader.GetOrdinal(Jobs.JobsFields.Name.ToString()));

            businessObject.CreateDate = dataReader.GetDateTime(dataReader.GetOrdinal(Jobs.JobsFields.CreateDate.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Jobs.JobsFields.Description.ToString())))
            {
                businessObject.Description = dataReader.GetString(dataReader.GetOrdinal(Jobs.JobsFields.Description.ToString()));
            }
            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Jobs.JobsFields.Code.ToString())))
            {
                businessObject.Code = dataReader.GetString(dataReader.GetOrdinal(Jobs.JobsFields.Code.ToString()));
            }
            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Jobs.JobsFields.StoreCode.ToString())))
            {
                businessObject.StoreCode = dataReader.GetInt32(dataReader.GetOrdinal(Jobs.JobsFields.StoreCode.ToString()));
            }


        }
       
        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of Jobs</returns>
        internal List<Jobs> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<Jobs> list = new List<Jobs>();

            while (dataReader.Read())
            {
                Jobs businessObject = new Jobs();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }
        
        #endregion

    }
}
