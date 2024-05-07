using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Article")]
public class ArticleController : ControllerBase
{
    [HttpGet("{idArticle}")]
    public IActionResult Get(int idArticle)
    {
        var articleToReturn = DemoArticles.Articles.Where(a => a.Id == idArticle);
        return Ok(articleToReturn);
    }

}