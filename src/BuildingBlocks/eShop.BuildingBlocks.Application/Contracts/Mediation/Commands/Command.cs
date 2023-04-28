namespace eShop.BuildingBlocks.Application.Contracts.Mediation.Commands;

public abstract record Command : ICommand;

public abstract record Command<TResult> : ICommand<TResult>;