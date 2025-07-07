﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySound.Models
{
    public class User : IdentityUser<int>
    {
        // Tus propiedades personalizadas
        [Required] public string Name { get; set; }
        [Required][EmailAddress] public override string Email { get; set; }
        [Required] public DateTimeOffset RegisterDate { get; set; }
        public string State { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public virtual ICollection<UserPlan> UserPlans { get; set; } = new List<UserPlan>();
        public virtual ICollection<Content> Content { get; set; } = new List<Content>();
        public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
        public virtual ICollection<SubscriptionHistory> SubscriptionHistory { get; set; } = new List<SubscriptionHistory>();
    }
}
