﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpenWorkout.Management.Api.ViewModel
{
    [DisplayName("MuscleGroupPut")]
    public class MuscleGroupPutViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string MuscleGroupName { get; set; }
    }
}
