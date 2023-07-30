using BlogsWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace BlogsWebApplication.Data_Layer
{
    public class DataLayer
    {
        string _connectionString = "";

        public DataLayer()
        {
            _connectionString = WebConfigurationManager.ConnectionStrings["BlogDB"].ConnectionString;
        }

        public DataTable GetAllPostsinDB()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("GetAllPosts", con);
                    command.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    con.Close();
                }
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in GetPostwithComments due to "
                   + exception.Message, exception.InnerException);
            }
        }

        public DataTable GetPostwithCommentsinDB(Posts post)
        {
            try
            {
                List<Comments> comments = new List<Comments>();
                DataTable dataTable = new DataTable();
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("GetPostwithComments", con);
                    command.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    con.Close();
                }
                return dataTable;
            }
            catch(Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in GetPostwithComments due to "
                   + exception.Message, exception.InnerException);
            }
        }

        public DataTable GetPostsbyUserinDB(Users user)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("GetPostsbyUser", con);
                    command.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    con.Close();
                }
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in GetPostwithComments due to "
                   + exception.Message, exception.InnerException);
            }
        }

        public DataTable GetPostsbyCategoryinDB(Posts post)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("GetPostsbyCategory", con);
                    command.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    con.Close();
                }
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in GetPostwithComments due to "
                   + exception.Message, exception.InnerException);
            }
        }



        public string InsertUserinDB(Users users)
        {
            try
            {
                string response = "";
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("InsertUser", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstName", users.firstName);
                    command.Parameters.AddWithValue("@lastName", users.lastName);
                    command.Parameters.AddWithValue("@Email", users.Email);

                    command.Parameters.Add("@PKID", SqlDbType.Int, 32);
                    command.Parameters["@PKID"].Direction = ParameterDirection.Output;

                    con.Open();
                    command.ExecuteNonQuery();

                    response = Convert.ToString(command.Parameters["@PKID"].Value);
                    con.Close();
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in InsertStudentInDB due to "
                   + exception.Message, exception.InnerException);
            }
        }

        public string InsertPostinDB(Posts post)
        {
            try
            {
                string response = "";
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("InsertPostwithCategory", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Post", post.Post);
                    command.Parameters.AddWithValue("@Category", post.Category);

                    command.Parameters.Add("@PKPId", SqlDbType.Int, 32);
                    command.Parameters["@PKPId"].Direction = ParameterDirection.Output;

                    con.Open();
                    command.ExecuteNonQuery();

                    response = Convert.ToString(command.Parameters["@PKPId"].Value);
                    con.Close();
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in InsertStudentInDB due to "
                   + exception.Message, exception.InnerException);
            }
        }

        public string InsertCommentinDB(Comments comment)
        {
            try
            {
                string response = "";
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("InsertComment", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Comment", comment.Comment);

                    command.Parameters.Add("@PKPId", SqlDbType.Int, 32);
                    command.Parameters["@PKPId"].Direction = ParameterDirection.Output;

                    con.Open();
                    command.ExecuteNonQuery();

                    response = Convert.ToString(command.Parameters["@PKPId"].Value);
                    con.Close();
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in InsertStudentInDB due to "
                   + exception.Message, exception.InnerException);
            }
        }



        public string DeleteUserinDB(Users users)
        {
            try
            {
                string response = "";
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("DeleteUser", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", users.firstName);

                    command.Parameters.Add("@PKID", SqlDbType.Int, 32);
                    command.Parameters["@PKID"].Direction = ParameterDirection.Output;

                    con.Open();
                    command.ExecuteNonQuery();

                    response = Convert.ToString(command.Parameters["@PKID"].Value);
                    con.Close();
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in InsertStudentInDB due to "
                   + exception.Message, exception.InnerException);
            }
        }

        public string DeletePostinDB(Posts post)
        {
            try
            {
                string response = "";
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("DeletePost", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PId", post.PostId);

                    command.Parameters.Add("@PKID", SqlDbType.Int, 32);
                    command.Parameters["@PKID"].Direction = ParameterDirection.Output;

                    con.Open();
                    command.ExecuteNonQuery();

                    response = Convert.ToString(command.Parameters["@PKID"].Value);
                    con.Close();
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in InsertStudentInDB due to "
                   + exception.Message, exception.InnerException);
            }
        }

        public string DeleteCommentinDB(Comments comment)
        {
            try
            {
                string response = "";
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("DeleteComment", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", comment.Id);
                    command.Parameters.AddWithValue("@PId", comment.PostId);

                    command.Parameters.Add("@PKID", SqlDbType.Int, 32);
                    command.Parameters["@PKID"].Direction = ParameterDirection.Output;

                    con.Open();
                    command.ExecuteNonQuery();

                    response = Convert.ToString(command.Parameters["@PKID"].Value);
                    con.Close();
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in InsertStudentInDB due to "
                   + exception.Message, exception.InnerException);
            }
        }
    }

}
