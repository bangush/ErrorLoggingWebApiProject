﻿namespace ErrorLog.IoC.Library
{
    using System;
    using System.Configuration;

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An application values. </summary>
    ///
    /// <remarks>   Msacli, 24.04.2019. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public static class IocAppValues
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the database mode. </summary>
        ///
        /// <value> The database mode. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public static int DbMode
        {
            get
            {
                var dbMode = ConfigurationManager.AppSettings["dbMode"] ?? string.Empty;
                dbMode = dbMode.Trim();
                dbMode = dbMode.Replace(" ", string.Empty);
                int say;
                int.TryParse(dbMode, out say);
                return say;
            }
        }
    }
}