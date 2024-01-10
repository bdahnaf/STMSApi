using STMSApi.Models.DTOs;

namespace STMSApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
                new VillaDTO { Id = 1, Name = "Pool View", Sqft = 2000, Occupancy = 10},
                new VillaDTO { Id = 2, Name = "Alif Mansion", Sqft = 1420, Occupancy = 5}
        };
    }
}
