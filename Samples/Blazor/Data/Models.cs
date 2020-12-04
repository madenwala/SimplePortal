namespace SimplePortal.UI.Web.Data
{
    public sealed class ClassroomResponse : BaseResponse
    {
        public Semester[] Semesters { get; set; }
        public Department[] Departments { get; set; }
    }

    public sealed class Semester
    {
        public int Year { get; set; }
        public string Period { get; set; }
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
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public sealed class AddClassroomResponse : BaseResponse
    {

    }

    public abstract class BaseResponse
    {
        public StatusCodes Status { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum StatusCodes
    {
        OK,
        Error
    }
}