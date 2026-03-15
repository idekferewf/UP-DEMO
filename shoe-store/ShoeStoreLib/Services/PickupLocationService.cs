using System.Collections.Generic;
using ShoeStoreLib.Interfaces;
using ShoeStoreLib.Repositories;

namespace ShoeStoreLib.Services
{
    public class PickupLocationService
    {
        private IPickupLocationRepository repository_;

        public PickupLocationService()
        {
            repository_ = new MySQLPickupLocationRepository();
        }

        public string GetPickupLocationAddressById(int id)
        {
            PickupLocation pickupLocation = repository_.GetPickupLocationById(id);

            if (pickupLocation != null)
            {
                return pickupLocation.Address;
            }

            return null;
        }

        public List<PickupLocation> GetAllPickupLocations()
        {
            return repository_.GetAllPickupLocations();
        }

        public int GetPickupLocationId(string address)
        {
            List<PickupLocation> pickupLocations = GetAllPickupLocations();

            foreach (PickupLocation p in pickupLocations)
            {
                if (p.Address == address)
                {
                    return p.Id;
                }
            }

            return 0;
        }
    }
}
