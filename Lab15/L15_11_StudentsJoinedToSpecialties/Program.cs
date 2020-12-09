using System;
using System.Collections.Generic;
using System.Linq;

namespace L15_11_StudentsJoinedToSpecialties
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<StudentSpecialty> specialties = new List<StudentSpecialty>();
            string command;
            while ((command = Console.ReadLine()) != "Students:")
            {
                string[] input = command.Split();
                specialties.Add(new StudentSpecialty(input[0] + " " + input[1], Convert.ToInt32(input[2])));
            }
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();
                students.Add(new Student(Convert.ToInt32(input[0]), input[1], input[2]));
            }

            var result = students.Join(specialties, st => st.FacultyNumber, sp => sp.FacultyNumber,
                         (st, sp) => new { Name = st.FirstName + " " + st.SecondName, FucNum = st.FacultyNumber, Speciality = sp.SpecialityName })
                            .OrderBy(s => s.Name);

            foreach (var r in result)
            {
                Console.WriteLine($"{r.Name} {r.FucNum} {r.Speciality}");
            }

            Console.ReadKey();
        }
    }
}
