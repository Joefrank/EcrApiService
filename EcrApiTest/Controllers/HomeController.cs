using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EcrApiTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            EcrApiService.TourAvailability service = new EcrApiService.TourAvailability();
            
            EcrApiService.Api client = new EcrApiService.Api();
            var tourlist = client.TourList("1q-psWDffplAr1fgJAX_HVfH36eCs3z9MqXeM-hWHao");
            var availability = client.Availability("1q-psWDffplAr1fgJAX_HVfH36eCs3z9MqXeM-hWHao", "01011", DateTime.Now.AddDays(-100), true, DateTime.Now.AddDays(100), true);



            return View();
        }

    }
}
