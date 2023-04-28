namespace eShop.BuildingBlocks.Application.Contracts.Responses;

public interface IResponse<out T>
{
    T Data { get; }
    List<string> Errors { get; }
    bool Succeeded { get; }
}