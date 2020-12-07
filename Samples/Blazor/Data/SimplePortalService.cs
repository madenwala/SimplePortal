using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplePortal.UI.Web.Data
{
    public sealed class SimplePortalService
    {
        private ClassroomResponse response = new ClassroomResponse();
        
        public SimplePortalService()
        {
            response.Semesters = new List<Semester>();
            response.Semesters.Add(new Semester() { Year = DateTime.Now.Year, Period = "H1" });
            response.Semesters.Add(new Semester() { Year = DateTime.Now.Year, Period = "H2" });

            response.Departments = new List<Department>();
            response.Departments.Add(new Department("AI", "Artifical Intellience"));
            response.Departments.Add(new Department("AR", "Architecture"));
            response.Departments.Add(new Department("CS", "Computer Science", "Windows", "Linux"));
            response.Departments.Add(new Department("MS", "Management Systems"));

            response.Classes = new List<string>();
        }

        public Task<ClassroomResponse> GetClassroomAsync()
        {
            response.Status = StatusCodes.OK;
            response.ErrorMessage = null;
            return Task.FromResult<ClassroomResponse>(response);
        }

        public async Task<ClassroomResponse> AddClassroomAsync(AddClassroomRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.DisplayName) || response.Classes.Contains(request.DisplayName))
                {
                    response.Status = StatusCodes.Error;
                    response.ErrorMessage = "The class already exist!";
                }
                else
                {
                    response = await this.GetClassroomAsync();
                    response.Classes.Add(request.DisplayName);
                }
            }
            catch (Exception ex)
            {
                response.Status = StatusCodes.Error;
                response.ErrorMessage = ex.Message;
            }

            return response;
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