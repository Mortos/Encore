﻿using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AnimReplacementSetRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public int ExecOrder { get; set; } // ?
    }
}
