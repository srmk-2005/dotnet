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
                    Console.WriteLine("Connection successful!");
                    Console.Write("Enter Student ID to update: ");
                    if (!int.TryParse(Console.ReadLine(), out int studentId))
                    {
                        Console.WriteLine("Invalid Student ID!");
                        return;
                    }
                    string checkQuery =
                        "SELECT COUNT(*) FROM student WHERE id = @id";
                    using (var checkCommand =
                        new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@id", studentId);
                        int count = Convert.ToInt32(
                            checkCommand.ExecuteScalar());
                        if (count == 0)
                        {
                            Console.WriteLine("Student ID not found!");
                            return;
                        }
                    }
                    Console.WriteLine("\nStudent found! Enter updated details.");
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Student Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Student Department: ");
                    string dept = Console.ReadLine();
                    Console.Write("Enter Student Marks: ");
                    if (!int.TryParse(Console.ReadLine(), out int marks))
                    {
                        Console.WriteLine("Invalid Marks!");
                        return;
                    }
                    if (marks < 0 || marks > 100)
                    {
                        Console.WriteLine("Marks must be between 0 and 100!");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(name) ||
                        string.IsNullOrWhiteSpace(email) ||
                        string.IsNullOrWhiteSpace(dept))
                    {
                        Console.WriteLine("Fields cannot be empty!");
                        return;
                    }
                    string updateQuery = @"
                        UPDATE student
                        SET name = @name,
                            email = @email,
                            dept = @dept,
                            marks = @marks
                        WHERE id = @id";
                    using (var command =
                        new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", studentId);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@dept", dept);
                        command.Parameters.AddWithValue("@marks", marks);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine(
                                "\nStudent details updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine(
                                "No changes were made to the student record.");
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