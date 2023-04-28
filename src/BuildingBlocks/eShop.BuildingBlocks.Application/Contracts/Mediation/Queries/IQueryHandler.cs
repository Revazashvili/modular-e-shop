using eShop.BuildingBlocks.Application.Contracts.Responses;
using MediatR;

namespace eShop.BuildingBlocks.Application.Contracts.Mediation.Queries;

public interface IQueryHandler<in TQuery, TResult> :
    IRequestHandler<TQuery, IResponse<TResult>>
    where TQuery : Query<TResult>
{
}