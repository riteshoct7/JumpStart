using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpStart.Entities.Models
{
    public class Expenses
    {        
        #region Properties
        public int ExpensesID { get; set; }

        [Required(ErrorMessage = "Expense Date Required")]
        public DateTime ExpemseDate { get; set; }

        public Decimal Amount { get; set; }

        public string Description { get; set; }        

        [ForeignKey("ExpenseCategory")]
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }

        #endregion
    }
}
