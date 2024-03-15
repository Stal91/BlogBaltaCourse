using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;


using (var context = new BlogDataContext())
{
    var user = new User
    {
        Name = "Pedro Henrique",
        Slug = "pedrohenrique",
        Email = "pedro@stal.com",
        Bio = "Estudante em busca de um estagio",
        Image = "https://eu.com",
        PasswordHash = "1234432101"
    };

    var category = new Category
    {
        Name = "Backend",
        Slug = "backend"
    };

    var post = new Post
    {
        Author = user,
        Category = category,
        Body = "<p>Hello world</p>",
        Slug = "comecando-com-ef-core",
        Summary = "Neste artigo vamos aprender EF core",
        Title = "Começando com EF Core",
        CreateDate = DateTime.Now,
        LastUpdateDate = DateTime.Now,
    };

    context.Posts.Add(post);
    context.SaveChanges();
}