﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Interfaces
{
    public interface IClanSearchSettings
    {
        string Name { get; set; }

        WarFrequency? WarFrequency { get; set; }

        int? LocationId { get; }

        int? MinimumMembers { get; }

        int? MaximumMembers { get; }

        int? MinimumClanPoints { get; }

        int? MinimumClanLevel { get; }

        int? Limit { get; }

        int? After { get; }

        int? Before { get; }
    }
}