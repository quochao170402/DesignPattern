namespace Adapter;

public class ServiceAdapter : IService
{
    private readonly NewVersionService _newService;

    public ServiceAdapter(NewVersionService newService)
    {
        _newService = newService;
    }

    public void Execute(XMLRequest request)
    {
        JsonRequest json = convertRequest(request);
        _newService.Execute(json);
    }
    public JsonRequest convertRequest(XMLRequest xmlRequest)
    {
        return new JsonRequest()
        {
            Id = xmlRequest.Id,
            Body = xmlRequest.Data
        };
    }
}
