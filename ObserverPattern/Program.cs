// using ObserverPattern.Basic;
//
// Console.WriteLine("Hello, World!");
//
// var weatherData = new WeatherData();
//
// var currentConditions = new CurrentConditions();
//
// var stats = new WeatherStats();
//
// var forecast = new Forecast();
// var heatIndex = new HeatIndex();
//
// weatherData.RegisterObserver(currentConditions);
// weatherData.RegisterObserver(stats);
// weatherData.RegisterObserver(forecast);
// weatherData.RegisterObserver(heatIndex);
//
// currentConditions.Display();
// Console.WriteLine();
// stats.Display();
// Console.WriteLine();
// forecast.Display();
// Console.WriteLine();
// heatIndex.Display();
// Console.WriteLine("=================");
// weatherData.SetMeasurements(27, 70, 1.8);
//
// currentConditions.Display();
// Console.WriteLine();
// stats.Display();
// Console.WriteLine();
// forecast.Display();
// Console.WriteLine();
// heatIndex.Display();
// Console.WriteLine("=================");
//
// weatherData.SetMeasurements(21, 12, 2.8);
// currentConditions.Display();
// Console.WriteLine();
// stats.Display();
// Console.WriteLine();
// forecast.Display();
// Console.WriteLine();
// heatIndex.Display();
// Console.WriteLine("=================");

using ObserverPattern.EducationExample;

var school = new School();

var teacher = new Teacher();
var admin = new Administrator();
var student = new Student();
var parent = new Parent();

school.Subscribe(teacher);
school.Subscribe(admin);
school.Subscribe(student);
school.Subscribe(parent);

school.Notify("School will closed at 12:00");
school.Notify("School will start at 13:00");

teacher.Display();
Console.WriteLine("===============================================================");
admin.Display();
Console.WriteLine("===============================================================");
student.Display();
Console.WriteLine("===============================================================");
parent.Display();