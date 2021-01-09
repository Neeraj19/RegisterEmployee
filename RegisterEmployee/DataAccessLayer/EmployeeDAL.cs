using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;
using RegisterEmployee.Models;

namespace RegisterEmployee.DataAccessLayer
{
    public class EmployeeDAL
    {
        private SqlConnection connection;

        

        /// <summary>
        /// In .Net Core, Connection string is brought from json file as apposed to Web Config in ASP .Net, as web config could 
        /// be understood only by IIS Manager. This part is mostly done in a separate CS file and initialized in controller.
        /// </summary>
        public EmployeeDAL()
        {
            var conn = GetConfiguration();
            connection = new SqlConnection(conn.GetSection("ConnectionStrings").GetSection("DefaultSqlServerConnection").Value);
        }

        /// <summary>
        /// If different SqlConnection object is passed from Controller.
        /// </summary>
        /// <param name="sqlConnection">passing sqlConnection.</param>
        public EmployeeDAL(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
        }

        /// <summary>
        /// Building Configuration settings from Json file.
        /// </summary>
        /// <returns>returns IConfiguration object</returns>
        public IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }


        public IDictionary<int,string> GetAllQuestions()
        {
            IDictionary<int, string> result = null;
            try
            {
                DataTable dtbl = new DataTable();
                SqlDataAdapter cmd = new SqlDataAdapter(" SELECT ID, Question FROM [dbo].[SecurityQuestion]", connection);
                cmd.SelectCommand.CommandType = CommandType.Text;
                cmd.Fill(dtbl);
               

                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// To Create new Employee record.
        /// </summary>
        /// <param name="employee">passing employee</param>
        /// <returns>returns result string.</returns>
        public string CreateEmployee(Employee employee)
        {
            string result = "";
            try
            {
                SqlCommand cmd = new SqlCommand("USP_CRUDOperations_Employee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", 0);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                cmd.Parameters.AddWithValue("@ConfirmPassword", employee.ConfirmPassword);
                cmd.Parameters.AddWithValue("@EmailID", employee.EmailID);
                cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
                cmd.Parameters.AddWithValue("@SecurityQuestion", employee.SecurityQuestion);
                cmd.Parameters.AddWithValue("@Answer", employee.Answer);
                cmd.Parameters.AddWithValue("@Operation", "Create");
                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while(sqlDataReader.Read())
                    {
                        result = sqlDataReader["Result"].ToString();
                    }
                }

                return result;
            }
            catch(Exception ex)
            {
                return result = "Error in Inserting Employee Record!";
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
