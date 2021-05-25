using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JumpStart.Entities.Models
{
    public class ExpenseCategory
    {
        public int ExpenseCategoryId { get; set; }

        [Display (Name = "Category")]
        [Required (ErrorMessage = "Category Name Required")]
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Expenses> Expense { get; set; }
    }
}
