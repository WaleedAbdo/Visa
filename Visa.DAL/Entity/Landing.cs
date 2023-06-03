using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visa.DAL.Entity
{
    [Table("Landing")]
    public class Landing
    {
        public int Id { get; set; }
        [Required]

        public string TitleAr { get; set; }
        [Required]

        public string TitleEn { get; set; }
        [Required]

        public string DescriptionAr { get; set; }
        [Required]

        public string DescriptionEn { get; set; }
        [Required]

        public string ImageName { get; set; }
        [Required]

        public string VideoTitleAr { get; set; }
        [Required]

        public string VideoTitleEn { get; set; }

        public bool? IsDeleted { get; set; }

        [Required]
        public int CountryId { get; set; }


        public ICollection<FaQuestion>? FaQuestion { get; set; }
        public ICollection<StampedVisa>? StampedVisa { get; set; }
    }
}
