using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySound.Models
{
    public class Plan
    {
        [Key] public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string PlanName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AccountLimit { get; set; }
    }
}
