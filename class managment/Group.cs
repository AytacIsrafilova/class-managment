using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_managment
{
    internal class Group
    {
        public int GroupNo;
        public int Studentlimit;
        private Student[] Students;
        public Group(int groupNo,int studentLimit)
        {
            GroupNo = groupNo;
            Studentlimit = studentLimit;
            Students = new Student[studentLimit];
        }
        public void StudentLimit()
        {
            if(Studentlimit >=5&&Studentlimit<=18)
            {
                Console.WriteLine(StudentLimit);
            }
        }
        
        public bool CheckGroupNo(string groupNo)
        {
            bool upperCheck=false;
            bool digitCheck=false;
            for (int i = 0; i <2 ; i++)
            {
                if (char.IsUpper(groupNo[i]))
                {
                    upperCheck = true;
                }
            }
            for (int i = 0;i< groupNo.Length; i++)
            {
                if (char.IsDigit(groupNo[i]))
                {
                    digitCheck = true;
                }
            }
            return upperCheck&& digitCheck;
            
        }
            
            
        public Student[]student=new Student[] {};
        public void AddStudent(Student student)
        {
            if(Studentlimit >= 5 && Studentlimit <= 18)
            {
                if (Students.Length >= Studentlimit)
                {
                    Console.WriteLine("Student limite catdi.");
                    return;
                }
            }
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length-1] = student;

        }
        public  Student  GetStudent(int _id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == _id)
                {
                    Console.WriteLine($"Student obyekti geri qaytarildi.");
                    return Students[i];
                }
            }return null;


        }
        public Student[] GetAllStudents()
        {
            return Students;

        }
    }
}
