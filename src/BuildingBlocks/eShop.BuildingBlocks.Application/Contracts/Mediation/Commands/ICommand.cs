using eShop.BuildingBlocks.Application.Contracts.Responses;
using MediatR;

namespace eShop.BuildingBlocks.Application.Contracts.Mediation.Commands;

public interface ICommand<out TResult> : IRequest<IResponse<TResult>>
{
}

public interface ICommand : IRequest<IResponse<Unit>>
{
}