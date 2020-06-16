using System;
using System.ComponentModel.DataAnnotations;

namespace NicroD_IT_Enterprise_Table
{
    public class Reg
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime RegDate { get; set; }
        [Required]
        public string RegOrgName { get; set; }
        [Required]
        public string RegCityName { get; set; }
        [Required]
        public string RegCountryName { get; set; }
        [Required]
        public string RegManagerName { get; set; }
        [Required]
        public int RegCount { get; set; }
        [Required]
        public decimal RegTotalSum { get; set; }

    }
}
