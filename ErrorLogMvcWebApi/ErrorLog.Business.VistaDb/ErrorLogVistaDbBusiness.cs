﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ErrorLogVistaDbBusiness.cs
//
// summary:	Implements the error log vista database business class
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace ErrorLog.Business.VistaDb
{
    using SqlDb;
    using System.Configuration;

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An error log SQL ce business. </summary>
    ///
    /// <remarks>   Mustafa SAÇLI, 26.04.2019. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public class ErrorLogVistaDbBusiness : ErrorLogBaseSqlBusiness
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Mustafa SAÇLI, 26.04.2019. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public ErrorLogVistaDbBusiness()
            : base("vistadb", ConfigurationManager.ConnectionStrings["vistadb"].ConnectionString)
        {
        }
    }
}