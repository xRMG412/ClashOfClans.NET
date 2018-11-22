﻿using ClashOfClans.Core.Clans.Interfaces;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class WarLog : IWarLog
    {
        [DataMember(Name = "result")]
        public WarResult Result { get; private set; }

        [DataMember(Name = "endTime")]
        public string EndTime { get; private set; }

        [DataMember(Name = "teamSize")]
        public int TeamSize { get; private set; }

        [DataMember(Name = "clan")]
        public WarLogClan Clan { get; private set; }

        [DataMember(Name = "opponent")]
        public WarLogOpponent Opponent { get; private set; }
    }
}