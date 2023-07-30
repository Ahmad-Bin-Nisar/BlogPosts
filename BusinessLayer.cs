using System;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Data;
using BlogsWebApplication.Data_Layer;
using BlogsWebApplication.Models;

namespace BlogsWebApplication.Business_Layer
{
    public class BusinessLayer
    {
        public class BL
        {
            public DataLayer dataLayer = new DataLayer();

            public string GetAllPosts()
            {
                try
                {
                    string response = dataLayer.GetAllPostsinDB().ToString();
                    return response;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }
            public string InsertUser(Users user)
            {
                try
                {
                    string response = dataLayer.InsertUserinDB(user);
                    return response;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }

            public string InsertPost(Posts post)
            {
                try
                {
                    string response = dataLayer.InsertPostinDB(post);
                    return response;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }

            public string InsertComment(Comments comment)
            {
                try
                {
                    string response = dataLayer.InsertCommentinDB(comment);
                    return response;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }

            public string GetPostwithComments(Posts post)
            {
                try
                {
                    List<Comments> comments = new List<Comments>();
                    comments = dataLayer.GetPostwithCommentsinDB(post);
                    return comments;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }

            public string GetPostsbyUser(Users user)
            {
                try
                {
                    string response = dataLayer.GetPostsbyUserinDB(user).ToString();
                    return response;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }

            public string GetPostsbyCategory(Posts post)
            {
                try
                {
                    string response = dataLayer.GetPostsbyCategoryinDB(post).ToString();
                    return response;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }

            public string DeleteUser(Users user)
            {
                try
                {
                    string response = dataLayer.DeleteUserinDB(user);
                    return response;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }

            public string DeletePost(Posts post)
            {
                try
                {
                    string response = dataLayer.DeletePostinDB(post);
                    return response;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }

            public string DeleteComment(Comments comment)
            {
                try
                {
                    string response = dataLayer.DeleteCommentinDB(comment);
                    return response;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in InsertStudent due to "
                       + exception.Message, exception.InnerException);
                }
            }

        }
    }
}
