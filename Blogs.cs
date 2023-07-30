using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogsWebApplication.Models
{
    public class Users
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
    }
    public class Posts
    {
        public int PostId { get; set; }
        public string Post { get; set; }
        public string Category { get; set; }
    }

    public class Comments
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Comment { get; set; }
    }
}