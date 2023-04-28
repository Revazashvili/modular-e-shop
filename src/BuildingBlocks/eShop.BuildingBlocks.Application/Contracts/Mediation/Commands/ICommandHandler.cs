using eShop.BuildingBlocks.Application.Contracts.Responses;
using MediatR;

namespace eShop.BuildingBlocks.Application.Contracts.Mediation.Commands;

public interface ICommandHandler<in TCommand, TResult> :
    IRequestHandler<TCommand, IResponse<TResult>>
    where TCommand : Command<TResult>
{
}

public interface ICommandHandler<in TCommand>
    : IRequestHandler<TCommand, IResponse<Unit>>
    where TCommand : ICommand
{
}