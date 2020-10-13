using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Student
    {
        public string firstName;
        public string secondName;
        public string univercity;
        public string faculty;
        public string department;
        public int age;
        public int сourse;
        public int group;
        public string city;

        public Student(string firstName, string secondName, string univercity, string faculty, string department, int age, int сourse, int group, string city)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.univercity = univercity;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.сourse = сourse;
            this.group = group;
            this.city = city;
        }

    }

    public class MyStudentClassComparer : IComparer
    {
        public int Compare(Student _x, Student _y)
        {
            if (_x == null)
                return (_y == null) ? 0 : 1;

            if (_y == null)
                return -1;

            Student p1 = _x;
            Student p2 = _y;

            return (p1.age - p2.age);
        }
    }
}
