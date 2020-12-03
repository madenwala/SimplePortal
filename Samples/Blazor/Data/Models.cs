namespace Blazor.Data
{
    public sealed class ClassroomResponse
    {
        public Semester[] Semesters { get; set; }
        public Department[] Departments { get; set; }
    }

    public sealed class Semester
    {
        public long ID { get; set; }
        public int Year { get; set; }
        public string Quarter { get; set; }
    }

    public sealed class Department
    {
        public long ID { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public CourseType[] CourseTypes { get; set; }
    }

    public sealed class CourseType
    {
        public long ID { get; set; }
        public long Name { get; set; }
    }

    public sealed class AddClassroomRequest
    {
        public Semester Semester { get; set; }
        public Department Department { get; set; }
        public string ClassNumber { get; set; }
        public string ClassName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}