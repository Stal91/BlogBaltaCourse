using Blog.Data;
using Blog.Models;


using (var context = new BlogDataContext())
{
    var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
    context.Tags.Add(tag);
    context.SaveChanges();
}