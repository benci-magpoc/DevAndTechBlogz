using DevAndTechBlogz.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevAndTechBlogz.Data
{
    public class ApplicationDbContext : IdentityDbContext<BlogUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; } = default!;
        public DbSet<BlogPostComment> BlogPostComments { get; set; } = default!;
    }
}