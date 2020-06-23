using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Task2.Models
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public float AvgMark { get; set; }

        public Student() 
        {
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "*");
                HttpContext.Current.Response.End();
            }
        }

        public Student(string name, float avgMark)
        {
            Name = name;
            AvgMark = avgMark;
        }
    }
}