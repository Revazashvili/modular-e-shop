namespace eShop.BuildingBlocks.Application.Contracts.Response;

public interface IResponse<out T>
{
    T Data { get; }
    List<string> Errors { get; }
    bool Succeeded { get; }
}