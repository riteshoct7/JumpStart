using System.ComponentModel.DataAnnotations;

namespace JumpStart.Entities.Models
{
    public class Ciity
    {
        #region Properties

        public int CityId { get; set; }

        [Display(Name = "City Name")]
        [Required(ErrorMessage = "City Name Required")]
        public string CityName { get; set; }
        public int StateId { get; set; }
        public string Description { get; set; } 

        #endregion

    }
}
