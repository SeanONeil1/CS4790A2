using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4790A2.Models
{
    public class Repository
    {
        public static Course getCourse(int? id)
        {
            Course course = BasicSchool.getCourse(id);
            return course;
        }
    }

    public class CourseAndSections
    {
        public Course course { get; set; }
        public List<Section> sections { get; set; }
    }
}