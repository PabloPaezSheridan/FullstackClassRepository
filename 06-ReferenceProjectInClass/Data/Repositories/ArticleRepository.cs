
using System.Reflection.PortableExecutable;

namespace Data.Repositories{
    public class ArticleRepository
    {
        // public List<Article> Articles;
        private readonly ApplicationContext _context;
        public ArticleRepository( ApplicationContext context)
        {
            _context = context;
            // Articles = new List<Article>() 
            // {
            //     new Article(){Id=1, Content="content1fsdfsdfsdfsdfsdf", Summary="this is a summary of the content1", Title="First Article"},
            //     new Article(){Id=2, Content="content2fsdfsdfsdfsdfsdf", Summary="this is a summary of the content2", Title="Second Article"},
            //     new Article(){Id=3, Content="content3fsdfsdfsdfsdfsdf", Summary="this is a summary of the content3", Title="Third Article"},
            //     new Article(){Id=4, Content="content4fsdfsdfsdfsdfsdf", Summary="this is a summary of the content4", Title="Fourth Article"}
            // };

        }

        public int AddArticle(Article newArticle)
        {
            _context.Articles.Add(newArticle);
            _context.SaveChanges();
            return newArticle.Id;
        }

        public List<Article> GetAll()
        {
            return _context.Articles.Where(a => a.State == "Active").ToList();
        }

        public Article? Get(int Id)
        {
            return _context.Articles.Where(a => a.State == "Active").FirstOrDefault(a => a.Id == Id);
        }

        public bool Delete(int id)
        {
            var articleToDelete = _context.Articles.FirstOrDefault(a => a.Id == id);
            if(articleToDelete is not null)
            {
                articleToDelete.State = "Deleted";
                _context.Articles.Update(articleToDelete);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
