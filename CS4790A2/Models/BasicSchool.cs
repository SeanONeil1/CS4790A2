using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace CS4790A2.Models
{
    public class BasicSchool
    {
        public static Course getCourse(int? id)
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            Course course = db.courses.Find(id);

            return course;
        }

        public static List<Course> getAllCourses()
        {
            BasicSchoolDBContext db = new BasicSchoolDBContext();
            return db.courses.ToList();
        }

    
    }

    // Assert that the table name is NON-plural or Entity Framework will pluralize
    [Table("Course")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Course Number")]
        public string courseNumber { get; set; }
        [DisplayName("Course Name")]
        public string courseName { get; set; }
        [DisplayName("Credit Hours")]
        [Range(0, 4, ErrorMessage = "Oops!  Must be between 0 and 4 hours")]
        public int creditHours { get; set; }
        [DisplayName("Maximum Enrollment")]
        public int? maxEnrollment { get; set; }
    }

    [Table("Section")]
    public class Section
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Section ID")]
        public int sectionID { get; set; }
        [DisplayName("Section Number")]
        public int sectionNumber { get; set; }
        [DisplayName("Course Number")]
        public string courseNumber { get; set; }
        [DisplayName("Section Days")]
        public string sectionDays { get; set; }
        [DisplayName("Section Time")]
        public DateTime sectionTime { get; set; }
    }

    public class BasicSchoolDBContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Section> sections { get; set; }
    }
}