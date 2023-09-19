﻿using System.ComponentModel;
using TrackSense.API.Entities;

namespace TrackSense.API.Models
{
    public class PlannedRideModel
    {
        [DefaultValue("b0f07b65-3055-4f99-bc09-91829ca16fdb")]
        public string PlannedRideId { get; set; } = null!;
        
        [DefaultValue("admin")]
        public string UserLogin { get; set; } = null!;

        [DefaultValue("Administrateur")]
        public string? Name { get; set; } 
        public bool ?IsFavorite { get; set; }
        public PlannedRideStatisticsModel? Statistics { get; set; }
        public List<PlannedRidePointModel> PlannedRidePointModel { get; set; } = new List<PlannedRidePointModel>();

        public PlannedRideModel()
        {
           
        }

        public PlannedRideModel(Entities.PlannedRide p_plannedRide)
        {
            this.PlannedRideId = p_plannedRide.PlannedRideId;
            this.UserLogin = p_plannedRide.UserLogin;
            this.Name = p_plannedRide?.Name;
            this.IsFavorite = p_plannedRide?.IsFavorite;

            if (p_plannedRide!.Statistics != null)
            {
                this.Statistics = new PlannedRideStatisticsModel(p_plannedRide.Statistics);
            }

            if (p_plannedRide.PlannedRidePoints != null)
            {
                this.PlannedRidePointModel = p_plannedRide.PlannedRidePoints
                    .Select(point => new PlannedRidePointModel(point))
                    .ToList();
            }
        }

        public Entities.PlannedRide ToEntity()
        {
            PlannedRide plannedRide = new PlannedRide()
            {
                UserLogin = this.UserLogin,
                PlannedRideId = this.PlannedRideId,
                Name = this.Name,
                IsFavorite = this.IsFavorite,
                Statistics = this.Statistics?.ToEntity(),
                PlannedRidePoints = this.PlannedRidePointModel
                                            .Select(point => point.ToEntity())
                                            .ToList(),
            };

            return plannedRide;
        }
    }

}
