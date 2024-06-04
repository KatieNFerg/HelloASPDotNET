using Microsoft.AspNetCore.Mvc;
using HelloASPDotNET1.Models;
using System.Diagnostics;

namespace HelloASPDotNET1.Controllers;

public class HelloController : Controller
{
    [HttpGet]
 //   [Route("/hello")]
        public IActionResult Index()
        {
            string html = "<form method='post'>" + "<input type='text' name='name' />" +
                "<select name='language'><option value='english' selected>English</option>" +
                "<option value='spanish'>Spanish</spanish>" +
                "<option value='bosnian'>Bosnian</option>" +
                "<option value='vietnamese'>Vietnamese</option>" +
                "<option value='french'>French</option></select>" +
                "<input type='submit' value='Greet Me!'/>" +
                "</form>";

            return Content(html, "text/html");

        }
        [HttpPost]
       // [Route("/hello/welcome/{name?}")]
           public static string CreateMessage(string name, string language)
     {
         string helloTranslation = "";
         switch (language)
         {
             case "french":
                 helloTranslation = "Bonjour ";
                 break;
             case "spanish":
                 helloTranslation = "Hola ";
                 break;
             case "bosnian":
                 helloTranslation = "Zdravo ";
                 break;
             case "vietnamese":
                 helloTranslation = "Xin Chao ";
                 break;
             case "english":
                 helloTranslation = "Hello ";
                 break;
         }
         return helloTranslation + name;

     }

}
