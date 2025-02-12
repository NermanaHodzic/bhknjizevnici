using bhknjizevniciapp.Models;

namespace bhknjizevniciapp.Services
{
    public class AuthorService
    {
        static AuthorService _instance;

        public static AuthorService Instance
        {
            get
            {
                _instance ??= new AuthorService();

                return _instance;
            }
        }



        public Author Author1 = new Author
        {
            Name = "Abdulah Sidran",
            Image = "abdulah_sidran.jpg",
            Color = Color.FromArgb("#000000"),

        };

        public Author Author2 = new Author
        {
            Name = "Aleksandar Hemon",
            Image = "aleksandar_hemon.jpg",
            Color = Color.FromArgb("#000000"),


        };

        public Author Author3 = new Author
        {
            Name = "Bisera Alikadić",
            Image = "bisera_alikadic.png",
            Color = Color.FromArgb("#000000")
        };
        public Author Author4 = new Author
        {
            Name = "Dževad Karahasan",
            Image = "dzevad_karahasan.jpg",
            Color = Color.FromArgb("#000000"),

        };

        public Author Author5 = new Author
        {
            Name = "Ivo Andrić",
            Image = "ivo_andric.jpg",
            Color = Color.FromArgb("#000000"),

        };

        public Author Author6 = new Author
        {
            Name = "Mak Dizdar",
            Image = "mak_dizdar.png",
            Color = Color.FromArgb("#000000"),



        };

        public Author Author7 = new Author
        {
            Name = "Meša Selimović",
            Image = "mesa_selimovic.jpg",
            Color = Color.FromArgb("000000"),

        };

        public Author Author8 = new Author

        {
            Name = "Miljenko Jergovic",
            Image = "miljenko_jergovic.jpg",
            Color = Color.FromArgb("#000000"),

        };

        public Author Author9 = new Author
        {
            Name = "Musa Ćazim Ćatić",
            Image = "musa_cazim_catic.jpg",
            Color = Color.FromArgb("#000000"),

        };
        public Author Author10 = new Author
        {
            Name = "Zlata Filipović",
            Image = "zlata_filipovic.png",
            Color = Color.FromArgb("#000000"),

        };

        public List<Author> GetAuthors()
        {
            return new List<Author>
            {
                Author1, Author2, Author3, Author4, Author5, Author6, Author7, Author8, Author9, Author10
            };
        }
    }
}