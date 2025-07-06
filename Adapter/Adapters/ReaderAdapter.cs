using Adapter.Models;
using Adapter.Services;

namespace Adapter.Adapters;

public class ReaderAdapter(JsonReader newService) : IReader
{
    public void Execute(XMLRequest request)
    {
        var json = ConvertRequest(request);
        JsonReader.Execute(json);
    }

    private static JsonRequest ConvertRequest(XMLRequest xmlRequest)
    {
        return new JsonRequest
        {
            Id = xmlRequest.Id,
            Body = xmlRequest.Data
        };
    }
}