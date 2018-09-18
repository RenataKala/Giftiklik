using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AppConfiguration : ConfigurationSection
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            }
        }

        public static string ConnectionStringName
        {
            get
            {
                return "GiftiDB";
            }
        }
        public static string AspIdentityConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[AspIdentityConnectionStringName].ConnectionString;
            }
        }


        public static string AspIdentityConnectionStringName
        {
            get { return "GiftiDB"; }
        }
    }
}

