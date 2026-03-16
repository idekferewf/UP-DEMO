using System.Collections.Generic;
using System.Linq;
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

        public PickupLocation GetPickupLocation(string address)
        {
            return GetAllPickupLocations().FirstOrDefault(p => p.Address == address);
        }
    }
}
