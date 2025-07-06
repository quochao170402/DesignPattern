using Adapter.Models;

namespace Adapter.Services;

public interface IReader
{
    void Execute(XMLRequest request);
}