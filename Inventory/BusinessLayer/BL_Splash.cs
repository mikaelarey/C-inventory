using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Inventory.Configuration;
using Inventory.Models;

namespace Inventory.BusinessLayer
{
    class BL_Splash
    {
        public static void Set_AppSettings()
        {
            string Server = ConfigurationManager.AppSettings["Server"].ToString();
            string Username = ConfigurationManager.AppSettings["Username"].ToString();
            string Password = ConfigurationManager.AppSettings["Password"].ToString();
            string Database = ConfigurationManager.AppSettings["Database"].ToString();

            string isFirtsRun = ConfigurationManager.AppSettings["isFirtsRun"].ToString();
            string HasConnectionString = ConfigurationManager.AppSettings["HasConnectionString"].ToString(); 
            string HasDatabase = ConfigurationManager.AppSettings["HasDatabase"].ToString(); 
            string HasDefaultUser = ConfigurationManager.AppSettings["HasDefaultUser"].ToString();
            string Token = ConfigurationManager.AppSettings["Token"].ToString(); ;

            AppSetting.isFirtsRun = Encryption.Decrypt(isFirtsRun, Token) == "1" ? true : false;
            AppSetting.HasConnectionString = Encryption.Decrypt(HasConnectionString, Token) == "1" ? true : false;
            AppSetting.HasDatabase = Encryption.Decrypt(HasDatabase, Token) == "1" ? true : false;
            AppSetting.HasDefaultUser = Encryption.Decrypt(HasDefaultUser, Token) == "1" ? true : false;

            ConnectionString.Server = Encryption.Decrypt(Server, Token);
            ConnectionString.Database = Encryption.Decrypt(Database, Token);
            ConnectionString.Username = Encryption.Decrypt(Username, Token);
            ConnectionString.Password = Encryption.Decrypt(Password, Token);
        }

        public static bool isFirstRun()
        {
            return AppSetting.isFirtsRun;
        }
    }
}
