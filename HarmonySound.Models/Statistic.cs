﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySound.Models
{
    public class Statistic
    {
        [Key]
        public int Id { get; set; }

        public int ContentId { get; set; }
        public Content Content { get; set; }

        public int Reproductions { get; set; }

        public int Likes { get; set; }

        public int Comments { get; set; }

        public DateTimeOffset ReportDate { get; set; }
    }
}
