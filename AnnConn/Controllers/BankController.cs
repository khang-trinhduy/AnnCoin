using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AnnConn.Controllers
{
    public class BankController : Controller
    {

        public IActionResult Home()
        {
            return View("Home");
        }

        public IActionResult Index()
        {
            return View("Form_1");
        }
        public IActionResult _Index()
        {
            return View("_Form_1");
        }

        public IActionResult Result()
        {
            return View("Processing");
        }

        public IActionResult _Result()
        {
            return View("_Processing");
        }

        public IActionResult Res()
        {
            return View("Result");
        }

        public IActionResult _Res()
        {
            return View("_Result");
        }

        public IActionResult TCB()
        {
            return View("Form_2");
        }

        public IActionResult _TCB()
        {
            return View("_Form_2");
        }

        public IActionResult _VCB()
        {
            return View();
        }

        public IActionResult _final_result()
        {
            return View("_Preprocessing");
        }

        public IActionResult final_result()
        {
            return View("Preprocessing");
        }

        public IActionResult final_res()
        {
            return View("Final_Result");
        }

        public IActionResult _final_res()
        {
            return View("_Final_Result");
        }
    }
}