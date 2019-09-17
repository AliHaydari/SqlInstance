using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInstance.Helpers
{
    public static class ChangeConnectionString
    {
        //public static void ChangeWebConfigConnectionString(string dataSource, string initialCatalog, string userId, string password)
        //{
        //    Configuration config = null;
        //    if (HttpContext.Current != null && !HttpContext.Current.Request.PhysicalPath.Equals(string.Empty))
        //        config = WebConfigurationManager.OpenWebConfiguration("~");
        //    else
        //        config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        //    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

        //    connectionStringsSection.ConnectionStrings["ApplicationDbContext"].ConnectionString =
        //        $@"metadata=res://*/HatraBaseContext.HatraContext.csdl|res://*/HatraBaseContext.HatraContext.ssdl|res://*/HatraBaseContext.HatraContext.msl;provider=System.Data.SqlClient;provider connection string=';data source={dataSource.Trim()};initial catalog={initialCatalog};persist security info=True;user id={userId.Trim()};password={password.Trim()};multipleactiveresultsets=True;application name=EntityFramework'";

        //    config.Save();

        //    ConfigurationManager.RefreshSection("connectionStrings");
        //}

        //public static void ChangeEfDbFirst(string dataSource, string initialCatalog, string userId, string password)
        //{
        //    Configuration config = null;
        //    if (HttpContext.Current != null && !HttpContext.Current.Request.PhysicalPath.Equals(string.Empty))
        //        config = WebConfigurationManager.OpenWebConfiguration("~");
        //    else
        //        config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        //    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

        //    connectionStringsSection.ConnectionStrings["ApplicationDbContext"].ConnectionString =
        //        $@"metadata=res://*/HatraBaseContext.HatraContext.csdl|res://*/HatraBaseContext.HatraContext.ssdl|res://*/HatraBaseContext.HatraContext.msl;provider=System.Data.SqlClient;provider connection string=';data source={dataSource.Trim()};initial catalog={initialCatalog};persist security info=True;user id={userId.Trim()};password={password.Trim()};multipleactiveresultsets=True;application name=EntityFramework'";

        //    config.Save();

        //    ConfigurationManager.RefreshSection("connectionStrings");
        //}
    }
}
