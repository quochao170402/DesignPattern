using Adapter.Models;
using Adapter.Services;

namespace Adapter.Adapters;

public class ServiceAdapter : IService
{
    private readonly NewVersionService _newService;

    public ServiceAdapter(NewVersionService newService)
    {
        _newService = newService;
    }

    public void Execute(XMLRequest request)
    {
        var json = convertRequest(request);
        _newService.Execute(json);
    }

    public JsonRequest convertRequest(XMLRequest xmlRequest)
    {
        return new JsonRequest
        {
            Id = xmlRequest.Id,
            Body = xmlRequest.Data
        };
    }
}