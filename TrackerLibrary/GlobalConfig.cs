﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection>? Connections { get; private set; } = new List<IDataConnection> ();
        
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //TODO - Set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections?.Add(sql);
            }

            if (textFiles)
            {
                //TODO - Set up the Text connection properly
                TextConnector text = new TextConnector();
                Connections?.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
