using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JumpStart.Entities.Models
{
    public class Country
    {
        #region Properties

        public int CountryId { get; set; }

        [Display(Name = "Country Name")]
        [Required(ErrorMessage = "CountryNam Required")]
        public string CountryName { get; set; }

        public string ISDCode { get; set; }

        public string Dscription { get; set; } 

        public ICollection<State> States { get; set; }

        #endregion

    }
}
