﻿using Blef.Shared.Abstractions.Commands;
using JetBrains.Annotations;

namespace Blef.Modules.Games.Application.Commands;

public sealed record JoinTournament(Guid TournamentId, string Nick) : ICommand<JoinTournament.Result>
{
    [UsedImplicitly]
    public sealed record Result(Guid PlayerId, string Nick) : ICommandResult;
}