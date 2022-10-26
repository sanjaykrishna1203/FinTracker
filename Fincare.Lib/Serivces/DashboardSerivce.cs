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
                if(debit.Id == 0)
                {
                    debit.ModifiedAt = DateTime.Now;
                    debit.CreatedAt = DateTime.Now;
                    db.Debits.Add(debit);
                }
                else
                {
                    var data = db.Debits.Where(x => x.Id == debit.Id && !x.IsDeleted).FirstOrDefault();
                    data.Interest = debit.Interest;
                    data.LoanEndDate = debit.LoanEndDate;
                    data.LoanStartDate = debit.LoanStartDate;
                    data.ModifiedAt = DateTime.Now;
                    data.Narration = debit.Narration;
                    data.TotalAmount = debit.TotalAmount;
                    data.Emi = debit.Emi;
                    data.CurrentOutstanding = debit.CurrentOutstanding;
                    

                }
               
                await db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
           
        }
        public List<Debit> GetNarration(int userrefid)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var result = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted).OrderByDescending(x => x.Interest).ToList();
                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
           
        }

        public Debit GetDebt(int id)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var result = db.Debits.Where(x => x.Id == id).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public async Task<bool> DeleteNarration(int user, int id)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var result = db.Debits.Where(x => x.UserRefId == user && x.Id == id).FirstOrDefault();
                if (result != null)
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
           
        }
        public List<Debit> GetEmi(int userrefid, int num)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var li = db.Debits.Where(x=> x.UserRefId == userrefid && !x.IsDeleted).ToList();
                li.ForEach(x =>x.LoanStartDate = FormatDebitDate(x.LoanStartDate));
                var result = li.Where(x =>  x.LoanStartDate > DateTime.Now && x.LoanStartDate < DateTime.Now.AddDays(num)).ToList();
                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
           
        }
        private DateTime FormatDebitDate(DateTime day)
        {
            if(DateTime.Now.Day <= day.Day)
            {
                return new DateTime(DateTime.Now.Year, DateTime.Now.Month, day.Day);

            }
            if(DateTime.Now.Day > day.Day)
            {
                if(day.Month == 12)
                {
                    return new DateTime(DateTime.Now.AddYears(1).Year, DateTime.Now.AddMonths(1).Month, day.Day);

                }
                else
                {
                    return new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(1).Month, day.Day);

                }
            }
            else
            {
                return new DateTime(DateTime.Now.Year, DateTime.Now.Month, day.Day);
            }
        }
        public List<double> GetDashData(int userrefid)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var LoanOutstanding = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted).Select(x => x.CurrentOutstanding).ToList().Sum();
                var TotalEmi = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted).Select(x => x.Emi).ToList().Sum();
                var TotalIncome = db.Incomes.Where(x => x.UserRefId == userrefid && x.CreatedAt.Month == DateTime.Now.Month).Select(x => x.Amount).ToList().Sum();
                var TotalExpense = db.Expenses.Where(x => x.UserRefId == userrefid && x.ExpenseDate.Month == DateTime.Now.Month).Select(x => x.ExpenseAmount).ToList().Sum();
                var TotalPaid = db.Payments.Where(x => x.UserRefId == userrefid && !x.IsDeleted).Select(x => x.PaymentAmount).ToList().Sum();
                var Data = new List<double>();
                Data.Add(LoanOutstanding);
                Data.Add(TotalEmi);
                Data.Add(TotalIncome);
                Data.Add(TotalExpense);
                Data.Add(TotalPaid);
                return Data;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
           
        }
        public List<Debit> GetDebits(int userrefid)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var result = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted && x.CurrentOutstanding !=0).ToList();
                for(var i =0; i < result.Count; i++)
                {
                    result[i].LoanStartDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month, result[i].LoanStartDate.Day);
                }

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
                Console.WriteLine(ex.Message);
                return null;
            }
           
        }

        public List<Payment> GetPayments(int debitRefId)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var result = db.Payments.Where(x => x.DebitRefId == debitRefId).OrderBy(x => x.PaymentDate).ToList();
                return result;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Debit> GetAllDebits(int userrefid)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var result = db.Debits.Where(x => x.UserRefId == userrefid && !x.IsDeleted).ToList();
                for (var i = 0; i < result.Count; i++)
                {
                    result[i].LoanStartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, result[i].LoanStartDate.Day);
                }

                if (result != null)
                {
                    return (result);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Expense exp = new Expense();
                exp.CreatedAt = DateTime.Now;
                exp.ModifiedAt = DateTime.Now;
                exp.ExpenseAmount = pay.PaymentAmount;
                exp.ExpenseDate = pay.PaymentDate;
                exp.ExpenseNarration = debit.Narration + " - EMI"; 
                db.Expenses.Add(exp);
                exp.UserRefId = pay.UserRefId;
                await db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public async Task<bool> AddExpense(Expense expense)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                expense.CreatedAt = DateTime.Now;
                expense.ModifiedAt = DateTime.Now;
                db.Expenses.Add(expense);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public List<Expense> GetExpense(int userrefid, DateTime fromdate, DateTime todate)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var result = db.Expenses.Where(x => x.ExpenseDate > fromdate && x.ExpenseDate < todate).OrderBy(x=>x.ExpenseDate).ToList();
                return result;

            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public List<Income> GetIncome(int userrefid, DateTime fromdate, DateTime todate)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var result = db.Incomes.Where(x => x.IncomeDate > fromdate && x.IncomeDate < todate).OrderBy(x=>x.IncomeDate).ToList();
                return result;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Double> GetReportData(int userrefid, DateTime fromdate, DateTime todate)
        {
            try
            {
                using FinTrackerContext db = new FinTrackerContext();
                var totalIncome = db.Incomes.Where(x=>x.IncomeDate > fromdate && x.IncomeDate < todate).Select(x => x.Amount).Sum();
                var totalExpense = db.Expenses.Where(x => x.ExpenseDate > fromdate && x.ExpenseDate < todate).Select(x=>x.ExpenseAmount).Sum();
                List<Double> result = new List<double>();
                result.Add(totalIncome);
                result.Add(totalExpense);
                return result;

            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
