using System;
using System.ComponentModel.DataAnnotations;

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

        public int CategoryId { get; set; } 
        #endregion        
    }
}
