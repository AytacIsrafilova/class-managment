using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

namespace class_managment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool check = false;
            string fullName;
            int id;
            do
            {
                Console.WriteLine($"Studentin id-ni daxil edin:");
                

            } while (!int.TryParse(Console.ReadLine(), out  id));

            Console.WriteLine($"Fullname daxil edin:");
            fullName= Console.ReadLine();


            double point;
            do
            {
                Console.WriteLine($"Student pointi daxil edin:");
                
            }while (!double.TryParse(Console.ReadLine(), out  point));

            Student student=new Student(id,fullName,point);
            Group group=null;

            do
            {
                Console.WriteLine($"1.Show Info" +
                                  "\n2.Create new group");
                Console.WriteLine($"Secim edin");
                string answer= Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        student.ShowInfo();
                        break;
                    case "2":
                        int groupNo;
                        Console.WriteLine($"Group no daxil edin:");
                        while (!int.TryParse(Console.ReadLine(), out groupNo))
                        {
                            Console.WriteLine($"Yanlisdir! Duzgun group no daxil edin:");
                        }

                        int studentLimit;
                        Console.WriteLine($"Student limit daxil edin:");
                        while (!int.TryParse(Console.ReadLine(), out studentLimit))
                        {
                            Console.WriteLine($"Yanlisdir! Duzgun student limit daxil edin:");
                        }

                        group = new Group(groupNo, studentLimit);
                        
                   
                        switch (answer)
                        {
                            case "1":
                                Student[] students = group.GetAllStudents();
                                for (int i = 0; i < students.Length; i++)
                                {
                                    student.ShowInfo();
                                }
                                break;
                            case "2":
                                Student[] student1 = group.GetStudent(_id);
                                if (student1 != null)
                                {
                                    for (int i = 0; i < student1.Length; i++)
                                    {
                                        student1[i].ShowInfo();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Bu id ile student tapilmadi.");
                                }
                                
                                break;
                            case "3":
                                if (group != null)
                                {
                                    Console.WriteLine($"Studentin id-ni daxil edin:");
                                    while (!int.TryParse(Console.ReadLine(), out id))
                                    {
                                        Console.WriteLine($"Yanlisdir! Duzgun student id daxil edin:");
                                    }

                                    Console.WriteLine($"Fullname daxil edin:");
                                     fullName = Console.ReadLine();

                                    Console.WriteLine($"Student pointi daxil edin:");
                                    while (!double.TryParse(Console.ReadLine(), out point))
                                    {
                                        Console.WriteLine($"Yanlisdir! Duzgun student point daxil edin:");
                                    }

                                    student = new Student(id, fullName, point);
                                    group.AddStudent(student);
                                }
                                else
                                {
                                    Console.WriteLine($"Group yarat.");
                                }
                                break;
                            case "0":
                                Console.WriteLine($"Quit");
                                break;
                        }
                        break;
                        break;
                    default:
                        break;
                }

            } while (true);
            

        }
    }
}
