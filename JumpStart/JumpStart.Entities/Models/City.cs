using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpStart.Entities.Models
{
    
    public class City
    {
        #region Properties
        public int CityId { get; set; }

        [Required(ErrorMessage = "City Name Required")]
        [Display(Name = "City")]
        public string CityName { get; set; }

        public string Description { get; set; } 

        [ForeignKey("State")]
        public int StateId { get; set; }
        public State State { get; set; }

        #endregion

    }
}
