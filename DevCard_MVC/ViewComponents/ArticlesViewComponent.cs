using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Article> Articles = new List<Article>()
            {
                new Article()
                {
                    Author = "Client: Google",
                    Description =
                        "Article intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes.",
                    Title = "test1", Img = "blog-post-thumb-card-1.jpg"
                },
                new Article()
                {
                    Author = "Client: android",
                    Description =
                        "Article intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes.",
                    Title = "test2", Img = "blog-post-thumb-card-2.jpg"
                },
                new Article()
                {
                    Author = "Client: apple",
                    Description =
                        "Article intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes.",
                    Title = "test3", Img = "blog-post-thumb-card-3.jpg"
                },

            };
            return View("_Article", Articles);
        }
    }
}
