﻿using System.Collections.Generic;

namespace SimplePortal.UI.Web.Data
{
    public abstract class BaseResponse
    {
        public StatusCodes Status { get; set; }
        public string ErrorMessage { get; set; }
    }

    public sealed class ClassroomResponse : BaseResponse
    {
        public List<Semester> Semesters { get; set; }
        public List<Department> Departments { get; set; }
        public List<string> Classes { get; set; }
    }

    public sealed class Semester
    {
        public int Year { get; set; }
        public string Period { get; set; }

        public string DisplayName { get { return $"{this.Year} {this.Period}".Trim(); } }
    }

    public sealed class Department
    {
        public Department(string shortName, string name, params string[] courseNames)
        {
            this.ShortName = shortName;
            this.Name = name;
            if (courseNames != null)
            {
                this.CourseTypes = new List<CourseType>();
                foreach (string courseName in courseNames)
                    this.CourseTypes.Add(new CourseType() { });
            }
        }

        public string ShortName { get; set; }
        public string Name { get; set; }
        public List<CourseType> CourseTypes { get; set; }

        public string DisplayName { get { return $"{this.ShortName} {this.Name}".Trim(); } }
    }

    public sealed class CourseType
    {
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

        public string DisplayName
        {
            get
            {
                return $"{this.Semester?.Year}{this.Semester?.Period} {this.Department?.ShortName}{this.ClassCode} {this.ClassName} {this.Department?.CourseTypes}".Replace("  ", "").Trim();
            }
        }
    }

    public enum StatusCodes
    {
        None,
        OK,
        Error
    }
}