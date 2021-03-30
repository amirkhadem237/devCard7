using devCard7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace devCard7.viewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, "project-1.jpg", "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "khadem"),
                new Project(2, "project-2.jpg", "زودفود", "درخواست آنلاین غذا برای سراسر کشور", "zoodfood"),
                new Project(3, "project-3.jpg", "مدارس", "سیستم مدیریت یکپارچه مدارس", "monop"),
                new Project(4, "project-4.jpg", "فضاپیما", "برنامه مدیریت فضاپیما های ناسا", "nasa")

            };
            return View("_Project", projects);
        }
    }
}
