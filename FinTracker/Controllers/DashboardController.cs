using FincTracker.Lib;
using FincTracker.Lib.Serivces;
using FinTracker.Dal.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinTracker.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IDataProtector _protector;
        private readonly DashboardSerivce _dashboardservice;
        public DashboardController(IDataProtectionProvider provider, DashboardSerivce dashboardSerivce)
        {
            _protector = provider.CreateProtector("EmployeesApp.EmployeesController");
            _dashboardservice = dashboardSerivce;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Narration()
        {
            return View();
        }
        public IActionResult Expense()
        {
            return View();
        }
        public JsonResult AddExpenseToDb(string data)
        {
            try
            {
                if (data != null)
                {
                    Expense expense = JsonConvert.DeserializeObject<Expense>(data);
                    var userid = Convert.ToInt32(HttpContext.Session.GetString(ApplicationConstants.UserRefId));
                    expense.UserRefId = userid;
                    var success = _dashboardservice.AddExpense(expense);
                    return Json(success);

                }
                else
                {
                    return Json(false);
                }
            }
            catch(Exception ex)
            {
                return Json(false);
            }
        }
        [HttpPost]
        public async Task<JsonResult> AddNarrationAsync(string data)
        {
            try
            {
                Debit narration = JsonConvert.DeserializeObject<Debit>(data);
                var userid = Convert.ToInt32(HttpContext.Session.GetString(ApplicationConstants.UserRefId));
                narration.UserRefId = userid;
                var success = await _dashboardservice.AddNarration(narration);
                return  Json(success);
            }
            catch(Exception ex)
            {
                return Json(false);
            }
        }
        public IActionResult ManageNarration()
        {
            return View();
        }
        public JsonResult GetNarration()
        {
            var user = Convert.ToInt32(HttpContext.Session.GetString(ApplicationConstants.UserRefId));
            var result = _dashboardservice.GetNarration(user);
            return Json(result);
        }
        public JsonResult GetEmi(int num)
        {
            var user = Convert.ToInt32(HttpContext.Session.GetString(ApplicationConstants.UserRefId));
            var result = _dashboardservice.GetEmi(user, num);
            return Json(result);
        }
        public JsonResult GetDashData()
        {
            var user = Convert.ToInt32(HttpContext.Session.GetString(ApplicationConstants.UserRefId));
            var result = _dashboardservice.GetDashData(user);
            return Json(result);
        }
        public JsonResult DeleteNarration(int id)
        {
            var user =  Convert.ToInt32(HttpContext.Session.GetString(ApplicationConstants.UserRefId));
           var result = _dashboardservice.DeleteNarration(user, id);
            return Json(result);

        }
        public IActionResult AddPayment()
        {
            return View();
        }
        public JsonResult GetDebits()
        {
            var userrefid = Convert.ToInt32(HttpContext.Session.GetString(ApplicationConstants.UserRefId));
            var result = _dashboardservice.GetDebits(userrefid);
            return Json(result);
        }
        public async Task<JsonResult> AddPaymentToDb(string data,string outstanding)
        {
            if(data!= null)
            {
                Payment pay = JsonConvert.DeserializeObject<Payment>(data);
                var userid = Convert.ToInt32(HttpContext.Session.GetString(ApplicationConstants.UserRefId));
                pay.UserRefId = userid;
                var Outstanding = Convert.ToDouble(outstanding);
                var success = await _dashboardservice.AddPayment(pay, Outstanding);
                return  Json(success);

            }
            else
            {
                return Json(false);
            }
        }
        public IActionResult AddIncome()
        {
            return View();
        }
        public JsonResult AddIncomeToDb(string data)
        {
            if (data != null)
            {
                Income income = JsonConvert.DeserializeObject<Income>(data);
                var userid = Convert.ToInt32(HttpContext.Session.GetString(ApplicationConstants.UserRefId));
                income.UserRefId = userid;
                var success = _dashboardservice.AddIncome(income);
                return Json(success);

            }
            else
            {
                return Json(false);
            }
        }
    }
}
