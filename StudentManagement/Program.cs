using System;
using MySql.Data.MySqlClient;

namespace Adonet
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "server=localhost;user=root;password=Rama@2005;database=ups";

            try
            {
                using (var connection =
                    new MySqlConnection(connectionString))
                {
                    connection.Open();

                    Console.WriteLine("Connection successful!\n");

                    const string query =
                        "SELECT id, name, email, dept, marks FROM student " +
                        "WHERE LOWER(LEFT(name, 1)) IN ('a', 'e', 'i', 'o', 'u')";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Console.WriteLine("No students with names starting with a vowel were found.");
                                return;
                            }

                            Console.WriteLine("Students whose names start with a vowel:\n");

                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["id"]}");
                                Console.WriteLine($"Name: {reader["name"]}");
                                Console.WriteLine($"Email: {reader["email"]}");
                                Console.WriteLine($"Department: {reader["dept"]}");
                                Console.WriteLine($"Marks: {reader["marks"]}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }
    }
}