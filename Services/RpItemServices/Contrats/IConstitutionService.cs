using Entities;
using Entities.RpItems;

namespace Services.RpItemServices
{
    public interface IConstitutionService
    {
        IQueryable<Constitution> GetAllArticlesAsync();
        void AddArticle(Constitution article);
        void UpdateArticle(Constitution article);
        void DeleteArticle(int id);
        bool IsVotingOpen(int id);
    }
}
