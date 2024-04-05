using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_managment
{
    internal class Student
    {
        private static int _id;
        public int Id
        {
            get
            { return _id; }
            set
            { _id = value; }
        }
        
        public string FullName { get; set; }
        public double Point {  get; set; }
        public Student(int _id,string fullname,double point)
        {
            _id++;
            Id = _id;
            FullName = fullname;
            Point = point;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Id},{FullName},{Point}");
        }
    }
}
