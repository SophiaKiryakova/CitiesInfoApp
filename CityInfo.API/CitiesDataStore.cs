using CityInfo.API.DTO;
using System.Collections.Generic;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Sofia",
                    Description = "The capital of Bulgaria",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id = 1,
                            Name = "Saint Sofia Statue",
                            Description = "The symbol of Sofia"
                        },
                        new PointOfInterest()
                        {
                            Id = 2,
                            Name = "Alexander Nevski Cathedral",
                            Description = "The biggest orthodox cathedral on the Balkans"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 2,
                    Name = "Varna",
                    Description = "The sea capital of Bulgaria",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id = 3,
                            Name = "The Sea Park",
                            Description = "A big park by the sea"
                        },
                        new PointOfInterest()
                        {
                            Id = 4,
                            Name = "The Delphinarium",
                            Description = "Dolphins"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "Plovdiv",
                    Description = "One of the oldest cities in the world still inhabited",
                      PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id = 5,
                            Name = "The Ancient City",
                            Description = "An Anient city on the top of Plovdiv"
                        },
                        new PointOfInterest()
                        {
                            Id = 6,
                            Name = "The Ancient Theater",
                            Description = "An Ancient Theater dating centuries"
                        }
                    }
                }
            };
        }
    }
}
