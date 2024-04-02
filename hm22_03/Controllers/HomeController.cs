using hm22_03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hm22_03.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            HttpContext.Response.ContentType = "text/html charset=utf-8";
            string form = """
                <form method ="post" action="Home/Register">
                    <div class = "form-group">
                        <label for="userName" class="form-chack-label">Name:</label>
                        <input type="text" name="username" class="form-control" required>
                    </div>
                    <div class = "form-group">
                        <label for="email" class="form-chack-label">Email:</label>
                        <input type="email" name="email" class="form-control" required>
                    </div>
                    <div class = "form-group">
                        <label for="pass" class="form-chack-label">Password:</label>
                        <input type="password" name="pass" class="form-control" required>
                    </div>
                    <div class = " form-group mt-3">
                        <button type="submit" class="btn btn-primary">Register men!</button>
                    </div>
                </form>
                """;
            return Content(GetHtmlPage(form));
        }
        [HttpPost]
        public ActionResult Register(string username, string email, string pass) 
        {
            return Content($"Username: {username}, Email: {email}, Password{pass}");
        }
        private string GetHtmlPage(string body)
        {
            return $"""
                <!DOCTYPE html>
                <html lang="en">
                <head>
                    <meta charset="UTF-8">
                    <meta name="viewport" content="width = devise-width, initial-scale=1.0">
                    <link rel ="stylesheet" href="lib/bootstrap/dist/css/bootstrap.mon.css"/>
                    <title>Register</title>
                </head>
                <body>
                    <div class="container">
                        <main role="main" class="pb-3">
                        {body}
                        </main>
                    </div>
                    <footer class = "border-top footer text-muted">
                        <div class = "container">
                            &copy; 2024 - WebApllication1 - <a asp-area="" asp-controller="Hame" asp-action="Privacy">Privat</a>
                        </div>
                    </footer>

                    <script src="lib/jquery/dist/jquery.min.js"></script>
                    <script src="lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
                </body>
                </html>
                """;
        }
    }
}
