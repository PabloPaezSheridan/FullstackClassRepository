using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Article")]
public class ArticleController : ControllerBase
{
    [HttpGet("{idArticle}")]
    public ActionResult Get(int idArticle)
    {
        var articleToReturn = DemoArticles.Articles.Where(a => a.Id == idArticle);
        return Ok(articleToReturn);
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(DemoArticles.Articles.ToList());
    }

    [HttpPost]
    public ActionResult AddArticle([FromBody] ArticleToAdd body)
    {
        Article article = new()
        {
            Content = body.Content,
            Date = DateTime.UtcNow,
            ImagePath = body.ImagePath,
            Summary = body.Summary,
            Title = body.Title
        };
        DemoArticles.Articles.Add(article);
        return Ok(article.Id);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteArticle(int id)
    {
        var articleToReturn = DemoArticles.Articles.First(a => a.Id == id);
        DemoArticles.Articles.Remove(articleToReturn);
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult UpdateArticle(int id, [FromBody] ArticleToUpdate body)
    {
        var articleToReturn = DemoArticles.Articles.First(a => a.Id == id);
        articleToReturn.Content = body.Content;
        articleToReturn.Summary = body.Summary;
        articleToReturn.ImagePath = body.ImagePath;
        DemoArticles.Articles.Add(articleToReturn);
        return Ok();
    }
}