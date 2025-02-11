using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiniBlog.Model;

namespace MiniBlog.Repositories
{
    public interface IArticleRepository
    {
        public Task<List<Article>> GetArticles();
        public Task<Article> CreateArticle(Article article);

        public Task<Article> FindArticleByTitle(string title);

        public Task<Article> FindArticleById(Guid id);
    }
}
