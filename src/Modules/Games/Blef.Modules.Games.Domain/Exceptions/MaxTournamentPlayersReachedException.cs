﻿using Blef.Shared.Kernel.Exceptions;

namespace Blef.Modules.Games.Domain.Exceptions;

internal sealed class MaxTournamentPlayersReachedException : BlefException
{
    public MaxTournamentPlayersReachedException(Guid tournamentId)
        : base(
            title: "The maximum number of tournament players has been reached",
            detail: "No more than 2 players can take part in the tournament",
            instance: $"/tournaments/{tournamentId}")
    {
    }
}