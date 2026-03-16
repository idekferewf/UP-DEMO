using System.Collections.Generic;
using ShoeStoreLib.Interfaces;

namespace ShoeStoreLib.Services
{
    public class PickupLocationService
    {
        private IPickupLocationRepository repository_;

        public PickupLocationService(IPickupLocationRepository repository)
        {
            repository_ = repository;
        }

        public List<PickupLocation> GetAllPickupLocations()
        {
            return repository_.GetAllPickupLocations();
        }
    }
}
