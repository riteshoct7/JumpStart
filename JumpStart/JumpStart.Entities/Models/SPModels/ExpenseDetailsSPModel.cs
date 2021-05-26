using Microsoft.EntityFrameworkCore;
using System;

namespace JumpStart.Entities.Models.SPModels
{
    [Keyless]
    public class ExpenseDetailsSPModel
    {
        public int ExpensesID { get; set; }
        public DateTime ExpemseDate { get; set; }
        public Decimal Amount { get; set; }
        public string Description { get; set; }
        public int ExpenseCategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
