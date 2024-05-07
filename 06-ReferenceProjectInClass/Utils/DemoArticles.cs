public static class DemoArticles
{
    public static List<Article> Articles { get; set; } = new() 
    {
        new Article(){Id=1, Content="content1fsdfsdfsdfsdfsdf", Summary="this is a summary of the content1", Title="First Article"},
        new Article(){Id=2, Content="content2fsdfsdfsdfsdfsdf", Summary="this is a summary of the content2", Title="Second Article"},
        new Article(){Id=3, Content="content3fsdfsdfsdfsdfsdf", Summary="this is a summary of the content3", Title="Third Article"},
        new Article(){Id=4, Content="content4fsdfsdfsdfsdfsdf", Summary="this is a summary of the content4", Title="Fourth Article"}

    };    
}