using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "Essa é uma ação default...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Olá, {name}! ID: {ID}");
        }
    }
}