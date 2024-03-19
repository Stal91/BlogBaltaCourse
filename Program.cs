using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;


using (var context = new BlogDataContext())
{
    // var user = new User
    // {
    //     Name = "Pedro Henrique",
    //     Slug = "pedrohenrique",
    //     Email = "pedro@stal.com",
    //     Bio = "Estudante em busca de um estagio",
    //     Image = "https://eu.com",
    //     PasswordHash = "1234432101"
    // };

    // var category = new Category
    // {
    //     Name = "Backend",
    //     Slug = "backend"
    // };

    // var post = new Post
    // {
    //     Author = user,
    //     Category = category,
    //     Body = "<p>Hello world</p>",
    //     Slug = "comecando-com-ef-core",
    //     Summary = "Neste artigo vamos aprender EF core",
    //     Title = "Começando com EF Core",
    //     CreateDate = DateTime.Now,
    //     LastUpdateDate = DateTime.Now,
    // };

    // context.Posts.Add(post);
    // context.SaveChanges();

    var posts = context
    .Posts
    // .AsNoTracking() // fisrt
    .Include(x => x.Author)
    .Include(x => x.Category)
    // .Where(x => x.AuthorId == 6) // second
    .OrderByDescending(x => x.LastUpdateDate) // third
    .ToList();
    // .ToList(); //always last one

    // post.Author.Name = "Test";

    // context.Posts.Update(post);
    // context.SaveChanges();

    // foreach (var post in posts)
    // {
    //     Console.WriteLine(post.Author.Name + post.Title);
    // }
}