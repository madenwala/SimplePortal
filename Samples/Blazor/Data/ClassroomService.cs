using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SimplePortal.UI.Web.Data
{
    public sealed class ClassroomService
    {
        public Task<ClassroomResponse> GetClassroomAsync()
        {
            return Task.FromResult<ClassroomResponse>(null);
        }

        public Task<AddClassroomResponse> GetAddClassroomAsync(AddClassroomRequest request)
        {
            return Task.FromResult<AddClassroomResponse>(null);
        }
    }

    //public class WeatherForecastService
    //{
    //    private static readonly string[] Summaries = new[]
    //    {
    //        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    //    };

    //    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    //    {
    //        var rng = new Random();
    //        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //        {
    //            Date = startDate.AddDays(index),
    //            TemperatureC = rng.Next(-20, 55),
    //            Summary = Summaries[rng.Next(Summaries.Length)]
    //        }).ToArray());
    //    }
    //}
}