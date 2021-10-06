using FinTracker.Dal.Entity;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.DataProtection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FincTracker.Lib.Serivces
{
    public class DashboardSerivce
    {
        private readonly IDataProtector _protector;
        public DashboardSerivce(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("EmployeesApp.EmployeesController");
        }
        public async Task<bool> AddNarration(Debit debit)
        {
            try
            {
               
                using FinTrackerContext db = new FinTrackerContext();
                debit.ModifiedAt = DateTime.Now;
                debit.CreatedAt = DateTime.Now;
                db.Debits.Add(debit);
                await db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           
        }

        public List<Debit> GetNarration(int userrefid)
        {
            using FinTrackerContext db = new FinTrackerContext();
            var result = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted).OrderByDescending(x=>x.Interest).ToList();
            return result;
        }
        public async Task<bool> DeleteNarration(int user, int id)
        {
            using FinTrackerContext db = new FinTrackerContext();
            var result = db.Debits.Where(x => x.UserRefId == user && x.Id == id).FirstOrDefault();
            if(result != null)
            {
                result.ModifiedAt = DateTime.Now;
                result.IsDeleted = true;
                await db.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Debit> GetEmi(int userrefid)
        {
            using FinTrackerContext db = new FinTrackerContext();
            var result = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted && x.LoanStartDate.Day > DateTime.Now.Day).OrderByDescending(x => x.Interest).ToList();
            return result;
        }

        public List<double> GetDashData(int userrefid)
        {
            using FinTrackerContext db = new FinTrackerContext();
            var LoanOutstanding = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted).Select(x => x.CurrentOutstanding).ToList().Sum();
            var TotalEmi = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted).Select(x => x.Emi).ToList().Sum();
            var TotalIncome = db.Incomes.Where(x => x.UserRefId == userrefid && x.CreatedAt.Month == DateTime.Now.Month).Select(x => x.Amount).ToList().Sum();
            var TotalDebt = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted).Select(x => x.TotalAmount).ToList().Sum();
            var TotalPaid = db.Payments.Where(x => x.UserRefId == userrefid && !x.IsDeleted).Select(x => x.PaymentAmount).ToList().Sum();
            var Data = new List<double>();
            Data.Add(LoanOutstanding);
            Data.Add(TotalEmi);
            Data.Add(TotalIncome);
            Data.Add(TotalDebt);
            Data.Add(TotalPaid);
            return Data;
        }





        public List<Debit> GetDebits(int userrefid)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var result = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted && x.CurrentOutstanding !=0).ToList();
                if (result != null)
                {
                    return (result);
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
           
        }

        public async Task<bool> AddPayment(Payment pay,double outstanding)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                pay.CreatedAt = DateTime.Now;
                pay.ModifiedAt = DateTime.Now;
                Debit debit = db.Debits.Where(x => x.Id == pay.DebitRefId && x.UserRefId == pay.UserRefId).FirstOrDefault();
                debit.CurrentOutstanding = outstanding;
                db.Payments.Add(pay);
                await db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> AddIncome(Income income)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                income.CreatedAt = DateTime.Now;
                income.ModifiedAt = DateTime.Now;
                db.Incomes.Add(income);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
