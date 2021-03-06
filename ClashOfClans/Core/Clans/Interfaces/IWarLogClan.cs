namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IWarLogClan
    {
        string Tag { get; }

        string Name { get; }

        ClanBadges Badges { get; }

        int ClanLevel { get; }

        int Attacks { get; }

        int Stars { get; }

        double DestructionPercentage { get; }

        int ExpEarned { get; }
    }
}
