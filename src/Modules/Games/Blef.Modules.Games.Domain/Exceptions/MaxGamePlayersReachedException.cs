﻿using Blef.Shared.Kernel.Exceptions;

namespace Blef.Modules.Games.Domain.Exceptions;

internal sealed class MaxGamePlayersReachedException : BlefException
{
    public MaxGamePlayersReachedException(Guid gameId)
        : base(
            title: "The maximum number of game players has been reached",
            detail: "No more than 2 players can take part in the game",
            instance: $"/games/{gameId}")
    {
    }
}