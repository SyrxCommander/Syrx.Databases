﻿//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.10.15 (17:58)
//  modified     : 2017.10.15 (22:43)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

#region

using System.Data;
using Syrx.Settings.Databases;

#endregion

namespace Syrx.Connectors.Databases
{
    /// <summary>
    ///     Used to create database connections against an underlying data store.
    /// </summary>
    public interface IDatabaseConnector : IConnector<IDbConnection, DatabaseCommandSetting>
    {
    }
}