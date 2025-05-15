using Entities;
using Entities.RpItems;

namespace Services.RpItemServices
{
    public interface IConstitutionService
    {
        IQueryable<Constitution> GetAllArticles();
        void AddArticle(Constitution article);
        void UpdateArticle(Constitution article);
        void DeleteArticle(int id);
        bool IsVotingOpen(int id);
    }
}
