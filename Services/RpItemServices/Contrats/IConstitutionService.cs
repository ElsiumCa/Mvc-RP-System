using Entities;

namespace Services.RpItemServices
{
    public interface IConstitutionService
    {
        IEnumerable<Constitution> GetAllArticles();
        Constitution GetArticleById(int id);
        void AddArticle(Constitution article);
        void UpdateArticle(Constitution article);
        void DeleteArticle(int id);
        bool IsVotingOpen(int id);
    }
}
