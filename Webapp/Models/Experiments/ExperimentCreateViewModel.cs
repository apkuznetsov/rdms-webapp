﻿using System.ComponentModel.DataAnnotations;

namespace Webapp.Models.Experiments
{
    public class ExperimentCreateViewModel
    {
        public int ExperimentId { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Metadata { get; set; }
    }
}
