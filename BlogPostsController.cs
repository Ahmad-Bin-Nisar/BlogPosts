using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlogsWebApplication.Business_Layer;    
using BlogsWebApplication.Models;
using static BlogsWebApplication.Business_Layer.BusinessLayer;

namespace BlogsWebApplication.Controllers
{
    public class BlogPostsController : ApiController
    {
        public BL dataLayer = new BL();

        //[HttpGet]
        //[Route("GetListOfStudents")]
        //public List<Students> GetListOfBootCampStudents()
        //{
        //    try
        //    {
        //        List<Students> students = new List<Students>();
        //        students = dataLayer.GetListOfStudents();
        //        return students;
        //    }
        //    catch (Exception exception)
        //    {
        //        throw new Exception("An exception of type " + exception.GetType().ToString()
        //           + " is encountered in GetListOfStudents due to "
        //           + exception.Message, exception.In nerException);
        //    }
        //}


        [HttpPost]
        [Route("InsertStudent")]
        public string InsertStudent([FromBody] Users user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string resposne = dataLayer.InsertUser(user);
                    if (!string.IsNullOrEmpty(resposne))
                    {
                        return "User Added Successfully!";
                    }
                    else
                    {
                        return "User Not Added Successfully!";
                    }
                }
                else
                {
                    return "Model Is Not Valid";
                }
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in InsertStudent due to "
                   + exception.Message, exception.InnerException);
            }
        }

        [HttpPost]
        [Route("InsertStudent")]
        public string fetchusers()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string resposne = dataLayer.GetAllPosts();
                    if (!string.IsNullOrEmpty(resposne))
                    {
                        return "User Added Successfully!";
                    }
                    else
                    {
                        return "User Not Added Successfully!";
                    }
                }
                else
                {
                    return "Model Is Not Valid";
                }
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
