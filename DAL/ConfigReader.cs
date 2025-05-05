using System;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    public static class ConfigReader
    {
        private static string cachedConnectionString;

        public static string GetConnectionString()
        {
            if (!string.IsNullOrEmpty(cachedConnectionString))
            {
                return cachedConnectionString;
            }

            if (!File.Exists("config.txt"))
            {
                throw new Exception("Configuration file 'config.txt' not found.");
            }

            var config = new Dictionary<string, string>();
            foreach (var line in File.ReadAllLines("config.txt"))
            {
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    config[parts[0].Trim()] = parts[1].Trim();
                }
            }

            if (!config.ContainsKey("Server") || string.IsNullOrWhiteSpace(config["Server"]))
            {
                throw new Exception("Server name is required in config.txt.");
            }
            if (!config.ContainsKey("Database") || string.IsNullOrWhiteSpace(config["Database"]))
            {
                throw new Exception("Database name is required in config.txt.");
            }

            string server = config["Server"];
            string database = config["Database"];
            bool winAuth = config.ContainsKey("WinAuth") && bool.TryParse(config["WinAuth"], out bool result) && result;

            string connectionString;
            if (winAuth)
            {
                connectionString = $"Data Source={server};Initial Catalog={database};Integrated Security=True;TrustServerCertificate=True";
            }
            else
            {
                if (!config.ContainsKey("UserID") || string.IsNullOrWhiteSpace(config["UserID"]))
                {
                    throw new Exception("UserID is required for SQL Server Authentication.");
                }
                if (!config.ContainsKey("Password") || string.IsNullOrWhiteSpace(config["Password"]))
                {
                    throw new Exception("Password is required for SQL Server Authentication.");
                }

                string uid = config["UserID"];
                string pass = config["Password"];
                connectionString = $"Data Source={server};Initial Catalog={database};User ID={uid};Password={pass};TrustServerCertificate=True";
            }

            cachedConnectionString = connectionString;
            return connectionString;
        }
    }
}