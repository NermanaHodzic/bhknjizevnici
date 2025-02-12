
using bhknjizevniciapp.Models;

namespace bhknjizevniciapp.Services
{
    public class PostService
    {
        static PostService _instance;
      

        public static PostService Instance
        {
            get
            {
                _instance ??= new PostService();

                return _instance;
            }
        }
     

        public List<Post> GetPosts()
        {
            return new List<Post>
            {
                new Post { postId=1,Author = AuthorService.Instance.Author1, Image = "abdulah_sidran.png", AuthorPage="Abdulah_Sidran",Genres = new List<string> {"Poezija" , "Drama", "Romani" } },
                new Post {postId=2,Author = AuthorService.Instance.Author2,  Image = "aleksandar_hemon.jpg", AuthorPage="Aleksandar_Hemon", Genres = new List<string> { "Romani", "Prpovijetke","Drama" } },
                new Post {postId=3,Author = AuthorService.Instance.Author3,  Image = "bisera_alikadic.jpg",  AuthorPage="Bisera_Alikadic", Genres = new List<string> { "Poezija", "Romani","Novela" }  },
                 new Post {postId=4,Author = AuthorService.Instance.Author4,Image = "dzevad_karahasan.jpg", AuthorPage="Dževad_Karahasan", Genres = new List<string> { "Drama", "Romani","Esej" } },
                new Post {postId=5, Author = AuthorService.Instance.Author5, Image = "ivo_andric.jpg",  AuthorPage="Ivo_Andric", Genres = new List<string> { "Pripovijetke", "Romani" },},
                new Post { postId=6,Author= AuthorService.Instance.Author6,Image = "mak_dizdar.jpg", AuthorPage="Mak_Dizdar", Genres = new List<string> { "Poezija" }},
                new Post {postId=7, Author = AuthorService.Instance.Author7,Image = "mesa_selimovic.jpg", AuthorPage="Mesa_Selimovic",Genres = new List<string> { "Romani", "Psihologija" } },
                new Post { postId=8,Author = AuthorService.Instance.Author8, Image = "miljenko_jergovic.jpg",   AuthorPage="Miljenko_Jergovic", Genres = new List<string> { "Pripovijetke", "Romani","Poezija","Drama" } },
                new Post { postId=9,Author = AuthorService.Instance.Author9,Image = "musa_cazim_catic.jpg",  AuthorPage="Musa_Cazim_Catic", Genres = new List<string> { "Poezija" } },
                new Post { postId=10,Author = AuthorService.Instance.Author10, Image = "zlata_filipovic.jpg",  AuthorPage="Zlata_Filipovic", Genres = new List<string> { "Autobiografija"} } 
            };
        }
    }
}