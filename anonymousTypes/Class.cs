using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousTypes
{
    class Class
    {
        //student list created
        private List<student> students = new List<student>();

        //method of adding students
        public void Add(student std)
        {

            bool isStudentExist = false;
            string addQuestion;
            foreach (var student in students)
            {
                if (student.Name == std.Name && student.Surname == std.Surname) //Checking whether the student to be added is in the classroom
                {
                    isStudentExist = true;
                }
            }
            if (isStudentExist) 
            {
                Console.WriteLine("This student already recorded to class. Do you still want to add it to class? (yes/no)");
                addQuestion = Console.ReadLine().ToLower();
                if (addQuestion == "yes")
                    students.Add(std);
                else
                    Console.WriteLine("Student not added to class.");
            }
            else
            {
                students.Add(std);
            }
        }
        //method of searching students by name
        public List<student> GetStudentsByName(string name)
        {
            return students.Where(s => s.Name.Contains(name)).ToList();
        }

        //method of searching students by id
        public student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        //remove students method
        public List<student> RemoveStudentById(int id)
        {
            var toRemove = students.SingleOrDefault(s => s.Id == id);
            if (toRemove != null)
                students.Remove(toRemove);
            return students;
        }

        //The method of listing students enrolled in the class
        public void showStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"Students name: {item.Name}, surname:{item.Surname},  id:{item.Id}");
            }
        }
    }
}
