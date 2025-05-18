// See https://aka.ms/new-console-template for more information

using Adapter.Adapters;
using Adapter.Models;
using Adapter.Services;

// Console.WriteLine("Hello, World!");
// var line = new Line()
// {
//     X1 = 1,
//     Y1 = 2,
//     X2 = 3,
//     Y2 = 4
// };
// line.Draw();

// var adapter = new RectangleAdapter(new Rectangle());
// adapter.Adapter(1, 2, 3, 4);

var request = new XMLRequest
{
    Id = 1,
    Data = "XML Data"
};

IService legacyService = new LegacyService();
legacyService.Execute(request);
Console.WriteLine("=========");
IService newService = new ServiceAdapter(new NewVersionService());
newService.Execute(request);