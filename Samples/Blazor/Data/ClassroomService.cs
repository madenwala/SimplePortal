using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Data
{
    public sealed class ClassroomService
    {
        public Task<ClassroomResponse> GetClassroomAsync()
        {
            return Task.FromResult<ClassroomResponse>(null);
        }
    }
}