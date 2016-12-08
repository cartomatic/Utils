﻿namespace Cartomatic.Utils.Data
{
    public interface IDataSourceCredentials
    {
        DataSourceType DataSourceType { get; set; }

        string ServerHost { get; set; }
        string ServerName { get; set; }
        int? ServerPort { get; set; }
        string DbName { get; set; }
        string ServiceDb { get; set; }
        string UserName { get; set; }
        string Pass { get; set; }
        string ServiceUserName { get; set; }
        string ServiceUserPass { get; set; }

        string GetConnectionString(bool serviceDatabase = false, bool superUser = false);
    }
}