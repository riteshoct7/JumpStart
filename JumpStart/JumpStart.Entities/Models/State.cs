using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpStart.Entities.Models

{
    public class State
    {
        #region Properties

        public int StateId { get; set; }

        [Display(Name = "State Name")]
        [Required(ErrorMessage = "State Name")]
        public string StateName { get; set; }
       
        public string Description { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<City> City { get; set; }

        #endregion

    }
}
