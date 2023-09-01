﻿using TrackSense.API.Entities;

namespace TrackSense.API.ViewModels
{
    public class PlannedRideViewModel
    {
        public Guid PlannedRideId { get; set; }
        public string Name { get; set; }
        public bool IsFavorite { get; set; }
        public PlannedRideStatisticsModel Statistics { get; set; }
        public List<PlannedRidePointModel>? RidePoints { get; set; }

        public PlannedRideViewModel()
        {
            this.Statistics = new PlannedRideStatisticsModel();
        }

        public PlannedRideViewModel(PlannedRide p_plannedRide)
        {
            this.PlannedRideId = p_plannedRide.PlannedRideId;
            this.Name = p_plannedRide.Name;
            this.IsFavorite = p_plannedRide.IsFavorite;
            this.Statistics = new PlannedRideStatisticsModel(p_plannedRide.Statistics);

            if (p_plannedRide.RidePoints != null)
            {
                this.RidePoints = p_plannedRide.RidePoints
                    .Select(point => new PlannedRidePointModel(point))
                    .ToList();
            }
        }

        public PlannedRide ToEntity()
        {
            return new PlannedRide
            {
                PlannedRideId = this.PlannedRideId,
                Name = this.Name,
                IsFavorite = this.IsFavorite,
                Statistics = this.Statistics.ToEntity(),
                RidePoints = this.RidePoints?
                    .Select(point => point.ToEntity())
                    .ToList()
            };
        }
    }

}