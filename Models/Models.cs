using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace VendorList.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCountry { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public int AreaCode { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public string Notes { get; set; }
        public string FullName
        {
            get
            {
                return CompanyCountry + ",";
            }
        }
        public string Phone
        {
            get
            {
                return "(" + PhoneNumber + ")";
            }
        }
        public string House
        {
            get
            {
                return State +",";
            }
        }
        public string Code
        {
            get
            {
                return AreaCode + ",";
            }
        }
        public string Noted
        {
            get
            {
                return "Note: " + Notes;
            }
        }




        public List<Post> Posts { get; set; }
    }



    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
