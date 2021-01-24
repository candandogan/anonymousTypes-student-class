using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var classroom = new Class();

            try
            {
                while (true)
                {
                   
                    Console.WriteLine("WHICH OPERATION DO YOU WANT TO DO? \n1-Add Student \n2-Find Student by Name \n3-Find Student by Id \n4-Remove Student \n5-Show Students List \n6-Exit");
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a == 1)
                    {
                        Console.WriteLine("Enter the name of the student you want to add: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter the surname of the student you want to add: ");
                        string surname = Console.ReadLine();

                        Console.WriteLine("Enter the id of the student you want to add: ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        classroom.Add(new student { Name = name, Surname = surname, Id = b });

                        Console.WriteLine("Your registration has been added!\n\n\n");

                    }
                    if (a == 2)
                    {
                        Console.WriteLine("Enter the name of the student you want to search: ");
                        string arama = Console.ReadLine();
                        var f = classroom.GetStudentsByName(arama);
                        f.ForEach(stud => Console.WriteLine($"{stud.Name} named student's id is: {stud.Id} .\n\n\n"));
                    }
                    if (a == 3)
                    {
                        Console.WriteLine("Enter the id of the student you want to search: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        var getId = classroom.GetStudentById(c);
                        Console.WriteLine(getId.Id + "id student's name is: " + getId.Name+ "\n\n\n");
                    }
                    if (a == 4)
                    {
                        Console.WriteLine("Enter the school number of the student you want to delete: ");
                        int d = Convert.ToInt32(Console.ReadLine());
                        classroom.RemoveStudentById(d);
                        Console.WriteLine("Student Registration Removed!\n\n\n");
                        
                    }
                    if (a == 5)
                    {
                        Console.WriteLine("LIST OF STUDENTS ENROLLED IN THE CLASS");
                        classroom.showStudents();
                    }
                    if (a == 6)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e);
            }
            Console.ReadLine();
        }
    }
}
