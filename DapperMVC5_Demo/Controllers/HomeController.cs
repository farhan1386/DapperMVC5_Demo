using Dapper;
using DapperMVC5_Demo.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace DapperMVC5_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Employees> employees = new List<Employees>();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {

                employees = db.Query<Employees>("Select * From Employees").ToList();
            }
            return View(employees);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}