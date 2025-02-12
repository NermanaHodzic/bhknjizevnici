
namespace bhknjizevniciapp.Models
{
    public class Post
    {
        public int postId { get; set; }
        public Author Author { get; set; }
        public string Image { get; set; }
        public string AuthorPage { get; set; }
        public List<string> Genres { get; set; }
        
    }
}
