using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Inventory.Models;
using Inventory.Configuration;

namespace Inventory.BusinessLayer
{
    class BL_AppSettings
    {
        private static System.Configuration.Configuration config =
            ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);

        private static string Token = ConfigurationManager.AppSettings["Token"].ToString();
        private static string Server_From_Config = ConfigurationManager.AppSettings["Server"].ToString();
        private static string Username_From_Config = ConfigurationManager.AppSettings["Username"].ToString();
        private static string Password_From_Config = ConfigurationManager.AppSettings["Password"].ToString();
        private static string Database_From_Config = ConfigurationManager.AppSettings["Database"].ToString();

        public static bool HasConnectionString()
        {
            return AppSetting.HasConnectionString;
        }

        public static bool HasDatabase()
        {
            return AppSetting.HasDatabase;
        }

        public static bool HasDefaultUser()
        {
            return AppSetting.HasDefaultUser;
        }

        public static void Set_FirstRun_To_False()
        {
            AddOrUpdateAppSettings("HasDefaultUser", Encryption.Encrypt("1", Token));
            AddOrUpdateAppSettings("isFirtsRun", Encryption.Encrypt("0", Token));
        }

        public static void Save_Database_To_ConfigurationFile(string DatabaseName)
        {
            ConnectionString.Database = DatabaseName;
            AddOrUpdateAppSettings("Database", Encryption.Encrypt(DatabaseName, Token));
            AddOrUpdateAppSettings("HasDatabase", Encryption.Encrypt("1", Token));
        }

        public static void Save_ConnectionString_To_ConfigurationFile(string Server, string Username, string Password)
        {
            ConnectionString.Server = Server;
            ConnectionString.Username = Username;
            ConnectionString.Password = Password;

            AddOrUpdateAppSettings("Server", Encryption.Encrypt(Server, Token));
            AddOrUpdateAppSettings("Username", Encryption.Encrypt(Username, Token));
            AddOrUpdateAppSettings("Password", Encryption.Encrypt(Password, Token));
            AddOrUpdateAppSettings("HasConnectionString", Encryption.Encrypt("1", Token));
        }

        public static void Set_ConnectionString()
        {
            ConnectionString.Server = Encryption.Decrypt(Server_From_Config, Token);
            ConnectionString.Username = Encryption.Decrypt(Username_From_Config, Token);
            ConnectionString.Password = Encryption.Decrypt(Password_From_Config, Token);
            ConnectionString.Database = Encryption.Decrypt(Database_From_Config, Token);
        }

        public static void AddOrUpdateAppSettings(string key, string value)
        {
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
                config.Save(ConfigurationSaveMode.Modified);

                return;
            }

            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
        }

        public static void Create_Directories()
        {
            string path = System.Windows.Forms.Application.StartupPath;

            string users_image_folder = path + "\\images\\users";
            string products_image_folder = path + "\\images\\products";
            string customers_image_folder = path + "\\images\\customers";
            

            if (!System.IO.Directory.Exists(users_image_folder))
                System.IO.Directory.CreateDirectory(users_image_folder);

            if (!System.IO.Directory.Exists(products_image_folder))
                System.IO.Directory.CreateDirectory(products_image_folder);

            if (!System.IO.Directory.Exists(customers_image_folder))
                System.IO.Directory.CreateDirectory(customers_image_folder);
        }
    }
}
