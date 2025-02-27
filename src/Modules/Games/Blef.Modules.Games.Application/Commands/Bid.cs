﻿using Blef.Shared.Abstractions.Commands;

namespace Blef.Modules.Games.Application.Commands;

public sealed record Bid(Guid GameId, Guid PlayerId, string PokerHand) : ICommand;