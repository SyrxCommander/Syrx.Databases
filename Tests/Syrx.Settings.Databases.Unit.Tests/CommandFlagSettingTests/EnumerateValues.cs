﻿//  ============================================================================================================================= 
//  author       : david sexton (@sextondjc | sextondjc.com)
//  date         : 2017.10.15 (17:59)
//  modified     : 2017.10.15 (22:43)
//  licence      : This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  =============================================================================================================================

using Xunit;
using static Xunit.Assert;

namespace Syrx.Settings.Databases.Unit.Tests.CommandFlagSettingTests
{
    public class EnumerateValues
    {
        [Theory]
        [InlineData(CommandFlagSetting.None, 0)]
        [InlineData(CommandFlagSetting.Buffered, 1)]
        [InlineData(CommandFlagSetting.Pipelined, 2)]
        [InlineData(CommandFlagSetting.NoCache, 4)]        
        [InlineData(CommandFlagSetting.Buffered | CommandFlagSetting.Pipelined, 3)]
        [InlineData(CommandFlagSetting.Buffered | CommandFlagSetting.NoCache, 5)]
        [InlineData(CommandFlagSetting.Pipelined | CommandFlagSetting.NoCache, 6)]
        public void Successfully(CommandFlagSetting setting, int value)
        {
            Equal(value, (int) setting);
        }
    }
}