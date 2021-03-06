﻿using System.Collections.Generic;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ICurrentWarClan
    {
        string Tag { get; }

        string Name { get; }

        ClanBadges Badges { get; }

        int ClanLevel { get; }

        int Attacks { get; }

        int Stars { get; }

        double DestructionPercentage { get; }

        IEnumerable<CurrentWarClanMember> Members { get; }
    }
}
