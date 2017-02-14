using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreLocalization.WebApp.Models.HomeViewModels
{
    public class CreateItemViewModel
    {
        public int Id { get; set; }

        [Required, MinLength(2)]
        public string Name { get; set; }

        // Not required
        public string Description { get; set; }

        [Range(1, 2000)]
        public int Quantity { get; set; }

        [Display(Name = "Unit Price"), Range(1, 100), DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Start Date"), DataType(DataType.Date)]
        public DateTimeOffset? StartDate { get; set; }

        [Display(Name = "Range Test (fails)"), DataType(DataType.Date)]
        [Range(typeof(DateTime), "01-01-1966", "01-01-2020")]
        public DateTimeOffset? EndDate { get; set; }
    }
}