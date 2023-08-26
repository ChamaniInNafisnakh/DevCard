using System.ComponentModel;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc;



namespace DevCard_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			List<Project> projects = new List<Project>()
			{
				new Project()
				{
					Author = "Client: Google",
					Description = "Project intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes."
					,Title = "test1"
					, Img = "project-1.jpg"
				},
				new Project()
				{
					Author = "Client: android",
					Description = "Project intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes."
					,Title = "test2"
					, Img = "project-2.jpg"
				},
				new Project()
				{
					Author = "Client: apple",
					Description = "Project intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes."
					,Title = "test3"
					, Img = "project-3.jpg"
				},
				new Project()
				{
					Author = "Client: mozila",
					Description = "Project intro lorem ipsum dolor sit amet, consectetuer\r\n\t\t\t\t\t\t\t\t\tadipiscing elit. Cum sociis natoque penatibus et magnis dis parturient\r\n\t\t\t\t\t\t\t\t\tmontes."
					,Title = "test4"
					, Img = "project-4.jpg"
				}
			};
			return View("_Project",projects);
		}
	}
}
