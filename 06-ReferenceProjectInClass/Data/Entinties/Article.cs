using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Article
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [MaxLength(70)]
    public string Title {get; set;}
    [MaxLength(230)]
    public string Summary {get; set;}
    public string Content {get; set;}
    public DateTime Date {get;set;}
    public string? ImagePath {get;set;}
    public string State {get; set;} = "Active";
    public ExperienceSkillEnum Skill {get; set;} = ExperienceSkillEnum.Managment;
}