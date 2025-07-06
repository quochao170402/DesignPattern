// See https://aka.ms/new-console-template for more information

using Adapter.Adapters;
using Adapter.Models;
using Adapter.Services;

var request = new XMLRequest
{
    Id = 1,
    Data = "XML Data"
};

IReader legacyReader = new XMLReader();
legacyReader.Execute(request);
Console.WriteLine("=========");
IReader newReader = new ReaderAdapter(new JsonReader());
newReader.Execute(request);