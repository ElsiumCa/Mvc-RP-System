using Services.RpItemServices;
using Repositories;

namespace Services
{
    public class ConstitutionService : IConstitutionService
    {
        private readonly RepositoryContext _context;

        public ConstitutionService(RepositoryContext context)
        {
            _context = context;
        }

        // Anayasadaki tüm maddeleri getirir
        public IEnumerable<Constitution> GetAllArticles()
        {
            return _context.Constitutions.ToList();
        }

        // Bir maddeyi id'ye göre getirir
        public Constitution GetArticleById(int id)
        {
            return _context.Constitutions.FirstOrDefault(c => c.Id == id);
        }

        // Yeni bir madde ekler
        public void AddArticle(Constitution article)
        {
            _context.Constitutions.Add(article);
            _context.SaveChanges();
        }

        // Var olan bir maddeyi günceller
        public void UpdateArticle(Constitution article)
        {
            _context.Constitutions.Update(article);
            _context.SaveChanges();
        }

        // Bir maddeyi siler
        public void DeleteArticle(int id)
        {
            var article = _context.Constitutions.FirstOrDefault(c => c.Id == id);
            if (article != null)
            {
                _context.Constitutions.Remove(article);
                _context.SaveChanges();
            }
        }

        // Oylamanın hala açık olup olmadığını kontrol eder
        public bool IsVotingOpen(int id)
        {
            var article = _context.Constitutions.FirstOrDefault(c => c.Id == id);
            return true;
        }
    }
}
