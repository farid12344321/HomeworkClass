using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace HomeworClass
{
    internal class Student
    {

        
        public Student(string fullname,int point)
        {
            this.Fullname = fullname;
            this.Point = point;
        }

        public Student(string fullname,DateTime date,string groupName,int point):this(fullname,point)
        {
            this.BirthDate = date;
            this.GroupNo = groupName;
        }
        public string Fullname;
        public DateTime BirthDate;
        public string GroupNo;
        public int Point;
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Fullname}-BirthDate:{this.BirthDate.ToString("dd.MM.yyyy")}-GroupNo:{this.GroupNo}-Point:{this.Point}");
        }

    }
}
