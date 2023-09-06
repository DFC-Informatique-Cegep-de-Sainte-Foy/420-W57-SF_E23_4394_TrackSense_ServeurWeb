﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrackSense.API.Entities;

namespace TrackSense.API.Services.DTO
{
    public class CompletedRideDTO
    {
        [Key]
        [Required]
        public Guid CompletedRideId { get; set; }

        [ForeignKey(nameof(UserLogin))]
        [Required]
        public string UserLogin { get; set; }=string.Empty;

        [ForeignKey(nameof(PlannedRideId))]
        public Guid PlannedRideId { get; set; } = Guid.Empty;
        public virtual PlannedRideDTO? PlannedRide { get; set; }
        public virtual List<CompletedRidePointDTO>? CompletedRidePoints { get; set; }
        public virtual CompletedRideStatisticsDTO Statistics { get; set; }

        public CompletedRideDTO()
        {
            
        }
        public CompletedRideDTO(CompletedRide p_completedRide)
        {
            this.CompletedRideId = p_completedRide.CompletedRideId;
            this.UserLogin = p_completedRide.UserLogin;
        }
    }
}