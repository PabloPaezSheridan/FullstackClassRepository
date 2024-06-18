using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore;

[ApiController]
[Route("api/Article")]
public class ArticleController : ControllerBase
{
    private  readonly ArticleRepository _repo;
    public ArticleController(ArticleRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("{idArticle}")]
    public ActionResult Get(int idArticle)
    {
        var articleToReturn = _repo.Get(idArticle);
        return Ok(articleToReturn);
    }

    [HttpGet]
    public ActionResult Get()
    {
        var articles = _repo.GetAll();
        List<ArticleToReturn> articleToReturn = new();
        foreach( var a in articles){
            articleToReturn.Add(new ArticleToReturn(){
                Content = a.Content,
                Date = a.Date,
                ImagePath = a.ImagePath,
                Skill = a.Skill,
                Summary = a.Summary,
                Title = a.Title
            });
        };
        return Ok(articleToReturn);
    }

    [HttpPost]
    public ActionResult AddArticle([FromBody] ArticleToAdd body)
    {
        var newArticle = new Article()
        {
            Content = body.Content,
            Date = DateTime.UtcNow,
            ImagePath = body.ImagePath,
            Summary = body.Summary,
            Title = body.Title,
            Skill = body.Skill
        }; 
        return Ok(_repo.AddArticle(newArticle));
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteArticle(int id)
    {
        return Ok(_repo.Delete(id));
    }

    [HttpPut("{id}")]
    public ActionResult UpdateArticle(int id, [FromBody] ArticleToUpdate body)
    {
        var articleToReturn = DemoArticles.Articles.First(a => a.Id == id);
        articleToReturn.Content = body.Content;
        articleToReturn.Summary = body.Summary;
        articleToReturn.ImagePath = body.ImagePath;
        articleToReturn.Skill = body.Skill;
        _repo.AddArticle(articleToReturn);
        return Ok();
    }

    [HttpGet("search")]
    public ActionResult GetByTitleOrSummary([FromQuery]string searchCriteria)
    {
        return Ok(_repo.GetAll().Where(a => a.Summary.Contains(searchCriteria) || a.Title.Contains(searchCriteria)).ToList());
    }

    

}