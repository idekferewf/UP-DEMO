using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ShoeStoreLib.Interfaces;

namespace ShoeStoreLib.Repositories
{
    public class MySQLPickupLocationRepository: IPickupLocationRepository
    {
        public PickupLocation GetPickupLocationById(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "SELECT id, address FROM pickup_locations WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PickupLocation pickupLocation = new PickupLocation(reader.GetInt32("id"));
                            pickupLocation.Address = reader.GetString("address");
                            return pickupLocation;
                        }
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при получении пункта выдачи: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            return null;
        }

        public List<PickupLocation> GetAllPickupLocations()
        {
            List<PickupLocation> pickupLocations = new List<PickupLocation>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "SELECT id, address FROM pickups";
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

                return pickupLocations;
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
