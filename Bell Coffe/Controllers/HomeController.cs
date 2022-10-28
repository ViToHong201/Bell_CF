using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bell_Coffe.Models;


namespace Bell_Coffe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string json_product = System.IO.File.ReadAllText(Server.MapPath("~/Data/product.json"));
            List<Product> ls_product = JsonConvert.DeserializeObject<List<Product>>(json_product);
            ViewData.Add("product", ls_product);

            string json_story = System.IO.File.ReadAllText(Server.MapPath("~/Data/story.json"));
            List<Story> ls_story = JsonConvert.DeserializeObject<List<Story>>(json_story);
            ViewData.Add("story", ls_story);

            string json_customer = System.IO.File.ReadAllText(Server.MapPath("~/Data/Customer.json"));
            List<Customer> ls_customer= JsonConvert.DeserializeObject<List<Customer>>(json_customer);
            ViewData.Add("customer", ls_customer);

            return View();
        }




        
    }
}