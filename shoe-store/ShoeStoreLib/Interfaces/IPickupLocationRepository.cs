using System.Collections.Generic;

namespace ShoeStoreLib.Interfaces
{
    public interface IPickupLocationRepository
    {
        List<PickupLocation> GetAllPickupLocations();
    }
}
