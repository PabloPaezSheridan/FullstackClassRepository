using System.Text.Json.Serialization;

class ArticleToReturn
{
    public string Title {get; set;}
    public string Summary {get; set;}
    public string Content {get; set;}
    public DateTime Date {get;set;}
    public string? ImagePath {get;set;}
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ExperienceSkillEnum Skill {get; set;}
}