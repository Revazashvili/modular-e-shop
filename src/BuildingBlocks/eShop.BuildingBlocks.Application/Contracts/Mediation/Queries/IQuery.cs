using eShop.BuildingBlocks.Application.Contracts.Responses;
using MediatR;

namespace eShop.BuildingBlocks.Application.Contracts.Mediation.Queries;

public interface IQuery<out TResult> : IRequest<IResponse<TResult>>
{
}