using Adapter.Models;

namespace Adapter.Services;

public interface IService
{
    void Execute(XMLRequest request);
}