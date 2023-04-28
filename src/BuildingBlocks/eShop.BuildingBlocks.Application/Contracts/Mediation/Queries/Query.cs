namespace eShop.BuildingBlocks.Application.Contracts.Mediation.Queries;

public abstract record Query<TResult> : IQuery<TResult>;