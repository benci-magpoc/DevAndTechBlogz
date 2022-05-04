using Microsoft.Build.Framework;

namespace DevAndTechBlogz.Models
{
    public class BlogPostComment
    {
        public int Id { get; set; }
        public int BlogPostId { get; set; }
        [Required] public string Comment { get; set; } = "";
        //Navigational Properties
        public virtual BlogPost BlogPost { get; set; } = default!;
    }
}
