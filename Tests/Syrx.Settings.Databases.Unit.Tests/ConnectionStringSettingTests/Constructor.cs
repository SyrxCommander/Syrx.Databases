﻿//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.10.15 (17:59)
//  modified     : 2017.10.15 (22:43)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using System;
using Xunit;
using static Xunit.Assert;

namespace Syrx.Settings.Databases.Unit.Tests.ConnectionStringSettingTests
{
    public class Constructor
    {
        [Fact]
        public void NullEmptyWhitespaceAliasThrowsArgumentNullException()
        {
            var nulled = Throws<ArgumentNullException>(() => new ConnectionStringSetting(null, "connectionString"));
            var empty = Throws<ArgumentNullException>(() => new ConnectionStringSetting(string.Empty, "connectionString"));
            var whitespace = Throws<ArgumentNullException>(() => new ConnectionStringSetting(" ", "connectionString"));

            const string expect = "Value cannot be null.\r\nParameter name: alias";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }

        [Fact]
        public void NullEmptyWhitespaceConnectionStringThrowsArgumentNullException()
        {
            var nulled = Throws<ArgumentNullException>(() => new ConnectionStringSetting("alias", null));
            var empty = Throws<ArgumentNullException>(() => new ConnectionStringSetting("alias", string.Empty));
            var whitespace = Throws<ArgumentNullException>(() => new ConnectionStringSetting("alias", ""));

            const string expect = "Value cannot be null.\r\nParameter name: connectionString";
            Equal(expect, nulled.Message);
            Equal(expect, empty.Message);
            Equal(expect, whitespace.Message);
        }
        

        [Fact]
        public void Successfully()
        {
            const string alias = "test";            
            const string connectionString = "Data Source=(LocalDb)\\mssqllocaldb;Initial Catalog=Zulu.Tests;Integrated Security=true";
            var result = new ConnectionStringSetting(alias, connectionString);
            Equal(alias, result.Alias);            
            Equal(connectionString, result.ConnectionString);
        }
    }
}