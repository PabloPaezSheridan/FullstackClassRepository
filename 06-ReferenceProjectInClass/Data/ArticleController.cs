using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Article")]
public class ArticleController : ControllerBase
{
    private  readonly ArticleRepository _repo;
    public ArticleController(ArticleRepository pepe)
    {
        _repo = pepe;
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
        return Ok(_repo.GetAll());
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
            Title = body.Title
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
        _repo.AddArticle(articleToReturn);
        return Ok();
    }

    //Devolver los articulos que tengan coincidencia parcial por titulo o resumen
    [HttpGet]
}