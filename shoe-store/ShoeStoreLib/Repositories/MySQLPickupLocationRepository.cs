using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ShoeStoreLib.Interfaces;

namespace ShoeStoreLib.Repositories
{
    public class MySQLPickupLocationRepository: IPickupLocationRepository
    {
        public List<PickupLocation> GetAllPickupLocations()
        {
            List<PickupLocation> pickupLocations = new List<PickupLocation>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "SELECT id, address FROM pickup_locations";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PickupLocation pickup = new PickupLocation(reader.GetInt32("id"));
                            pickup.Address = reader.GetString("address");
                            pickupLocations.Add(pickup);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при получении пунктов выдачи: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            return pickupLocations;
        }
    }
}
