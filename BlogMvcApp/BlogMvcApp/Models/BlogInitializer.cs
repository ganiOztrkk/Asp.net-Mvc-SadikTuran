using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { CategoryName ="C#"},
                new Category() { CategoryName ="Asp.Net MVC"},
                new Category() { CategoryName ="Asp.Net WebForm"},
                new Category() { CategoryName ="Windows Form"},
                new Category() { CategoryName =".Net Core"}
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
                new Blog() {Title = "C# Delegates hakkındaC# Delegates hakkındaC# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "1.jpg", PublishDate = DateTime.Now.AddDays(-10), Status = true, Homepage = true, CategoryId = 1},
                new Blog() {Title = "C# Generic List Hakkında", Description = "C# Delegates hakkında", Content = "C# Generic List Hakkında C# Generic List Hakkında", Image = "2.jpg", PublishDate = DateTime.Now.AddDays(-15), Status = true, Homepage = false, CategoryId = 1},
                new Blog() {Title = "C# Inheritance Hakkında", Description = "C# Delegates hakkında", Content = "C# Inheritance Hakkında C# Inheritance Hakkında", Image = "3.jpg", PublishDate = DateTime.Now.AddDays(-20), Status = false, Homepage = false, CategoryId = 1},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "4.jpg", PublishDate = DateTime.Now.AddDays(-10), Status = true, Homepage = true, CategoryId = 2},
                new Blog() {Title = "C# Delegates hakkındaC# Delegates hakkındaC# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "5.jpg", PublishDate = DateTime.Now.AddDays(-13), Status = true, Homepage = true, CategoryId = 2},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "3.jpg", PublishDate = DateTime.Now.AddDays(-20), Status = true, Homepage = true, CategoryId = 3},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "4.jpg", PublishDate = DateTime.Now.AddDays(-10), Status = true, Homepage = true, CategoryId = 3},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "1.jpg", PublishDate = DateTime.Now.AddDays(-11), Status = true, Homepage = false, CategoryId = 4},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "1.jpg", PublishDate = DateTime.Now.AddDays(-10), Status = true, Homepage = true, CategoryId = 4},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "3.jpg", PublishDate = DateTime.Now.AddDays(-10), Status = true, Homepage = true, CategoryId = 4},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "5.jpg", PublishDate = DateTime.Now.AddDays(-13), Status = false, Homepage = false, CategoryId = 4},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "5.jpg", PublishDate = DateTime.Now.AddDays(-22), Status = true, Homepage = true, CategoryId = 5},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "3.jpg", PublishDate = DateTime.Now.AddDays(-5), Status = true, Homepage = true, CategoryId = 5},
                new Blog() {Title = "C# Delegates hakkında", Description = "C# Delegates hakkında", Content = "C# Delegates hakkında C# Delegates hakkında", Image = "2.jpg", PublishDate = DateTime.Now.AddDays(-16), Status = true, Homepage = false, CategoryId = 5},
            };

            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}