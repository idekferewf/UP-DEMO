using System.Collections.Generic;

namespace ShoeStoreLib.Interfaces
{
    public interface IPickupLocationRepository
    {
        PickupLocation GetPickupLocationById(int id);
        List<PickupLocation> GetAllPickupLocations();
    }
}
