using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApp.Models.Sections;
using WebApp.Models.Views;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel
        {
            Title = "Ultimate Management Assisatant",
            Showcase = new ShowcaseViewModel
            {
                Id = "showcase",
                ShowcaseImage = new() { ImageUrl = "images/showcase-taskmaster.svg", AltText="Silicons task management assistant called 'Task Master'."},
                Title = "Task Management Assistant You Gonna Love",
                Text = "We offer you a new generation of task management system. Plan, manage & trackl all your tasks in one flexible tool",
                Link = new() { ControllerName= "Downloads", ActionName = "Index", Text ="Get started for free" },
                BrandsText = "Largest companies use our tool to work efficiently",
                Brands = 
                [
                    new() { ImageUrl = "images/brands/brand_1.svg", AltText = "Brand Name 1" },
                    new() { ImageUrl = "images/brands/brand_2.svg", AltText = "Brand Name 2" },
                    new() { ImageUrl = "images/brands/brand_3.svg", AltText = "Brand Name 3" },
                    new() { ImageUrl = "images/brands/brand_4.svg", AltText = "Brand Name 4" }
                ]

            },

            Features = new FeaturesViewModel
            {
                Id = "features",
                Title = "What Do You Get with Our Tool?",
                Text = "Make sure all your tasks are organized so you can set the priorities and focus on important.",
                Features =
                [
                    new() { ImageUrl = "images/icons/chat.svg", AltText = "Chat Symbol", Title = "Comments on Tasks", Text = "Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
                    new() { ImageUrl = "images/icons/presentation.svg", AltText = "Presentation Symbol", Title = "Task Analytics", Text = "Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate." },
                    new() { ImageUrl = "images/icons/add-group.svg", AltText = "Add to group Symbol", Title = "Multiple Assignees", Text = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris." },
                    new() { ImageUrl = "images/icons/bell.svg", AltText = "Bell Symbol", Title = "Notifications", Text = "Diam, suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra." },
                    new() { ImageUrl = "images/icons/test.svg", AltText = "Test Symbol", Title = "Sections & Subtasks", Text = "Mi feugiat hac id in. Sit elit placerat lacus nibh lorem ridiculus lectus." },
                    new() { ImageUrl = "images/icons/shield.svg", AltText = "Shield Symbol", Title = "Data Security", Text = "Aliquam malesuada neque eget elit nulla vestibulum nunc cras." },
                ]
            }
        //ViewData["Title"] = viewModel.Title;
        };

        return View(viewModel);
    }
}
