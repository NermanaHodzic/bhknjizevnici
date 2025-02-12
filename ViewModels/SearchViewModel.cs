using bhknjizevniciapp.Models;

namespace bhknjizevniciapp.Views
{
    internal class SearchViewModel
    {
        public SearchViewModel()
        {
        }
        private List<Author> listaKnjizevnika;
        public List<Author> PretraziKnjizevnike(string pretrazenoIme)
        {
            return listaKnjizevnika
                .Where(k => k.Name.Contains(pretrazenoIme, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

    }
}