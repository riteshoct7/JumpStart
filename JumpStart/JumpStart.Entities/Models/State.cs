using System.ComponentModel.DataAnnotations;

namespace JumpStart.Entities.Models

{
    public class State
    {
        #region Properties

        public int StateId { get; set; }

        [Display(Name = "State Name")]
        [Required(ErrorMessage = "State Name")]
        public string StateName { get; set; }

        public int CountryId { get; set; }

        public string Description { get; set; } 

        #endregion

    }
}
